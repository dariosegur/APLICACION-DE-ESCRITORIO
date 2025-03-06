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

namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private void fillHistorialDocente()
        {
            if (gridDocentes.SelectedRows.Count > 0)
            {
                View_Docente Docente = (View_Docente)gridDocentes.SelectedRows[0].DataBoundItem;
                try
                {
                    Mensaje.IniciaEspera();
                    var list = AdministradorDocenteCliente.getHistorialBasico(
                        Docente.UsuarioId,
                        new DateTime(FechaDesdeHistorialDocente.Valor.Year, FechaDesdeHistorialDocente.Valor.Month, FechaDesdeHistorialDocente.Valor.Day),
                        new DateTime(FechaHastaHistorialDocente.Valor.Year, FechaHastaHistorialDocente.Valor.Month, FechaHastaHistorialDocente.Valor.Day, 23, 59, 59)
                        );
                    var datos = list.Items.OrderByDescending(a => a.FechaPrestamo).ThenByDescending(a => a.FechaRecepcion).ToList();
                    mgHistorialDocente.DataSource = datos;
                    mgHistorialDocente.Refresh();
                    for (int i = 0; i < mgHistorialDocente.ColumnCount; i++)
                    {
                        mgHistorialDocente.Columns[i].Visible = false;
                    }
                    mgHistorialDocente.Columns["Descripcion"].Visible = true;
                    mgHistorialDocente.Columns["CodigoLaboratorio"].Visible = true;
                    mgHistorialDocente.Columns["FechaPrestamo"].Visible = true;
                    mgHistorialDocente.Columns["FechaRecepcion"].Visible = true;
                    Mensaje.TerminaEspera();
                }
                catch (Exception ex)
                {
                    Mensaje.TerminaEspera();
                    Mensaje.Error("Buscar historial", ex.Message);
                }
            }
        }

        private void HistorialFechaHastaDocente_ValueChanged(object sender, EventArgs e)
        {
            fillHistorialDocente();
        }

        private void HistorialFechaDesdeDocente_ValueChanged(object sender, EventArgs e)
        {
            fillHistorialDocente();
        }

        private void mgHistorialDocente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            var item = (View_Historial_Docente)mgHistorialDocente.Rows[e.RowIndex].DataBoundItem;
            if (item.FechaRecepcion == null)
            {
                e.CellStyle.ForeColor = Color.Red;
            }

        }
    }
}
