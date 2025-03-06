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
using LabManagerCliente.SeguridadService;
using LabManagerCliente.AdministradorEstudianteService;
using LabManagerCliente.AdministradorTipoEquipoService;
using LabManagerCliente.AdministradorAuxiliarService;

namespace LabManager.Administrador
{
    public partial class AdministradorForm : MetroFramework.Forms.MetroForm
    {
        public View_UsuarioAutentica usuario { get; set; }

        public AdministradorForm()
        {
            InitializeComponent();
        }

        private void AplicarEstilos() {
            foreach (var control in Controls)
            {
                if (control.GetType() == typeof(MetroFramework.Controls.MetroGrid))
                {
                    ((MetroFramework.Controls.MetroGrid)control)
                        .ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void AdministradorForm_Load(object sender, EventArgs e)
        {
            try
            {
                historialFechaDesde.mControl.ValueChanged += HistorialFechaDesde_ValueChanged;
                historialFechaHasta.mControl.ValueChanged += HistorialFechaHasta_ValueChanged;

                FechaDesdeHistorialDocente.mControl.ValueChanged += HistorialFechaDesdeDocente_ValueChanged;
                FechaHastaHistorialDocente.mControl.ValueChanged += HistorialFechaHastaDocente_ValueChanged;

                HistorialFechaDesdeEquipo.mControl.ValueChanged += HistorialFechaDesdeEquipo_ValueChanged;
                HistorialFechaHastaEquipo.mControl.ValueChanged += HistorialFechaHastaEquipo_ValueChanged;
                var login = new Seguridad.Login();
                if (usuario == null)
                {
                    login.ShowDialog();
                    usuario = login.Usuario;
                }
                Text = "Administrador - " + usuario.Nombres + " " + usuario.Apellidos;
                Refresh();
                EstudianteSeleccionado = new View_Estudiante();
                EstudianteSeleccionado.FechaCreacion = DateTime.Now;
                fillInfoEstudiante(EstudianteSeleccionado);
                HabilitarTabs(false);

                pbInfoNew_Click(null, null);
                pbInfoNewDocente_Click(null, null);
                pbNuevoEquipo_Click(null, null);
                pbInfoNewAuxiliar_Click(null, null);
                pbNuevoAdministrativo_Click(null, null);
                pbNuevaTipoEquipo_Click(null, null);
                pbNuevaFacultad_Click(null, null);
                pbNuevaRestriccion_Click(null, null);

                FechaDesdeHistorialDocente.Valor = DateTime.Now;
                FechaHastaHistorialDocente.Valor = DateTime.Now;

                historialFechaDesde.Valor = DateTime.Now;
                historialFechaHasta.Valor = DateTime.Now;

                HistorialFechaDesdeEquipo.Valor = DateTime.Now;
                HistorialFechaHastaEquipo.Valor = DateTime.Now;
            }
            catch (Exception ex)
            {
                Mensaje.Error("Cargando", ex.Message);
                this.Close();
            }
        }

        private void CargarFacultades(ref General.InputFielComboBox facultadControl)
        {
            var listaFacultades = AdministradorDocenteCliente.getFacultad("", null);
            facultadControl.mControl.ValueMember = "FacultadId";
            facultadControl.mControl.DisplayMember = "Nombre";
            facultadControl.mControl.DataSource = listaFacultades.Items;
        }

        private void CargarTipoEquipo(ref General.InputFielComboBox tipoEquipoControl)
        {
            var listaTipoEquipos = AdministradorTipoEquipoCliente.getTipoEquiposActivos();
            tipoEquipoControl.mControl.ValueMember = "TipoEquipoId";
            tipoEquipoControl.mControl.DisplayMember = "TextoCorto";
            tipoEquipoControl.mControl.DataSource = listaTipoEquipos.Items;
        }

        private void CargarResponsables(ref General.InputFielComboBox responsableControl)
        {
            var listaAuxiliares = AdministradorAuxiliarCliente.getAuxiliaresActivos();
            responsableControl.mControl.ValueMember = "UsuarioId";
            responsableControl.mControl.DisplayMember = "TextoCorto";
            responsableControl.mControl.DataSource = listaAuxiliares.Items;
        }

        private void CargarEstadoMulta(ref General.InputFielComboBox estadoMultaControl)
        {
            var listado = AdministradorMultaCliente.getEstadosMulta();
            estadoMultaControl.mControl.ValueMember = "EstadoMultaId";
            estadoMultaControl.mControl.DisplayMember = "Descripcion";
            estadoMultaControl.mControl.DataSource = listado.Items;
        }

        private void CargarEstadoAnotacion(ref General.InputFielComboBox estadoAnotacionControl)
        {
            var listado = AdministradorAnotacionCliente.getEstadosAnotacion();
            estadoAnotacionControl.mControl.ValueMember = "EstadoAnotacionId";
            estadoAnotacionControl.mControl.DisplayMember = "Descripcion";
            estadoAnotacionControl.mControl.DataSource = listado.Items;
        }

        private void AdministradorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //usuario = null;
            //AdministradorForm_Load(null,null);
        }

    }
}
