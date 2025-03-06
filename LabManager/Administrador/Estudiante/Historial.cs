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

namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private void fillHistorial()
        {
            if (gridEstudiantes.SelectedRows.Count > 0)
            {
                View_Estudiante estudiante = (View_Estudiante)gridEstudiantes.SelectedRows[0].DataBoundItem;
                try
                {
                    Mensaje.IniciaEspera();
                    var list = AdministradorEstudianteCliente.getHistorialBasico(
                        estudiante.UsuarioId,
                        new DateTime(historialFechaDesde.Valor.Year, historialFechaDesde.Valor.Month, historialFechaDesde.Valor.Day),
                        new DateTime(historialFechaHasta.Valor.Year, historialFechaHasta.Valor.Month, historialFechaHasta.Valor.Day, 23, 59, 59)
                        );
                    var datos = list.Items.ToList();
                    mgHistorial.DataSource = datos;
                    mgHistorial.Refresh();
                    for (int i = 0; i < mgHistorial.ColumnCount; i++)
                    {
                        mgHistorial.Columns[i].Visible = false;
                    }
                    mgHistorial.Columns["Descripcion"].Visible = true;
                    mgHistorial.Columns["CodigoLaboratorio"].Visible = true;
                    mgHistorial.Columns["FechaPrestamo"].Visible = true;
                    mgHistorial.Columns["FechaRecepcion"].Visible = true;
                    Mensaje.TerminaEspera();
                }
                catch (Exception ex)
                {
                    Mensaje.TerminaEspera();
                    Mensaje.Error("Buscar historial", ex.Message);
                }
            }
        }

        private void HistorialFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            fillHistorial();
        }

        private void HistorialFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            fillHistorial();
        }

        private void mgHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            var item = (View_Historial_Estudiante)mgHistorial.Rows[e.RowIndex].DataBoundItem;
            if (item.FechaRecepcion == null)
            {
                e.CellStyle.ForeColor = Color.Red;
            }
                
        }
    }
}
