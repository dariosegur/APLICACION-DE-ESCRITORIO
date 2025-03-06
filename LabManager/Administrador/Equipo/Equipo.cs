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
using LabManagerCliente.AdministradorTipoEquipoService;
using LabManagerCliente.AdministradorAuxiliarService;

namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Equipo EquipoSeleccionado = new View_Equipo();

        private void fillInfoEquipo(View_Equipo Equipo)
        {
            EquipoSeleccionado = (View_Equipo)Equipo.Clone();

            CargarTipoEquipo(ref TipoEquipoEquipo);

            CargarResponsables(ref ResponsableEquipo);

            TipoEquipoEquipo.mControl.SelectedValue = Equipo.TipoEquipoId;
            CodigoLaboratorioEquipo.Valor = Equipo.CodigoLaboratorio;
            CodigoInventarioEquipo.Valor = Equipo.CodigoInventario;
            SerialEquipo.Valor = Equipo.Serial;
            ActivoEquipo.Valor = Equipo.Activo;
            ResponsableEquipo.mControl.SelectedValue = Equipo.UsuarioInventarioResponsableId??-1;
            FechaCompraEquipo.Valor = Equipo.FechaCompra??new DateTime(1900,1,1);

            infoRegistroEquipo.creadoPor = Equipo.Creado;
            infoRegistroEquipo.modificadoPor = Equipo.Modificado;

            infoRegistroEquipo.fechaCreado = Equipo.FechaCreado;
            infoRegistroEquipo.fechaModificado = Equipo.FechaModificado ?? new DateTime(1900, 1, 1);

            HabilitarTabsEquipo(true);
        }

        private void GuardarEquipo()
        {
            var SelectTmp = (View_Equipo)EquipoSeleccionado.Clone();
            SelectTmp.TipoEquipoId = (int)(TipoEquipoEquipo.mControl.SelectedValue??-1);
            SelectTmp.CodigoLaboratorio = CodigoLaboratorioEquipo.Valor;
            SelectTmp.CodigoInventario = CodigoInventarioEquipo.Valor;
            SelectTmp.Serial = SerialEquipo.Valor;
            SelectTmp.Activo = ActivoEquipo.Valor ?? false;
            SelectTmp.UsuarioResponsableId = (long?)ResponsableEquipo.mControl.SelectedValue;
            SelectTmp.FechaCompra = FechaCompraEquipo.Valor;

            SelectTmp.CreadoId = usuario.UsuarioId;
            SelectTmp.ModificadoId = usuario.UsuarioId;
            if (SelectTmp.EquipoId == -1)
            {
                AdministradorEquipoCliente.AddEquipo(SelectTmp);
            }
            else {
                AdministradorEquipoCliente.EditEquipo(SelectTmp);
            }
            EquipoSeleccionado = SelectTmp;
        }

        private void gridEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridEquipo.SelectedRows.Count > 0)
                {
                    fillInfoEquipo((View_Equipo)gridEquipo.SelectedRows[0].DataBoundItem);
                    fillHistorialEquipo();
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando Equipos", ex.Message);
            }
        }

        private void BuscarListaEquipo()
        {
            try
            {
                Mensaje.IniciaEspera();
                var list = AdministradorEquipoCliente.getEquipos(FiltroEquipo.Text, null);
                var datos = list.Items;


                gridEquipo.DataSource = datos;
                gridEquipo.Refresh();

                gridEquipo.SetVisibleColumns(new string[] {
                    "TipoEquipo",
                    "Marca",
                    "Referencia",
                    "CodigoLaboratorio",
                    "CodigoInventario",
                    "Serial",
                    "UsuarioInventarioResponsable",
                    "FechaCompra",
                    "Activo"
                });

                gridEquipo_Click(null, null);
                mtEquipo.SelectedIndex = 0;
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar Equipo", ex.Message);
            }
            tbFiltro.Focus();
        }

        private void pbGuardaEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarEquipo();
                FiltroEquipo.Text = EquipoSeleccionado.CodigoLaboratorio;
                pbBuscaEquipo_Click(sender, e);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardando", ex.Message);
            }
        }

        private void pbNuevoEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                EquipoSeleccionado = new View_Equipo();
                EquipoSeleccionado.FechaCreado = DateTime.Now;
                fillInfoEquipo(EquipoSeleccionado);
                HabilitarTabs(false);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando", ex.Message);
            }
        }

        private void HabilitarTabsEquipo(bool habilitar)
        {
            if (habilitar)
            {
                mtEquipo.EnableTab(pageHistorialEquipo);
            }
            else {
                mtEquipo.DisableTab(pageHistorialEquipo);
            }
        }

        private void pbBuscaEquipo_Click(object sender, EventArgs e)
        {
            BuscarListaEquipo();
        }

        private void tbFiltroEquipo_Enter(object sender, EventArgs e)
        {
            BuscarListaEquipo();
        }

        private void FiltroEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarListaEquipo();
                e.Handled = true;
            }
        }
    }
}