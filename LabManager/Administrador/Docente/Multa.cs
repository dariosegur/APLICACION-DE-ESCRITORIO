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
using LabManagerCliente.AdministradorDocenteService;

namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Multas MultaSeleccionadaDocente;

        private void fillMultasDocente()
        {
            View_Docente docente = (View_Docente)gridDocentes.SelectedRows[0].DataBoundItem;
            try
            {
                Mensaje.IniciaEspera();
                CargarEstadoMulta(ref EstadoMultaDocente);
                var list = AdministradorMultaCliente.getMultas(docente.UsuarioId);
                var datos = list.Items.ToList();
                mgMultasDocente.DataSource = datos;
                mgMultasDocente.Refresh();
                for (int i = 0; i < mgMultasDocente.ColumnCount; i++)
                {
                    mgMultasDocente.Columns[i].Visible = false;
                }
                mgMultasDocente.Columns["Descripcion"].Visible = true;
                mgMultasDocente_Click(null, null);
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar multa", ex.Message);
            }
        }

        private void mgMultasDocente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                var item = (View_Multas)mgMultasDocente.Rows[e.RowIndex].DataBoundItem;
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
                Mensaje.Error("Formato de multas", ex.Message);
            }
        }

        private void EnableControlMultasDocente(bool enable)
        {
            ValorMultaDocente.Enabled=
                DescripcionMultaDocente.Enabled =
            EstadoMultaDocente.Enabled = enable;
        }

        private void mgMultasDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgMultasDocente.SelectedRows.Count > 0)
                {
                    var estados = (new AdministradorMultaClient()).getEstadosMulta();
                    MultaSeleccionadaDocente = (View_Multas)((View_Multas)mgMultasDocente.SelectedRows[0].DataBoundItem).Clone();
                    ValorMultaDocente.ValorEntero = MultaSeleccionadaDocente.Valor;
                    DescripcionMultaDocente.Valor = MultaSeleccionadaDocente.Descripcion;
                    EstadoMultaDocente.mControl.ValueMember = "EstadoMultaId";
                    EstadoMultaDocente.mControl.DisplayMember = "Descripcion";
                    EstadoMultaDocente.mControl.DataSource = estados.Items;
                    EstadoMultaDocente.mControl.SelectedValue = MultaSeleccionadaDocente.EstadoMultaId;
                    infoRegistroMultaDocente.fechaCreado = MultaSeleccionadaDocente.FechaCreacion;
                    infoRegistroMultaDocente.creadoPor = MultaSeleccionadaDocente.NombreCreador;
                    infoRegistroMultaDocente.fechaModificado = MultaSeleccionadaDocente.FechaModificacion ?? new DateTime(1900, 1, 1);
                    infoRegistroMultaDocente.modificadoPor = MultaSeleccionadaDocente.NombreModifica;
                    if (MultaSeleccionadaDocente.EstadoMultaId == (int)View_Multas.EstadosMulta.Activa)
                    {
                        EnableControlMultasDocente(true);
                    }
                    else
                    {
                        EnableControlMultasDocente(false);
                    }
                }
                else
                {
                    MultaSeleccionadaDocente = null;
                    DescripcionMultaDocente.Enabled =
                            EstadoMultaDocente.Enabled = false;
                    DescripcionMultaDocente.Valor = "";
                    ValorMultaDocente.ValorEntero = 0;
                    EstadoMultaDocente.mControl.SelectedValue = -1;
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando multas", ex.Message);
            }
        }

        private void GuardaMultaDocente()
        {
            if (!DescripcionMultaDocente.Enabled) return;
            MultaSeleccionadaDocente.Descripcion = DescripcionMultaDocente.Valor;
            MultaSeleccionadaDocente.EstadoMultaId = (int)EstadoMultaDocente.mControl.SelectedValue;
            MultaSeleccionadaDocente.Valor = ValorMultaDocente.ValorEntero??0;
            if (MultaSeleccionadaDocente != null && MultaSeleccionadaDocente.MultaId != 0)
            {
                string mensaje = "¿Quiere guardar la multa con los siguientes valores?";
                mensaje += "\r\nDescripcion: " + MultaSeleccionadaDocente.Descripcion;
                mensaje += "\r\nValor: " + MultaSeleccionadaDocente.Valor;
                mensaje += "\r\nEstado: " + EstadoMultaDocente.mControl.Text;
                if (Mensaje.PreguntaSiNo("Modificar multa", mensaje) == DialogResult.Yes)
                {
                    MultaSeleccionadaDocente.ModificadoId = usuario.UsuarioId;
                    AdministradorMultaCliente.EditMulta(MultaSeleccionadaDocente);
                }
            }
            else
            {
                MultaSeleccionadaDocente.CreadoId = usuario.UsuarioId;
                MultaSeleccionadaDocente.DeudorId = DocenteSeleccionado.UsuarioId;
                AdministradorMultaCliente.AddMulta(MultaSeleccionadaDocente);
            }
            fillMultasDocente();
        }

        private void pbGuardarMultaDocente_Click(object sender, EventArgs e)
        {
            try
            {
                GuardaMultaDocente();
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardar multa", ex.Message);
            }
        }

        private void pbNuevaMultaDocente_Click(object sender, EventArgs e)
        {
            try
            {
                MultaSeleccionadaDocente = new View_Multas();
                EstadoMultaDocente.mControl.SelectedValue = (int)View_Multas.EstadosMulta.Activa;
                DescripcionMultaDocente.Valor = "";
                ValorMultaDocente.ValorEntero = 0;
                infoRegistroMultaDocente.creadoPor = "";
                infoRegistroMultaDocente.modificadoPor = "";
                infoRegistroMultaDocente.fechaCreado = new DateTime(1900, 1, 1);
                infoRegistroMultaDocente.fechaModificado = new DateTime(1900, 1, 1);
                EnableControlMultasDocente(true);
                EstadoMultaDocente.Enabled = false;
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando multa", ex.Message);
            }
        }
    }
}
