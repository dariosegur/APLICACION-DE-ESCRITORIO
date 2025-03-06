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
using LabManagerCliente.AdministradorEquipoService;

namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private void fillHistorialEquipo()
        {
            if (gridEquipo.SelectedRows.Count > 0)
            {
                View_Equipo Equipo = (View_Equipo)gridEquipo.SelectedRows[0].DataBoundItem;
                try
                {
                    Mensaje.IniciaEspera();
                    var list = AdministradorEquipoCliente.getHistorial(
                        Equipo.EquipoId,
                        new DateTime(HistorialFechaDesdeEquipo.Valor.Year, HistorialFechaDesdeEquipo.Valor.Month, HistorialFechaDesdeEquipo.Valor.Day),
                        new DateTime(HistorialFechaHastaEquipo.Valor.Year, HistorialFechaHastaEquipo.Valor.Month, HistorialFechaHastaEquipo.Valor.Day, 23, 59, 59)
                        );
                    var datos = list.Items.OrderByDescending(a => a.FechaPrestamo).ThenByDescending(a => a.FechaRecepcion).ToList();
                    gridHistorialEquipo.DataSource = datos;
                    gridHistorialEquipo.Refresh();
                    gridHistorialEquipo.SetVisibleColumns(new string[] {
                        "UsuarioResponsable",
                        "UsuarioDocumento",
                        "FechaPrestamo",
                        "FechaRecepcion"
                    });
                    Mensaje.TerminaEspera();
                }
                catch (Exception ex)
                {
                    Mensaje.TerminaEspera();
                    Mensaje.Error("Buscar historial", ex.Message);
                }
            }
        }

        private void HistorialFechaDesdeEquipo_ValueChanged(object sender, EventArgs e)
        {
            fillHistorialEquipo();
        }

        private void HistorialFechaHastaEquipo_ValueChanged(object sender, EventArgs e)
        {
            fillHistorialEquipo();
        }

        private void mgHistorialEquipo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            var item = (View_Historial_Equipo)gridHistorialEquipo.Rows[e.RowIndex].DataBoundItem;
            if (item.FechaRecepcion == null)
            {
                e.CellStyle.ForeColor = Color.Red;
            }

        }
    }
}
