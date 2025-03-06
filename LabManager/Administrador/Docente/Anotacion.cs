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
using LabManagerCliente.AdministradorDocenteService;
using LabManagerCliente.AdministradorAnotacionService;
namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Anotaciones AnotacionSeleccionadaDocente;

        private void fillAnotacionesDocente()
        {
            View_Docente Docente = (View_Docente)gridDocentes.SelectedRows[0].DataBoundItem;
            try
            {
                CargarEstadoAnotacion(ref EstadoAnotacionDocente);
                Mensaje.IniciaEspera();
                var list = AdministradorAnotacionCliente.getAnotaciones(Docente.UsuarioId);
                var datos = list.Items.ToList();
                mgAnotacionesDocente.DataSource = datos;
                mgAnotacionesDocente.Refresh();
                for (int i = 0; i < mgAnotacionesDocente.ColumnCount; i++)
                {
                    mgAnotacionesDocente.Columns[i].Visible = false;
                }
                mgAnotacionesDocente.Columns["Descripcion"].Visible = true;
                //if(list.Items.Length<=0) 
                mgAnotacionesDocente_Click(null, null);
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar anotación", ex.Message);
            }
        }

        private void mgAnotacionesDocente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                var item = (View_Anotaciones)mgAnotacionesDocente.Rows[e.RowIndex].DataBoundItem;
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

        private void EnableControlAnotacionesDocente(bool enable)
        {
            DescripcionAnotacionDocente.Enabled =
            EstadoAnotacionDocente.Enabled = enable;
        }

        private void mgAnotacionesDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgAnotacionesDocente.SelectedRows.Count > 0)
                {
                    var estados = (new AdministradorAnotacionClient()).getEstadosAnotacion();
                    AnotacionSeleccionadaDocente = (View_Anotaciones)((View_Anotaciones)mgAnotacionesDocente.SelectedRows[0].DataBoundItem).Clone();
                    DescripcionAnotacionDocente.Valor = AnotacionSeleccionadaDocente.Descripcion;
                    EstadoAnotacionDocente.mControl.ValueMember = "EstadoAnotacionId";
                    EstadoAnotacionDocente.mControl.DisplayMember = "Descripcion";
                    EstadoAnotacionDocente.mControl.DataSource = estados.Items;
                    EstadoAnotacionDocente.mControl.SelectedValue = AnotacionSeleccionadaDocente.EstadoAnotacionId;

                    infoRegistroAnotacionDocente.fechaCreado = AnotacionSeleccionadaDocente.FechaCreacion;
                    infoRegistroAnotacionDocente.creadoPor = AnotacionSeleccionadaDocente.NombreCreador;
                    infoRegistroAnotacionDocente.fechaModificado = AnotacionSeleccionadaDocente.FechaModificacion ?? new DateTime(1900, 1, 1);
                    infoRegistroAnotacionDocente.modificadoPor = AnotacionSeleccionadaDocente.NombreModifica;
                    if (AnotacionSeleccionadaDocente.EstadoAnotacionId == (int)View_Anotaciones.EstadosAnotacion.Activa)
                    {
                        EnableControlAnotacionesDocente(true);
                    }
                    else
                    {
                        EnableControlAnotacionesDocente(false);
                    }
                }
                else
                {
                    AnotacionSeleccionadaDocente = null;
                    DescripcionAnotacionDocente.Enabled = false;
                    EstadoAnotacionDocente.Enabled = false;
                    DescripcionAnotacionDocente.Valor = "";
                    EstadoAnotacionDocente.mControl.SelectedValue = -1;
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando anotaciones", ex.Message);
            }
        }

        private void GuardaAnotacionDocente()
        {
            if (!DescripcionAnotacionDocente.Enabled) return;
            AnotacionSeleccionadaDocente.Descripcion = DescripcionAnotacionDocente.Valor;
            AnotacionSeleccionadaDocente.EstadoAnotacionId = (int)(EstadoAnotacionDocente.mControl.SelectedValue?? (int)View_Anotaciones.EstadosAnotacion.Activa);
            if (AnotacionSeleccionadaDocente != null && AnotacionSeleccionadaDocente.AnotacionId != 0)
            {
                string mensaje = "¿Quiere guardar la anotacion con los siguientes valores?";
                mensaje += "\r\nDescripcion: " + AnotacionSeleccionadaDocente.Descripcion;
                mensaje += "\r\nEstado: " + EstadoAnotacionDocente.mControl.Text;
                if (Mensaje.PreguntaSiNo("Modificar anotación", mensaje) == DialogResult.Yes)
                {
                    AnotacionSeleccionadaDocente.ModificadoId = usuario.UsuarioId;
                    AdministradorAnotacionCliente.EditAnotacion(AnotacionSeleccionadaDocente);
                }
            }
            else
            {
                AnotacionSeleccionadaDocente.CreadoId = usuario.UsuarioId;
                AnotacionSeleccionadaDocente.UsuarioId = DocenteSeleccionado.UsuarioId;
                AdministradorAnotacionCliente.AddAnotacion(AnotacionSeleccionadaDocente);
            }
            fillAnotacionesDocente();
        }

        private void pbGuardarAnotacionDocente_Click(object sender, EventArgs e)
        {
            try
            {
                GuardaAnotacionDocente();
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardar anotación", ex.Message);
            }
        }

        private void pbNuevaAnotacionDocente_Click(object sender, EventArgs e)
        {
            try
            {
                AnotacionSeleccionadaDocente = new View_Anotaciones();
                EstadoAnotacionDocente.mControl.SelectedValue = (int)View_Anotaciones.EstadosAnotacion.Activa;
                DescripcionAnotacionDocente.Valor = "";
                infoRegistroAnotacionDocente.creadoPor = "";
                infoRegistroAnotacionDocente.modificadoPor = "";
                infoRegistroAnotacionDocente.fechaCreado = new DateTime(1900, 1, 1);
                infoRegistroAnotacionDocente.fechaModificado = new DateTime(1900, 1, 1);
                EnableControlAnotacionesDocente(true);
                EstadoAnotacionDocente.Enabled = false;
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando anotación", ex.Message);
            }
        }
    }
}
