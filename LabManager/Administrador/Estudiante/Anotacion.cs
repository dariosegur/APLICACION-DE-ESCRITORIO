using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabManagerCliente;
using LabManagerCliente.AdministradorEstudianteService;
using LabManagerCliente.AdministradorAnotacionService;
namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Anotaciones AnotacionSeleccionada;

        private void fillAnotaciones()
        {
            View_Estudiante estudiante = (View_Estudiante)gridEstudiantes.SelectedRows[0].DataBoundItem;
            try
            {
                CargarEstadoAnotacion(ref AnotacionEstado);
                Mensaje.IniciaEspera();
                var list = AdministradorAnotacionCliente.getAnotaciones(estudiante.UsuarioId);
                var datos = list.Items.ToList();
                mgAnotaciones.DataSource = datos;
                mgAnotaciones.Refresh();
                for (int i = 0; i < mgAnotaciones.ColumnCount; i++)
                {
                    mgAnotaciones.Columns[i].Visible = false;
                }
                mgAnotaciones.Columns["Descripcion"].Visible = true;
                mgAnotaciones_Click(null, null);
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar anotación", ex.Message);
            }
        }

        private void mgAnotaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                var item = (View_Anotaciones)mgAnotaciones.Rows[e.RowIndex].DataBoundItem;
                switch (item.EstadoAnotacionId)
                {
                    case (int)View_Anotaciones.EstadosAnotacion.Activa:
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;
                        break;
                    case (int)View_Anotaciones.EstadosAnotacion.Atendida:
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.SelectionForeColor = Color.Green;
                        break;
                    case (int)View_Anotaciones.EstadosAnotacion.Anulada:
                        e.CellStyle.ForeColor = Color.Blue;
                        e.CellStyle.SelectionForeColor = Color.Blue;
                        break;
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Formato de anotaciones", ex.Message);
            }
        }

        private void EnableControlAnotaciones(bool enable)
        {
            AnotacionDescripcion.Enabled =
            AnotacionEstado.Enabled = enable;
        }

        private void mgAnotaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgAnotaciones.SelectedRows.Count > 0)
                {
                    var estados = (new AdministradorAnotacionClient()).getEstadosAnotacion();
                    AnotacionSeleccionada = (View_Anotaciones)((View_Anotaciones)mgAnotaciones.SelectedRows[0].DataBoundItem).Clone();
                    AnotacionDescripcion.Valor = AnotacionSeleccionada.Descripcion;
                    AnotacionEstado.mControl.ValueMember = "EstadoAnotacionId";
                    AnotacionEstado.mControl.DisplayMember = "Descripcion";
                    AnotacionEstado.mControl.DataSource = estados.Items;
                    AnotacionEstado.mControl.SelectedValue = AnotacionSeleccionada.EstadoAnotacionId;

                    infoRegistroAnotacionEstudiante.fechaCreado = AnotacionSeleccionada.FechaCreacion;
                    infoRegistroAnotacionEstudiante.creadoPor = AnotacionSeleccionada.NombreCreador;
                    infoRegistroAnotacionEstudiante.fechaModificado = AnotacionSeleccionada.FechaModificacion ?? new DateTime(1900, 1, 1);
                    infoRegistroAnotacionEstudiante.modificadoPor = AnotacionSeleccionada.NombreModifica;
                    if (AnotacionSeleccionada.EstadoAnotacionId == (int)View_Anotaciones.EstadosAnotacion.Activa)
                    {
                        EnableControlAnotaciones(true);
                    }
                    else
                    {
                        EnableControlAnotaciones(false);
                    }
                }
                else
                {
                    AnotacionSeleccionada = null;
                    AnotacionDescripcion.Enabled =
                            AnotacionEstado.Enabled = false;
                    AnotacionDescripcion.Valor = "";
                    AnotacionEstado.mControl.SelectedValue = -1;
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando anotaciones", ex.Message);
            }
        }

        private void GuardaAnotacion()
        {
            if (!AnotacionDescripcion.Enabled) return;
            AnotacionSeleccionada.Descripcion = AnotacionDescripcion.Valor;
            AnotacionSeleccionada.EstadoAnotacionId = (int)(AnotacionEstado.mControl.SelectedValue?? (int)View_Anotaciones.EstadosAnotacion.Activa);
            if (AnotacionSeleccionada != null && AnotacionSeleccionada.AnotacionId != 0)
            {
                string mensaje = "¿Quiere guardar la anotacion con los siguientes valores?";
                mensaje += "\r\nDescripcion: " + AnotacionSeleccionada.Descripcion;
                mensaje += "\r\nEstado: " + AnotacionEstado.mControl.Text;
                if (Mensaje.PreguntaSiNo("Modificar anotación", mensaje) == DialogResult.Yes)
                {
                    AnotacionSeleccionada.ModificadoId = usuario.UsuarioId;
                    AdministradorAnotacionCliente.EditAnotacion(AnotacionSeleccionada);
                }
            }
            else
            {
                AnotacionSeleccionada.CreadoId = usuario.UsuarioId;
                AnotacionSeleccionada.UsuarioId = EstudianteSeleccionado.UsuarioId;
                AdministradorAnotacionCliente.AddAnotacion(AnotacionSeleccionada);
            }
            fillAnotaciones();
        }

        private void pbGuardarAnotacion_Click(object sender, EventArgs e)
        {
            try
            {
                GuardaAnotacion();
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardar anotación", ex.Message);
            }
        }

        private void pbNuevaAnotacion_Click(object sender, EventArgs e)
        {
            try
            {
                AnotacionSeleccionada = new View_Anotaciones();
                AnotacionEstado.mControl.SelectedValue = (int)View_Anotaciones.EstadosAnotacion.Activa;
                AnotacionDescripcion.Valor = "";
                infoRegistroAnotacionEstudiante.creadoPor = "";
                infoRegistroAnotacionEstudiante.modificadoPor = "";
                infoRegistroAnotacionEstudiante.fechaCreado = new DateTime(1900, 1, 1);
                infoRegistroAnotacionEstudiante.fechaModificado = new DateTime(1900, 1, 1);
                EnableControlAnotaciones(true);
                AnotacionEstado.Enabled = false;
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando anotación", ex.Message);
            }
        }
    }
}
