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
using LabManagerCliente.AdministradorAuxiliarService;
namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Auxiliar AuxiliarSeleccionado=new View_Auxiliar();

        private void fillInfoAuxiliar(View_Auxiliar Auxiliar)
        {
            AuxiliarSeleccionado = (View_Auxiliar)Auxiliar.Clone();

            NombreAuxiliar.Valor = Auxiliar.Nombres;
            ApellidoAuxiliar.Valor = Auxiliar.Apellidos;
            DocumentoAuxiliar.Valor = Auxiliar.Documento;
            CodigoBarraAuxiliar.Valor = Auxiliar.Barcode;
            ContraseniaAuxiliar.Valor = "";
            ConfirmaContraseniaAuxiliar.Valor = "";
            ActivoAuxiliar.Valor = Auxiliar.Activo;
            CorreoElectronicoAuxiliar.Valor = Auxiliar.CorreoElectronico;

            infoRegistroAuxiliar.creadoPor = Auxiliar.Creado;
            infoRegistroAuxiliar.modificadoPor = Auxiliar.Modificado;

            infoRegistroAuxiliar.fechaCreado = Auxiliar.FechaCreacion;
            infoRegistroAuxiliar.fechaModificado = Auxiliar.FechaModificacion ?? new DateTime(1900, 1, 1);
        }

        private void GuardarAuxiliar()
        {
            var SelectTmp = (View_Auxiliar)AuxiliarSeleccionado.Clone();
            if (ConfirmaContraseniaAuxiliar.Valor != ContraseniaAuxiliar.Valor)
            {
                throw new Exception("La contraseña y la confirmación son diferentes");
            }
            SelectTmp.Nombres = NombreAuxiliar.Valor;
            SelectTmp.Apellidos = ApellidoAuxiliar.Valor;
            SelectTmp.Documento = DocumentoAuxiliar.Valor;
            SelectTmp.Barcode = CodigoBarraAuxiliar.Valor;
            SelectTmp.Password = ContraseniaAuxiliar.Valor;
            SelectTmp.Activo = ActivoAuxiliar.Valor ?? false;
            SelectTmp.UsuarioCreaId = usuario.UsuarioId;
            SelectTmp.UsuarioModificaId = usuario.UsuarioId;
            SelectTmp.CorreoElectronico = CorreoElectronicoAuxiliar.Valor;
            if (SelectTmp.UsuarioId == 0)
            {
                AdministradorAuxiliarCliente.AddAuxiliar(SelectTmp);
            }
            else {
                AdministradorAuxiliarCliente.EditAuxiliar(SelectTmp);
            }
            AuxiliarSeleccionado = SelectTmp;
        }

        private void gridAuxiliares_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridAuxiliares.SelectedRows.Count > 0)
                {
                    fillInfoAuxiliar((View_Auxiliar)gridAuxiliares.SelectedRows[0].DataBoundItem);
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando Auxiliares", ex.Message);
            }
        }

        private void BuscarListaAuxiliar()
        {
            try
            {
                Mensaje.IniciaEspera();
                var list = AdministradorAuxiliarCliente.getAuxiliares(FiltroAuxiliar.Text, null);
                var datos = list.Items;

                gridAuxiliares.DataSource = datos;
                gridAuxiliares.Refresh();

                string[] visibleColumns = new string[] {
                    "Nombres",
                    "Apellidos",
                    "Documento",
                    "Barcode",
                    "Activo"
                };

                gridAuxiliares.SetVisibleColumns(visibleColumns);

                gridAuxiliares_Click(null, null);
                mtAuxiliar.SelectedIndex = 0;
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar Auxiliar", ex.Message);
            }
            tbFiltro.Focus();
        }

        private void pbInfoSaveAuxiliar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarAuxiliar();
                FiltroAuxiliar.Text = AuxiliarSeleccionado.Documento;
                pbAuxiliarBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardando", ex.Message);
            }
        }

        private void pbInfoNewAuxiliar_Click(object sender, EventArgs e)
        {
            try
            {
                AuxiliarSeleccionado = new View_Auxiliar();
                AuxiliarSeleccionado.FechaCreacion = DateTime.Now;
                fillInfoAuxiliar(AuxiliarSeleccionado);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando", ex.Message);
            }
        }

        private void pbAuxiliarBuscar_Click(object sender, EventArgs e)
        {
            BuscarListaAuxiliar();
        }

        private void tbFiltroAuxiliar_Enter(object sender, EventArgs e)
        {
            BuscarListaAuxiliar();
        }

        private void tbFiltroAuxiliar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarListaAuxiliar();
                e.Handled = true;
            }
        }
    }
}