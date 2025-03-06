using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Configuration;

namespace LabManager.BarcodeScaner
{
    
    class SerialBarcodeScaner
    {
        public delegate void CodBarras(CodigoBarras Codigo);
        public event CodBarras OnCodigoBarras;
        private string Codigo;
        static private SerialPort Lector;
        static private int contador = 0;
        static private int usarSerial = 0;
        private CodigoBarras ultimocodigoLeido { get; set; }
        /// <summary>
        /// Retorna el último codigo leido. Al leerlo el valor se torna nulo.
        /// </summary>
        public CodigoBarras ultimoCodigoLeido {
            get
            {
                var code = ultimocodigoLeido;
                ultimocodigoLeido = null;
                return code;
            }
        }
        public SerialBarcodeScaner()
        {
            try
            {
                usarSerial = int.Parse(ConfigurationManager.AppSettings["UseSerialPort"]);
                Lector = new SerialPort();
                if (usarSerial != 0)
                {
                    Lector.BaudRate = int.Parse(ConfigurationManager.AppSettings["SerialPortBaudRate"]);
                    Lector.PortName = ConfigurationManager.AppSettings["SerialPortName"];
                    //Se crea el evento 
                    Lector.DataReceived += Lector_DataReceived;
                }
            }
            catch
            {
                throw;
            }
        }
        public void PuertoOpen()
        {
            try
            {
                ultimocodigoLeido = null;
                if (!Lector.IsOpen && usarSerial!=0)
                {
                    Lector.Open();
                }
                contador++;
            }
            catch
            {
                throw;
            }
        }
        public void PuertoClose()
        {
            try
            {
                contador--;
                if (contador == 0 && usarSerial != 0)
                {
                    Lector.Close();
                }
            }
            catch
            {
                throw;
            }
        }
        private void Lector_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (Lector.BytesToRead > 0)
            {
                char DatIn =(char) Lector.ReadChar();
                if (DatIn != 0xd)
                {
                    Codigo += DatIn;
                }
                else
                {
                    var code = new CodigoBarras(Codigo);
                    if (OnCodigoBarras!=null) OnCodigoBarras(code);
                    ultimocodigoLeido = code;
                    Codigo = "";
                }
            }
        }
    }
}
