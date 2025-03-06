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
using LabManagerCliente.AdministradorRestriccionService;
namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Restriccion RestriccionSeleccionada = new View_Restriccion();

        private void gridRestriccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridRestriccion.SelectedRows.Count > 0)
                {
                    RestriccionSeleccionada = (View_Restriccion)((View_Restriccion)gridRestriccion.SelectedRows[0].DataBoundItem).Clone();

                    DescripcionRestriccion.Valor = RestriccionSeleccionada.Descripcion;
                    TextoRestriccion.Valor = RestriccionSeleccionada.Texto;
                    ActivoRestriccion.Valor = RestriccionSeleccionada.Activo;

                    informacionRegistroRestriccion.fechaCreado = RestriccionSeleccionada.FechaCreacion;
                    informacionRegistroRestriccion.creadoPor = RestriccionSeleccionada.Creado;
                    informacionRegistroRestriccion.fechaModificado = RestriccionSeleccionada.FechaModificacion ?? new DateTime(1900, 1, 1);
                    informacionRegistroRestriccion.modificadoPor = RestriccionSeleccionada.Modificado;
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando facultades", ex.Message);
            }
        }

        private void BuscarListaRestriccion()
        {
            try
            {
                Mensaje.IniciaEspera();
                var list = AdministradorRestriccionCliente.getRestricciones(FiltroRestriccion.Text, null);
                var datos = list.Items.OrderBy(f => f.Descripcion).ToList();


                gridRestriccion.DataSource = datos;
                gridRestriccion.Refresh();

                for (int i = 0; i < gridRestriccion.ColumnCount; i++)
                {
                    gridRestriccion.Columns[i].Visible = false;
                }
                gridRestriccion.Columns["Descripcion"].Visible = true;
                gridRestriccion.Columns["Descripcion"].DisplayIndex = 1;
                gridRestriccion.Columns["Texto"].Visible = true;
                gridRestriccion.Columns["Texto"].DisplayIndex = 2;
                gridRestriccion.Columns["Activo"].Visible = true;
                gridRestriccion.Columns["Activo"].DisplayIndex = 3;
                gridRestriccion_Click(null, null);

                mtDetalleFacultad.SelectedIndex = 0;
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar restriccion", ex.Message);
            }
            tbFiltro.Focus();
        }

        private void GuardarRestriccion()
        {
            RestriccionSeleccionada.Descripcion = DescripcionRestriccion.Valor;
            RestriccionSeleccionada.Texto = TextoRestriccion.Valor;
            RestriccionSeleccionada.Activo = ActivoRestriccion.Valor ?? true;

            if (RestriccionSeleccionada != null && RestriccionSeleccionada.RestriccionId != -1)
            {
                string mensaje = "¿Quiere guardar la restricción con los siguientes valores?";
                mensaje += "\r\nDescripcion: " + RestriccionSeleccionada.Descripcion;
                mensaje += "\r\nTexto: " + RestriccionSeleccionada.Texto;
                mensaje += "\r\nActivo: " + ((ActivoRestriccion.Valor ?? true) ? "Si" : "No");
                if (Mensaje.PreguntaSiNo("Modificar restricción", mensaje) == DialogResult.Yes)
                {
                    RestriccionSeleccionada.ModificadoId = usuario.UsuarioId;
                    AdministradorRestriccionCliente.EditarRestriccion(RestriccionSeleccionada);
                }
            }
            else
            {
                RestriccionSeleccionada.CreadoId = usuario.UsuarioId;
                AdministradorRestriccionCliente.AddRestriccion(RestriccionSeleccionada);
            }
        }

        private void pbGuardarRestriccion_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarRestriccion();
                FiltroRestriccion.Text = RestriccionSeleccionada.Descripcion;
                BuscarListaRestriccion();
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardar restriccion", ex.Message);
            }
        }

        private void pbNuevaRestriccion_Click(object sender, EventArgs e)
        {
            try
            {
                RestriccionSeleccionada = new View_Restriccion();
                DescripcionRestriccion.Valor = "";
                TextoRestriccion.Valor = "";
                ActivoRestriccion.Valor = true;
                informacionRegistroRestriccion.creadoPor = "";
                informacionRegistroRestriccion.modificadoPor = "";
                informacionRegistroRestriccion.fechaCreado = new DateTime(1900, 1, 1);
                informacionRegistroRestriccion.fechaModificado = new DateTime(1900, 1, 1);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando restricción", ex.Message);
            }
        }

        private void pbRestriccionBuscar_Click(object sender, EventArgs e)
        {
            BuscarListaRestriccion();
        }

        private void tbFiltroRestriccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarListaRestriccion();
                e.Handled = true;
            }
        }
    }
}
