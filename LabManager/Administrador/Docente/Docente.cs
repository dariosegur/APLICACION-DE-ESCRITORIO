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
        private View_Docente DocenteSeleccionado=new View_Docente();

        private void fillInfoDocente(View_Docente Docente)
        {
            DocenteSeleccionado = Docente;

            CargarFacultades(ref FacultadDocente);
        
            NombreDocente.Valor = Docente.Nombres;
            ApellidoDocente.Valor = Docente.Apellidos;
            DocumentoDocente.Valor = Docente.Documento;
            CodigoBarrasDocente.Valor = Docente.Barcode;

            infoRegistroDocente.creadoPor = Docente.Creado;
            infoRegistroDocente.modificadoPor = Docente.Modificado;

            infoRegistroDocente.fechaCreado = Docente.FechaCreacion;
            infoRegistroDocente.fechaModificado = Docente.FechaModificacion ?? new DateTime(1900, 1, 1);

            ActivoDocente.Valor = Docente.Activo;

            FacultadDocente.mControl.SelectedValue = Docente.FacultadId ?? -1;
            HabilitarTabsDocente(true);

        }

        private void GuardarDocente()
        {
            var docSelectTmp = (View_Docente)DocenteSeleccionado.Clone();
            docSelectTmp.Nombres = NombreDocente.Valor;
            docSelectTmp.Apellidos = ApellidoDocente.Valor;
            docSelectTmp.Documento = DocumentoDocente.Valor;
            docSelectTmp.FacultadId = (int?)FacultadDocente.mControl.SelectedValue;
            docSelectTmp.Barcode = CodigoBarrasDocente.Valor;
            docSelectTmp.Activo = ActivoDocente.Valor ?? false;
            docSelectTmp.UsuarioCreaId = usuario.UsuarioId;
            docSelectTmp.UsuarioModificaId = usuario.UsuarioId;
            if (docSelectTmp.UsuarioId == 0)
            {
                AdministradorDocenteCliente.AddDocente(docSelectTmp);
            }
            else {
                AdministradorDocenteCliente.EditDocente(docSelectTmp);
            }
            DocenteSeleccionado = docSelectTmp;
        }

        private void gridDocentes_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridDocentes.SelectedRows.Count > 0)
                {
                    fillInfoDocente((View_Docente)gridDocentes.SelectedRows[0].DataBoundItem);
                    fillMultasDocente();
                    fillAnotacionesDocente();
                    fillHistorialDocente();
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando docentes", ex.Message);
            }
        }

        private void BuscarListaDocente()
        {
            try
            {
                Mensaje.IniciaEspera();
                var list = AdministradorDocenteCliente.getDocentes(FiltroDocente.Text, null);
                var datos = list.Items;


                gridDocentes.DataSource = datos;
                gridDocentes.Refresh();

               
                string[] columnas = {
                    "Documento",
                    "Nombres",
                    "Apellidos",
                    "FacultadNombre",
                    "Barcode",
                    "Activo"
                };
                gridDocentes.SetVisibleColumns(columnas);
                gridDocentes_Click(null, null);
                mtDetalleDocente.SelectedIndex = 0;
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar Docente", ex.Message);
            }
            tbFiltro.Focus();
        }

        private void pbInfoSaveDocente_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarDocente();
                FiltroDocente.Text = DocenteSeleccionado.Documento;
                pbDocenteBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardando", ex.Message);
            }
        }

        private void pbInfoNewDocente_Click(object sender, EventArgs e)
        {
            try
            {
                DocenteSeleccionado = new View_Docente();
                DocenteSeleccionado.FechaCreacion = DateTime.Now;
                fillInfoDocente(DocenteSeleccionado);
                HabilitarTabs(false);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando", ex.Message);
            }
        }

        private void HabilitarTabsDocente(bool habilitar)
        {
            if (habilitar)
            {
                mtDetalleDocente.EnableTab(pageMultas);
                mtDetalleDocente.EnableTab(pageHistorial);
                mtDetalleDocente.EnableTab(pageAnotaciones);
            }
            else {
                mtDetalleDocente.DisableTab(pageMultas);
                mtDetalleDocente.DisableTab(pageHistorial);
                mtDetalleDocente.DisableTab(pageAnotaciones);
            }
        }

        private void pbDocenteBuscar_Click(object sender, EventArgs e)
        {
            BuscarListaDocente();
        }

        private void tbFiltroDocente_Enter(object sender, EventArgs e)
        {
            BuscarListaDocente();
        }

        private void tbFiltroDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarListaDocente();
                e.Handled = true;
            }
        }
    }
}