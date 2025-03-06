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
using LabManagerCliente.AdministradorTipoEquipoService;
namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_TipoEquipo TipoEquipoSeleccionado=new View_TipoEquipo();
        
        private void gridTipoEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridTipoEquipo.SelectedRows.Count > 0)
                {
                    TipoEquipoSeleccionado = (View_TipoEquipo)((View_TipoEquipo)gridTipoEquipo.SelectedRows[0].DataBoundItem).Clone();

                    MarcaTipoEquipo.Valor = TipoEquipoSeleccionado.Marca;
                    ReferenciaTipoEquipo.Valor = TipoEquipoSeleccionado.Referencia;
                    DescripcionTipoEquipo.Valor = TipoEquipoSeleccionado.Descripcion;
                    ActivoTipoEquipo.Valor = TipoEquipoSeleccionado.Activo;

                    FillRestricciones();

                    infoRegistroTipoEquipo.fechaCreado = TipoEquipoSeleccionado.FechaCreado;
                    infoRegistroTipoEquipo.creadoPor = TipoEquipoSeleccionado.Creado;
                    infoRegistroTipoEquipo.fechaModificado = TipoEquipoSeleccionado.FechaModificado ?? new DateTime(1900, 1, 1);
                    infoRegistroTipoEquipo.modificadoPor = TipoEquipoSeleccionado.Modificado;
                }                
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando tipos de equipo", ex.Message);
            }
        }

        private void BuscarListaTipoEquipo()
        {
            try
            {
                Mensaje.IniciaEspera();
                var list = AdministradorTipoEquipoCliente.getTiposEquipo(FiltroTipoEquipo.Text, null);
                var datos = list.Items.OrderBy(a => a.Marca).ThenByDescending(a => a.Referencia).ThenByDescending(a => a.Descripcion).ToList();

                gridTipoEquipo.DataSource = datos;
                gridTipoEquipo.Refresh();

                for (int i = 0; i < gridTipoEquipo.ColumnCount; i++)
                {
                    gridTipoEquipo.Columns[i].Visible = false;
                }
                gridTipoEquipo.SetVisibleColumns(new string[] { "Descripcion", "Marca", "Referencia", "Activo"});
                gridTipoEquipo_Click(null, null);

                mtDetalleTipoEquipo.SelectedIndex = 0;
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar tipo equipo", ex.Message);
            }
            tbFiltro.Focus();
        }

        private void GuardarTipoEquipo()
        {
            TipoEquipoSeleccionado.Marca = MarcaTipoEquipo.Valor;
            TipoEquipoSeleccionado.Referencia = ReferenciaTipoEquipo.Valor;
            TipoEquipoSeleccionado.Descripcion = DescripcionTipoEquipo.Valor;
            TipoEquipoSeleccionado.Activo = ActivoTipoEquipo.Valor??true;
            var restricciones = mlvRestriccionesTipoEquipo.CheckedItems;
            TipoEquipoSeleccionado.Restricciones = new View_RestriccionTipoEquipo[restricciones.Count];
            for(int i=0;i<restricciones.Count;i++)
            {
                TipoEquipoSeleccionado.Restricciones[i] =
                    new View_RestriccionTipoEquipo
                    {
                        RestriccionId = ((View_RestriccionTipoEquipo)restricciones[i].Tag).RestriccionId,
                        RestriccionTipoEquipoId = ((View_RestriccionTipoEquipo)restricciones[i].Tag).RestriccionTipoEquipoId,
                    };
            }

            if (TipoEquipoSeleccionado != null && TipoEquipoSeleccionado.TipoEquipoId != 0)
            {
                string mensaje = "¿Quiere guardar el tipo de equipo con los siguientes valores?";
                mensaje += "\r\nMarca: " + TipoEquipoSeleccionado.Marca;
                mensaje += "\r\nReferencia: " + TipoEquipoSeleccionado.Referencia;
                mensaje += "\r\nDescripcion: " + TipoEquipoSeleccionado.Descripcion;
                mensaje += "\r\nActivo: " + ((ActivoTipoEquipo.Valor?? true)?"Si":"No");
                if (Mensaje.PreguntaSiNo("Modificar tipo de equipo", mensaje) == DialogResult.Yes)
                {
                    TipoEquipoSeleccionado.ModificadoId = usuario.UsuarioId;
                    AdministradorTipoEquipoCliente.EditTipoEquipo(TipoEquipoSeleccionado);
                }
            }
            else
            {
                TipoEquipoSeleccionado.CreadoId = usuario.UsuarioId;
                AdministradorTipoEquipoCliente.AddTipoEquipo(TipoEquipoSeleccionado);
            }
        }

        private void pbGuardarTipoEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarTipoEquipo();
                FiltroTipoEquipo.Text = TipoEquipoSeleccionado.Descripcion + " " + TipoEquipoSeleccionado.Marca + " " + TipoEquipoSeleccionado.Referencia;
                BuscarListaTipoEquipo();
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardar tipo equipo", ex.Message);
            }
        }

        private void pbNuevaTipoEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                TipoEquipoSeleccionado = new  View_TipoEquipo();
                MarcaTipoEquipo.Valor = "";
                ReferenciaTipoEquipo.Valor = "";
                DescripcionTipoEquipo.Valor = "";
                ActivoTipoEquipo.Valor = true;

                var restriccionesDisponibles = 
                    AdministradorRestriccionCliente.getRestricciones("", true)
                    .Items.Select(i=>new View_RestriccionTipoEquipo {
                        Activa=false,
                        Descripcion = i.Descripcion,
                        RestriccionId=i.RestriccionId
                    }).ToArray();
                TipoEquipoSeleccionado.Restricciones = restriccionesDisponibles;
                FillRestricciones();
                infoRegistroTipoEquipo.creadoPor = "";
                infoRegistroTipoEquipo.modificadoPor = "";
                infoRegistroTipoEquipo.fechaCreado = new DateTime(1900, 1, 1);
                infoRegistroTipoEquipo.fechaModificado = new DateTime(1900, 1, 1);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando tipo de equipo", ex.Message);
            }
        }

        private void pbTipoEquipoBuscar_Click(object sender, EventArgs e)
        {
            BuscarListaTipoEquipo();
        }

        private void tbFiltroTipoEquipo_Enter(object sender, EventArgs e)
        {
            BuscarListaTipoEquipo();
        }

        private void tbFiltroTipoEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarListaTipoEquipo();
                e.Handled = true;
            }
        }

        private void FillRestricciones()
        {
            mlvRestriccionesTipoEquipo.Items.Clear();
            foreach (var r in TipoEquipoSeleccionado.Restricciones)
            {
                mlvRestriccionesTipoEquipo.Items.Add(new ListViewItem
                {
                    Checked = r.Activa ?? false,
                    Text = r.Descripcion,
                    Tag = r
                });
            }
        }
    }
}
