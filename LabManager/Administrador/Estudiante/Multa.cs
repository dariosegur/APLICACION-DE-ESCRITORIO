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
using LabManagerCliente.AdministradorMultaService;
using LabManagerCliente.AdministradorEstudianteService;

namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Multas MultaSeleccionada;

        private void fillMultas()
        {
            View_Estudiante estudiante = (View_Estudiante)gridEstudiantes.SelectedRows[0].DataBoundItem;
            try
            {
                Mensaje.IniciaEspera();
                var list = AdministradorMultaCliente.getMultas(estudiante.UsuarioId);
                CargarEstadoMulta(ref MultaEstado);
                var datos = list.Items.ToList();
                mgMultas.DataSource = datos;
                mgMultas.Refresh();
                for (int i = 0; i < mgMultas.ColumnCount; i++)
                {
                    mgMultas.Columns[i].Visible = false;
                }
                mgMultas.Columns["Descripcion"].Visible = true;
                mgMultas_Click(null, null);
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar multa", ex.Message);
            }
        }

        private void mgMultas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                var item = (View_Multas)mgMultas.Rows[e.RowIndex].DataBoundItem;
                switch (item.EstadoMultaId)
                {
                    case (int)View_Multas.EstadosMulta.Activa:
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;
                        break;
                    case (int)View_Multas.EstadosMulta.Pagada:
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.SelectionForeColor = Color.Green;
                        break;
                    case (int)View_Multas.EstadosMulta.Anulada:
                        e.CellStyle.ForeColor = Color.Blue;
                        e.CellStyle.SelectionForeColor = Color.Blue;
                        break;
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Formato de multas",ex.Message);
            }
        }

        private void EnableControlMultas(bool enable)
        {
            MultaValor.Enabled =
            MultaDescripcion.Enabled =
            MultaEstado.Enabled = enable;
        }

        private void mgMultas_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgMultas.SelectedRows.Count > 0)
                {
                    var estados = (new AdministradorMultaClient()).getEstadosMulta();
                    MultaSeleccionada = (View_Multas)((View_Multas)mgMultas.SelectedRows[0].DataBoundItem).Clone();
                    MultaValor.ValorEntero = MultaSeleccionada.Valor;
                    MultaDescripcion.Valor = MultaSeleccionada.Descripcion;
                    MultaEstado.mControl.ValueMember = "EstadoMultaId";
                    MultaEstado.mControl.DisplayMember = "Descripcion";
                    MultaEstado.mControl.DataSource = estados.Items;
                    MultaEstado.mControl.SelectedValue = MultaSeleccionada.EstadoMultaId;
                    infoRegistroMultaEstudiante.fechaCreado = MultaSeleccionada.FechaCreacion;
                    infoRegistroMultaEstudiante.creadoPor = MultaSeleccionada.NombreCreador;
                    infoRegistroMultaEstudiante.fechaModificado = MultaSeleccionada.FechaModificacion ?? new DateTime(1900,1,1);
                    infoRegistroMultaEstudiante.modificadoPor = MultaSeleccionada.NombreModifica;
                    if (MultaSeleccionada.EstadoMultaId == (int)View_Multas.EstadosMulta.Activa)
                    {
                        EnableControlMultas(true);
                    }
                    else
                    {
                        EnableControlMultas(false);
                    }
                }
                else
                {
                    MultaSeleccionada = null;
                    MultaValor.Enabled =
                            MultaDescripcion.Enabled =
                            MultaEstado.Enabled = false;
                    MultaValor.Valor = "";
                    MultaDescripcion.Valor = "";
                    MultaEstado.mControl.SelectedValue = -1;
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando multas", ex.Message);
            }
        }

        private void GuardaMulta()
        {
            if (!MultaDescripcion.Enabled) return;
            MultaSeleccionada.Descripcion = MultaDescripcion.Valor;
            MultaSeleccionada.Valor = MultaValor.ValorEntero??-1;
            MultaSeleccionada.EstadoMultaId = (int)MultaEstado.mControl.SelectedValue;            
            if (MultaSeleccionada != null && MultaSeleccionada.MultaId != 0)
            {
                string mensaje = "¿Quiere guardar la multa con los siguientes valores?";
                mensaje += "\r\nDescripcion: " + MultaSeleccionada.Descripcion;
                mensaje += "\r\nValor: " + MultaSeleccionada.Valor;
                mensaje += "\r\nEstado: " + MultaEstado.mControl.Text;
                if (Mensaje.PreguntaSiNo("Modificar multa", mensaje) == DialogResult.Yes)
                {
                    MultaSeleccionada.ModificadoId = usuario.UsuarioId;
                    AdministradorMultaCliente.EditMulta(MultaSeleccionada);
                }
            }
            else
            {
                MultaSeleccionada.CreadoId = usuario.UsuarioId;
                MultaSeleccionada.DeudorId = EstudianteSeleccionado.UsuarioId;
                AdministradorMultaCliente.AddMulta(MultaSeleccionada);
            }
            fillMultas();
        }

        private void pbGuardarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                GuardaMulta();
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardar multa", ex.Message);
            }
        }

        private void pbNuevaMulta_Click(object sender, EventArgs e)
        {
            try
            {
                MultaSeleccionada = new View_Multas();
                MultaEstado.mControl.SelectedValue = (int)View_Multas.EstadosMulta.Activa;
                MultaDescripcion.Valor = "";
                MultaValor.ValorEntero = 0;
                infoRegistroMultaEstudiante.creadoPor = "";
                infoRegistroMultaEstudiante.modificadoPor = "";
                infoRegistroMultaEstudiante.fechaCreado = new DateTime(1900,1,1);
                infoRegistroMultaEstudiante.fechaModificado = new DateTime(1900,1,1);
                EnableControlMultas(true);
                MultaEstado.Enabled = false;
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando multa", ex.Message);
            }
        }
    }
}
