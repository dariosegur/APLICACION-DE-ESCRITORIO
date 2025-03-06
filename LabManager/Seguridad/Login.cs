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
using LabManager.BarcodeScaner;
using System.Diagnostics;

namespace LabManager.Seguridad
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private static CacheUsuarios cacheUsuarios = new CacheUsuarios();
        private View_UsuarioAutentica usuario;
        public View_UsuarioAutentica Usuario {
            get {
                return usuario;
            }
        }
        private KeyBoardBarcodeScanner keyboardManagerDocumento;
        private KeyBoardBarcodeScanner keyboardManagerContra;
        private SerialBarcodeScaner serialManager;
        private Timer checkSerialBarCode;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls= false;
            keyboardManagerDocumento = new KeyBoardBarcodeScanner(ifIdentificacion.mControl);
            keyboardManagerContra = new KeyBoardBarcodeScanner(ifContra.mControl);
            serialManager = new SerialBarcodeScaner();
            ifIdentificacion.mControl.KeyPress += IdentificacionKeyPress;
            ifContra.mControl.KeyPress += MControl_KeyPress;            
            keyboardManagerDocumento.OnCodigoBarras += KeyboardManager_OnCodigoBarras;
            keyboardManagerContra.OnCodigoBarras += KeyboardManager_OnCodigoBarras;
            try
            {
                serialManager.PuertoOpen();

                checkSerialBarCode = new Timer();
                checkSerialBarCode.Tick += CheckSerialBarCode_Tick;
                checkSerialBarCode.Interval = 500;
                checkSerialBarCode.Start();
            }
            catch (Exception ex){
                Mensaje.Error("Abriendo el puerto serial",ex.Message);
            }

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            lVersion.Text = "Versión "+version;

        }

        private void CheckSerialBarCode_Tick(object sender, EventArgs e)
        {
            var SerialBarCode = serialManager.ultimoCodigoLeido;
            if (SerialBarCode != null)
            {
                ManageBarCode(SerialBarCode);
            }
        }

        private void KeyboardManager_OnCodigoBarras(CodigoBarras Codigo)
        {
            ManageBarCode(Codigo);
        }

        private void ManageBarCode(CodigoBarras Codigo)
        {
            try
            {
                if (!Codigo.EsEquipo)
                {
                    var lastPassword = cacheUsuarios.getLastPassword(Codigo.Codigo);
                    ifIdentificacion.Valor = Codigo.Codigo;
                    ifContra.Valor = lastPassword;
                    if (lastPassword != null) mbAceptar_Click(null, null);

                    if (DialogResult != DialogResult.OK)
                    {
                        ifContra.Valor = "";
                        ifIdentificacion.Valor = "";
                        ifIdentificacion.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ifContra.Valor = "";
                ifIdentificacion.Valor = "";
                lError.Text = ex.Message;
                DialogResult = DialogResult.Cancel;
            }
        }

        private void IdentificacionKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0xD)
            {
                e.Handled = true;
                ifContra.mControl.Focus();
            }
        }

        private void MControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0xD) {
                e.Handled = true;
                mbAceptar_Click(null, null);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Yes && DialogResult!=DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else {
                serialManager.PuertoClose();
            }
        }

        private void mbAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lError.Text = "";
                usuario = SeguridadCliente.Validar(ifIdentificacion.Valor, ifContra.Valor);
                cacheUsuarios.Add(usuario,ifContra.Valor);
                DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                ifContra.Valor = "";
                ifIdentificacion.Valor = "";
                ifIdentificacion.Focus();
                lError.Text = ex.Message;
                DialogResult = DialogResult.No;
            }
        }

        private void ifIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
