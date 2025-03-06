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
        private View_Estudiante EstudianteSeleccionado=new View_Estudiante();

        private void fillInfoEstudiante(View_Estudiante estudiante)
        {
            EstudianteSeleccionado = estudiante;
            var listaFacultades = AdministradorEstudianteCliente.getFacultad("", null);
            Facultad.mControl.ValueMember = "FacultadId";
            Facultad.mControl.DisplayMember = "Nombre";
            Facultad.mControl.DataSource = listaFacultades.Items;

            Nombre.Valor = estudiante.Nombres;
            Apellidos.Valor = estudiante.Apellidos;
            Documento.Valor = estudiante.Documento;
            Codigo.Valor = estudiante.Codigo;
            BarCode.Valor = estudiante.Barcode;

            SemestreBasico.Value = estudiante.SemestreBasico;

            infoRegistroEstudiante.creadoPor = estudiante.Creado;
            infoRegistroEstudiante.modificadoPor = estudiante.Modificado;

            infoRegistroEstudiante.fechaCreado = estudiante.FechaCreacion;
            infoRegistroEstudiante.fechaModificado = estudiante.FechaModificacion ?? new DateTime(1900, 1, 1);

            Activo.Valor = estudiante.Activo;
           
            Facultad.mControl.SelectedValue = estudiante.FacultadId??-1;
            HabilitarTabs(true);

        }

        private void Guardar() {
            var estSelectTmp = (View_Estudiante) EstudianteSeleccionado.Clone();
            estSelectTmp.Nombres=Nombre.Valor;
            estSelectTmp.Apellidos = Apellidos.Valor;
            estSelectTmp.Documento = Documento.Valor;
            estSelectTmp.Codigo = Codigo.Valor;
            estSelectTmp.FacultadId = (int?)Facultad.mControl.SelectedValue;
            estSelectTmp.SemestreBasico = SemestreBasico.ValorEntero;
            estSelectTmp.Barcode = BarCode.Valor;
            estSelectTmp.Activo = Activo.Valor ?? false;
            estSelectTmp.UsuarioCreaId = usuario.UsuarioId;
            estSelectTmp.UsuarioModificaId = usuario.UsuarioId;
            if (estSelectTmp.UsuarioId==0)
            {
                AdministradorEstudianteCliente.AddEstudiante(estSelectTmp);
            }
            else {
                AdministradorEstudianteCliente.EditEstudiante(estSelectTmp);
            }
            EstudianteSeleccionado = estSelectTmp;
        }

        private void gridEstudiantes_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridEstudiantes.SelectedRows.Count > 0)
                {
                    fillInfoEstudiante((View_Estudiante)gridEstudiantes.SelectedRows[0].DataBoundItem);
                    fillMultas();
                    fillAnotaciones();
                    fillHistorial();
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando estudiates", ex.Message);
            }
        }

        private void BuscarListaEstudiante()
        {
            try
            {
                Mensaje.IniciaEspera();
                var list = AdministradorEstudianteCliente.getEstudiantes(tbFiltro.Text, null);
                var datos = list.Items;


                gridEstudiantes.DataSource = datos;
                gridEstudiantes.Refresh();

                gridEstudiantes.Columns["Token"].Visible = false;
                gridEstudiantes.Columns["Mensaje"].Visible = false;
                gridEstudiantes.Columns["Error"].Visible = false;
                gridEstudiantes.Columns["UsuarioId"].Visible = false;
                gridEstudiantes.Columns["FacultadId"].Visible = false;

                gridEstudiantes.Columns["Creado"].Visible = false;
                gridEstudiantes.Columns["Modificado"].Visible = false;
                gridEstudiantes.Columns["FechaCreacion"].Visible = false;
                gridEstudiantes.Columns["FechaModificacion"].Visible = false;
                gridEstudiantes.Columns["SemestreBasico"].Visible = false;
                gridEstudiantes.Columns["UsuarioModificaId"].Visible = false;
                gridEstudiantes.Columns["UsuarioCreaId"].Visible = false;

                string[] columnas = {
                    "Documento", 
                     "Codigo",
                     "Nombres",
                     "Apellidos",
                     "FacultadNombre",
                     "Barcode",
                     "Activo"
                };
                
                gridEstudiantes.SetVisibleColumns(columnas);

                gridEstudiantes_Click(null, null);
                mtDetalleEstudiante.SelectedIndex = 0;
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar estudiante", ex.Message);
            }
            tbFiltro.Focus();
        }

        private void pbInfoSave_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
                tbFiltro.Text = EstudianteSeleccionado.Documento;
                pbEstudianteBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardando", ex.Message);
            }
        }

        private void pbInfoNew_Click(object sender, EventArgs e)
        {
            try
            {
                EstudianteSeleccionado = new View_Estudiante();
                EstudianteSeleccionado.FechaCreacion = DateTime.Now;
                fillInfoEstudiante(EstudianteSeleccionado);
                HabilitarTabs(false);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando", ex.Message);
            }
        }
        private void HabilitarTabs(bool habilitar)
        {
            if (habilitar)
            {
                mtDetalleEstudiante.EnableTab(pageMultas);
                mtDetalleEstudiante.EnableTab(pageHistorial);
                mtDetalleEstudiante.EnableTab(pageAnotaciones);
            }
            else {
                mtDetalleEstudiante.DisableTab(pageMultas);
                mtDetalleEstudiante.DisableTab(pageHistorial);
                mtDetalleEstudiante.DisableTab(pageAnotaciones);
            }
        }
        private void pbEstudianteBuscar_Click(object sender, EventArgs e)
        {
            BuscarListaEstudiante();
        }
        private void tbFiltro_Enter(object sender, EventArgs e)
        {
            BuscarListaEstudiante();
        }
        private void tbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarListaEstudiante();
                e.Handled = true;
            }
        }
    }
}
        