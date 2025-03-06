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
using LabManagerCliente.AdministradorFacultadService;
namespace LabManager.Administrador
{
    public partial class AdministradorForm
    {
        private View_Facultad FacultadSeleccionada=new View_Facultad();
        
        private void gridFacultad_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridFacultad.SelectedRows.Count > 0)
                {
                    FacultadSeleccionada = (View_Facultad)((View_Facultad)gridFacultad.SelectedRows[0].DataBoundItem).Clone();

                    NombreFacultad.Valor = FacultadSeleccionada.Nombre;
                    CodigoFacultad.ValorEntero = FacultadSeleccionada.Codigo;
                    ActivoFacultad.Valor = FacultadSeleccionada.Activo;
                    SedeFacultad.mControl.SelectedValue =FacultadSeleccionada.SedeId??-1;

                    infoRegistroFacultad.fechaCreado = FacultadSeleccionada.FechaCreacion;
                    infoRegistroFacultad.creadoPor = FacultadSeleccionada.UsuarioCrea;
                    infoRegistroFacultad.fechaModificado = FacultadSeleccionada.FechaModificacion ?? new DateTime(1900, 1, 1);
                    infoRegistroFacultad.modificadoPor = FacultadSeleccionada.UsuarioMoifica;
                }                
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando facultades", ex.Message);
            }
        }

        private void BuscarListaFacultad()
        {
            try
            {
                Mensaje.IniciaEspera();
                var SedesList = AdministradorSedeCliente.getSede("", null);
                var list = AdministradorFacultadCliente.getFacultad(FiltroFacultad.Text, null);
                var datos = list.Items.OrderBy(f => f.Nombre).ToList();


                gridFacultad.DataSource = datos;
                gridFacultad.Refresh();

                gridFacultad.SetVisibleColumns(new string [] { "Codigo","Nombre","NombreSede","Activo"});
                gridFacultad_Click(null, null);

                mtDetalleFacultad.SelectedIndex = 0;

                SedeFacultad.mControl.ValueMember = "SedeId";
                SedeFacultad.mControl.DisplayMember = "Nombre";
                SedeFacultad.mControl.DataSource = SedesList.Items.Where(A=>A.Activo).ToList();
                //AdministradorForm.MousePosition   Posible solucion para cerrar la app 
                Mensaje.TerminaEspera();
            }
            catch (Exception ex)
            {
                Mensaje.TerminaEspera();
                Mensaje.Error("Buscar facultad", ex.Message);
            }
            tbFiltro.Focus();
        }

        private void GuardarFacultad()
        {
            FacultadSeleccionada.Nombre = NombreFacultad.Valor;
            FacultadSeleccionada.Codigo = CodigoFacultad.ValorEntero??-1;
            FacultadSeleccionada.Activo = ActivoFacultad.Valor??true;
            FacultadSeleccionada.SedeId = (int?)SedeFacultad.mControl.SelectedValue;

            if (FacultadSeleccionada != null && FacultadSeleccionada.FacultadId != -1)
            {
                string mensaje = "¿Quiere guardar la facultad con los siguientes valores?";
                mensaje += "\r\nCodigo: " + FacultadSeleccionada.Codigo;
                mensaje += "\r\nNombre: " + FacultadSeleccionada.Nombre;
                mensaje += "\r\nActivo: " + ((ActivoFacultad.Valor?? true)?"Si":"No");
                if (Mensaje.PreguntaSiNo("Modificar facultad", mensaje) == DialogResult.Yes)
                {
                    FacultadSeleccionada.UsuarioModificaId = usuario.UsuarioId;
                    AdministradorFacultadCliente.EditFacultad(FacultadSeleccionada);
                }
            }
            else
            {
                FacultadSeleccionada.UsuarioCreaId = usuario.UsuarioId;
                AdministradorFacultadCliente.AddFacultad(FacultadSeleccionada);
            }
        }

        private void pbGuardarFacultad_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarFacultad();
                FiltroFacultad.Text = FacultadSeleccionada.Codigo.ToString();
                BuscarListaFacultad();
            }
            catch (Exception ex)
            {
                Mensaje.Error("Guardar facultad", ex.Message);
            }
        }

        private void pbNuevaFacultad_Click(object sender, EventArgs e)
        {
            try
            {
                FacultadSeleccionada = new  View_Facultad();
                NombreFacultad.Valor = "";
                CodigoFacultad.Valor = "";
                ActivoFacultad.Valor = true;
                infoRegistroFacultad.creadoPor = "";
                infoRegistroFacultad.modificadoPor = "";
                infoRegistroFacultad.fechaCreado = new DateTime(1900, 1, 1);
                infoRegistroFacultad.fechaModificado = new DateTime(1900, 1, 1);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Creando facultad", ex.Message);
            }
        }

        private void pbFacultadBuscar_Click(object sender, EventArgs e)
        {
            BuscarListaFacultad();
        }

        private void tbFiltroFacultad_Enter(object sender, EventArgs e)
        {
            BuscarListaFacultad();
        }

        private void tbFiltroFacultad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarListaFacultad();
                e.Handled = true;
            }
        }

        private void SedeFacultad_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
