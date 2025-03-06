using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using LabManagerCliente.PrestamoRecepcionService;
using LabManagerCliente;
using LabManagerCliente.SeguridadService;
using LabManager.BarcodeScaner;
using System.Configuration;

namespace LabManager
{
    public partial class Vprincipal : MetroFramework.Forms.MetroForm
    {
        private SerialBarcodeScaner LectorSerial = new SerialBarcodeScaner();
        private KeyBoardBarcodeScanner LectorTecladonId;
        private KeyBoardBarcodeScanner LectorTecladoEquipo;
        private View_PrestamoRecepcion usuario;
        private View_UsuarioAutentica auxiliar;
        private View_UsuarioAutentica Auxiliar {
            get {
                return auxiliar;
            }
            set {
                lAuxilliar.Text = value.Nombres + " " + value.Apellidos;
                auxiliar = value;
            }
        }
        private System.Windows.Forms.Timer tClear;
        private System.Windows.Forms.Timer tLogOut;

        private enum EstadoFoco
        {
            Libre,
            CodUsuario,
            CodEquipo
        }

        EstadoFoco FocoDeseado;
        bool timersReset = false;
        bool setActive = true;
        System.Windows.Forms.Timer timerCheck = new System.Windows.Forms.Timer();
              
        private void TimerCheck_Tick(object sender, EventArgs e)
        {
            switch (FocoDeseado)
            {
                case EstadoFoco.CodEquipo:
                    Tb_Codigo_equipo.Focus();
                    Tb_Codigo_equipo.SelectAll();
                    break; 
                case EstadoFoco.CodUsuario:
                    Tb_Codigo_usuario.Focus();
                    Tb_Codigo_usuario.SelectAll();
                    break;
            }
            FocoDeseado = EstadoFoco.Libre;

            //if (setActive) Activate();

            if (
                Tb_Codigo_usuario.Focused == false &&
                Tb_Codigo_equipo.Focused == false
                )
            {
                lastControlFocused.Focus();
            }
            if (timersReset)
            {
                tClear.Stop();
                tClear.Start();
                tLogOut.Stop();
                tLogOut.Start();
                timersReset = false;
            }
        }

        public Vprincipal(View_UsuarioAutentica usuario)
        {
            InitializeComponent();
            Auxiliar = usuario;
        }

        private void TLogOut_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TClear_Tick(object sender, EventArgs e)
        {
            FocoDeseado = EstadoFoco.CodUsuario;
            ClearPantalla();
        }

        private void Vprincipal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            timerCheck.Enabled = true;
            timerCheck.Interval = 500;
            timerCheck.Tick += TimerCheck_Tick;
            timerCheck.Start();
            try
            {
                LectorTecladonId = new KeyBoardBarcodeScanner(Tb_Codigo_usuario);
                LectorTecladoEquipo = new KeyBoardBarcodeScanner(Tb_Codigo_equipo);

                LectorTecladonId.OnCodigoBarras += LectorTecladoOnCodigoBarras;
                LectorTecladoEquipo.OnCodigoBarras += LectorTecladoOnCodigoBarras;

                string direccion = Application.StartupPath + @"\PosicionApp.txt";
                if (!File.Exists(direccion))
                {
                    File.WriteAllLines(direccion, new string[] { "447", "424" });
                }
                var texto = new StreamReader(direccion);
                SpCn_Usuario.SplitterDistance = Convert.ToInt32(texto.ReadLine());
                SpCn_EquiposInformacion.SplitterDistance = Convert.ToInt32(texto.ReadLine());
                texto.Close();

                var timeClear = ConfigurationManager.AppSettings["TiempoClear"];                    
                
                var ColorControls = ConfigurationManager.AppSettings["ColorControls"];

                tClear = new System.Windows.Forms.Timer();
                tClear.Interval = int.Parse(timeClear??"60000");
                tClear.Tick += TClear_Tick;
                tClear.Enabled = true;

                tLogOut = new System.Windows.Forms.Timer();
                tLogOut.Interval = getTimeOut(); 
                tLogOut.Tick += TLogOut_Tick;
                tLogOut.Enabled = true;

                SearchControls(Gb_Usuario, Pn_AnotacionesMultas, Pn_informacion, ColorControls.ToString());
            }
            catch (Exception ex)
            {
                Mensaje.Error("Vprincipal_Load", ex.Message + "\n Bienvenido al sistema de préstamo y recepción 2.0");
            }
            try
            {
                LectorSerial.PuertoOpen();
                LectorSerial.OnCodigoBarras += LectorSerial_OnCodigoBarras; ;
            }
            catch
            {
                Mensaje.Error("Error", "Error al abrir puerto serial");
            }
        }
        private int getTimeOut()
        {
            try
            {
                return (int)(PrestamoRecepcionCliente.getTimeLogOut().Valor*60*1000);
            }
            catch {
                try
                {
                    return int.Parse(ConfigurationManager.AppSettings["TiempoLogOut"]);
                }
                catch {
                    return 120000;
                }
            }
        }
        private void LectorTecladoOnCodigoBarras(CodigoBarras Codigo)
        {
            OnCodigoBarras(Codigo, false);
        }

        private void LectorSerial_OnCodigoBarras(CodigoBarras Codigo)
        {
            OnCodigoBarras(Codigo,false);
        }

        private void Btn_Ok_Cod_Equipo_Click(object sender, EventArgs e)
        {
            try
            {
                var Codigo = new CodigoBarras(".3"+Tb_Codigo_equipo.Text+"$");
                OnCodigoBarras(Codigo, true);
            }
            catch (Exception ex)
            {
                Mensaje.Error("Error", ex.Message);
            }
        }

        private void Btn_Ok_Cod_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                var Codigo = new CodigoBarras(Tb_Codigo_usuario.Text);
                OnCodigoBarras(Codigo, true);
            }
            catch
            {
                Mensaje.Error("Error", "Excepción no controlada, asignacion de objeto tipo codigo de barras");
            }
        }

        private void Vprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            LectorSerial.PuertoClose();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            setActive = false;
            var info = new AcercaDe();
            info.ShowDialog();
            setActive = true;
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            try
            {
                setActive = false;
                FocoDeseado = EstadoFoco.CodUsuario;
                tLogOut.Stop();
                var admin = new Administrador.AdministradorForm();
                admin.usuario = Auxiliar;
                admin.ShowDialog();
                tLogOut.Start();
            }
            catch (Exception ex)
            {
                Mensaje.Error("btnAdministrar_Click", ex.Message);
            }
            setActive = true;
        }

        private void Btn_Visor_equipos_Click(object sender, EventArgs e)
        {
            try
            {
                setActive = false;
                FocoDeseado = EstadoFoco.CodUsuario;
                tLogOut.Stop();
                var ve = new VisorDeEquipos();
                ve.ShowDialog();
                tLogOut.Start();
            }
            catch (Exception ex)
            {
                Mensaje.Error("Error", "Btn_Visor_equipos_Click: "+ex.Message);
            }
            setActive = true;
        }

        private Control lastControlFocused;
        private void Tb_Codigo_usuario_Enter(object sender, EventArgs e)
        {
            lastControlFocused = (Control)sender;
        }

        private void Tb_Codigo_equipo_Enter(object sender, EventArgs e)
        {
            lastControlFocused = (Control)sender;
        }

        private void Tb_Codigo_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            AtiendeTeclasFunciones(sender,e);            
        }

        private void Tb_Codigo_equipo_KeyDown(object sender, KeyEventArgs e)
        {
            AtiendeTeclasFunciones(sender,e);
        }

        private void AtiendeTeclasFunciones(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    Btn_Visor_equipos_Click(sender, null);
                    break;
                case Keys.F3:
                    btnAdministrar_Click(sender, null);
                    break;
                case Keys.F12:
                    Btn_Salir_Click(sender, e);
                    break;
            }
        }

        private void Gb_Equipos_Enter(object sender, EventArgs e)
        {

        }
    }
}