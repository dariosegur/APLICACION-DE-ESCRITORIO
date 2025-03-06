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
using LabManagerCliente.AdministradorSedeService;
namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Sede SedeSeleccionado =new View_Sede();

        private void gridSede_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridSede.SelectedRows.Count > 0)
                {
                    SedeSeleccionado = (View_Sede)((View_Sede)gridSede.SelectedRows[0].DataBoundItem).Clone();
                    ActivoSede.Valor = SedeSeleccionado.Activo;
                    NombreSede.mControl.Text = SedeSeleccionado.Nombre;
                    infoRegistroSede.fechaCreado = SedeSeleccionado.FechaCreacion;
                    infoRegistroSede.creadoPor = SedeSeleccionado.Creado;
                    infoRegistroSede.fechaModificado = SedeSeleccionado.FechaModificacion ?? new DateTime(1900, 1, 1);
                    infoRegistroSede.modificadoPor = SedeSeleccionado.Modificado;
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando sede", ex.Message);
            }
        }

        private void BuscarSede()
        {
            try
            {
                Mensaje.IniciaEspera();
                var list = AdministradorSedeCliente.getSede(FiltroSedes.Text, null);
                var datos = list.Items.OrderBy(a => a.Nombre).ThenByDescending(a => a.Activo).ToList();

                gridSede.DataSource = datos;
                gridSede.Refresh();
                gridSede.SetVisibleColumns(new string[] { "Nombre", "Activo" });
                gridSede_Click(null, null);

                mtDetalleTipoEquipo.SelectedIndex = 0;
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar sede", ex.Message);
            }
            tbFiltro.Focus();
        }

        private void GuardarSede()
        {
            SedeSeleccionado.Nombre = NombreSede.mControl.Text;
            SedeSeleccionado.Activo = ActivoSede.Valor ?? true;

            if (SedeSeleccionado != null && SedeSeleccionado.SedeId != 0)
            {
                string mensaje = "¿Quiere guardar la sede con los siguientes valores?";
                mensaje += "\r\nNombre: " + SedeSeleccionado.Nombre;
                mensaje += "\r\nActivo: " + ((ActivoSede.Valor ?? true) ? "Si" : "No");
                if (Mensaje.PreguntaSiNo("Modificar la sede", mensaje) == DialogResult.Yes)
                {
                    SedeSeleccionado.ModificadoId = usuario.UsuarioId;
                    AdministradorSedeCliente.EditSede(SedeSeleccionado);
                }
            }
            else
            {
                SedeSeleccionado.CreadoId = usuario.UsuarioId;
                AdministradorSedeCliente.AddSede(SedeSeleccionado);
            }
        }

        private void pbGuardaSede_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarSede();
                FiltroSedes.Text = SedeSeleccionado.Nombre;
                BuscarSede();
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardar sede", ex.Message);
            }
        }

        private void pbNuevaSede_Click(object sender, EventArgs e)
        {
            try
            {
                SedeSeleccionado = new View_Sede();
                NombreSede.mControl.Text = "";
                ActivoSede.Valor = true;
                infoRegistroSede.creadoPor = "";
                infoRegistroSede.modificadoPor = "";
                infoRegistroSede.fechaCreado = new DateTime(1900, 1, 1);
                infoRegistroSede.fechaModificado = new DateTime(1900, 1, 1);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando sede", ex.Message);
            }
        }

        private void pbBuscaSedes_Click(object sender, EventArgs e)
        {
            BuscarSede();
        }

        private void FiltroSedes_Enter(object sender, EventArgs e)
        {
            BuscarSede();
        }

        private void FiltroSedes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarSede();
                e.Handled = true;
            }
        }
    }
}
