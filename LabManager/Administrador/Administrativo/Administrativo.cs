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
using LabManagerCliente.AdministradorAdministrativoService;
namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Administrativo AdministrativoSeleccionado=new View_Administrativo();

        private void fillInfoAdministrativo(View_Administrativo Administrativo)
        {
            AdministrativoSeleccionado = (View_Administrativo)Administrativo.Clone();

            NombreAdministrativo.Valor = Administrativo.Nombres;
            ApellidoAdministrativo.Valor = Administrativo.Apellidos;
            DocumentoAdministrativo.Valor = Administrativo.Documento;
            CodigoBarrasAdministrativo.Valor = Administrativo.Barcode;
            ContraseniaAdministrativo.Valor = "";
            ConfirmaContraseniaAdministrativo.Valor = "";
            ActivoAdministrativo.Valor = Administrativo.Activo;
            CorreoElectronicoAdministrativo.Valor = Administrativo.CorreoElectronico;

            infoRegistroAdministrativo.creadoPor = Administrativo.Creado;
            infoRegistroAdministrativo.modificadoPor = Administrativo.Modificado;

            infoRegistroAdministrativo.fechaCreado = Administrativo.FechaCreacion;
            infoRegistroAdministrativo.fechaModificado = Administrativo.FechaModificacion ?? new DateTime(1900, 1, 1);
        }

        private void GuardarAdministrativo()
        {
            var SelectTmp = (View_Administrativo)AdministrativoSeleccionado.Clone();
            if (ConfirmaContraseniaAdministrativo.Valor != ContraseniaAdministrativo.Valor)
            {
                throw new Exception("La contraseña y la confirmación son diferentes");
            }
            SelectTmp.Nombres = NombreAdministrativo.Valor;
            SelectTmp.Apellidos = ApellidoAdministrativo.Valor;
            SelectTmp.Documento = DocumentoAdministrativo.Valor;
            SelectTmp.Barcode = CodigoBarrasAdministrativo.Valor;
            SelectTmp.Password = ContraseniaAdministrativo.Valor;
            SelectTmp.Activo = ActivoAdministrativo.Valor ?? false;
            SelectTmp.CorreoElectronico = CorreoElectronicoAdministrativo.Valor;
            SelectTmp.UsuarioCreaId = usuario.UsuarioId;
            SelectTmp.UsuarioModificaId = usuario.UsuarioId;
            if (SelectTmp.UsuarioId == 0)
            {
                AdministradorAdministrativoCliente.AddAdministrativo(SelectTmp);
            }
            else {
                AdministradorAdministrativoCliente.EditAdministrativo(SelectTmp);
            }
            AdministrativoSeleccionado = SelectTmp;
        }

        private void gridAdministrativo_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridAdministrativo.SelectedRows.Count > 0)
                {
                    fillInfoAdministrativo((View_Administrativo)gridAdministrativo.SelectedRows[0].DataBoundItem);
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando Administrativoes", ex.Message);
            }
        }

        private void BuscarListaAdministrativo()
        {
            try
            {
                Mensaje.IniciaEspera();
                var list = AdministradorAdministrativoCliente.getAdministrativos(FiltroAdministrativo.Text, null);
                var datos = list.Items;

                gridAdministrativo.DataSource = datos;
                gridAdministrativo.Refresh();

                string[] visibleColumns = new string[] {
                    "Nombres",
                    "Apellidos",
                    "Documento",
                    "Barcode",
                    "Activo"
                };

                gridAdministrativo.SetVisibleColumns(visibleColumns);

                gridAdministrativo_Click(null, null);
                mtAdministrativo.SelectedIndex = 0;
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar Administrativo", ex.Message);
            }
            tbFiltro.Focus();
        }

        private void pbGuardaAdministrativo_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarAdministrativo();
                FiltroAdministrativo.Text = AdministrativoSeleccionado.Documento;
                pbBuscaAdministrativo_Click(sender, e);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardando", ex.Message);
            }
        }

        private void pbNuevoAdministrativo_Click(object sender, EventArgs e)
        {
            try
            {
                AdministrativoSeleccionado = new View_Administrativo();
                AdministrativoSeleccionado.FechaCreacion = DateTime.Now;
                fillInfoAdministrativo(AdministrativoSeleccionado);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando", ex.Message);
            }
        }

        private void pbBuscaAdministrativo_Click(object sender, EventArgs e)
        {
            BuscarListaAdministrativo();
        }

        private void tbFiltroAdministrativo_Enter(object sender, EventArgs e)
        {
            BuscarListaAdministrativo();
        }

        private void FiltroAdministrativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarListaAdministrativo();
                e.Handled = true;
            }
        }
    }
}