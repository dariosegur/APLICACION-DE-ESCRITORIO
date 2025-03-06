using System.Windows.Forms;
using System.Diagnostics;

namespace LabManager.BarcodeScaner
{
    public class KeyBoardBarcodeScanner
    {
        private const int msThreshold = 70;
        private Stopwatch timeCounter;

        public delegate void CodBarras(CodigoBarras Codigo);
        public event CodBarras OnCodigoBarras;
        private MetroFramework.Controls.MetroTextBox controlMetroTextBox;
        private Control controlTextBox;

        public KeyBoardBarcodeScanner(MetroFramework.Controls.MetroTextBox control)
        {
            controlMetroTextBox = control;
            controlMetroTextBox.KeyPress += Control_KeyPress;
            timeCounter = new Stopwatch();
        }

        public KeyBoardBarcodeScanner(Control control)
        {
            controlTextBox = control;
            controlTextBox.KeyPress += Control_KeyPress;
            timeCounter = new Stopwatch();
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0xD)
            {
                timeCounter.Stop();
                long msFromLastkey = timeCounter.ElapsedMilliseconds;
                timeCounter.Reset();
                if ((msFromLastkey < msThreshold) && OnCodigoBarras != null)
                {
                    CodigoBarras code;
                    if (sender.GetType() == typeof(MetroFramework.Controls.MetroTextBox))
                    {
                        var codeModificado = controlMetroTextBox.Text.Replace("\'","-");
                        code = new CodigoBarras(codeModificado);
                        controlMetroTextBox.Text = code.Codigo;
                    }
                    else {
                        code = new CodigoBarras(controlTextBox.Text.Replace("\'", "-"));
                        controlTextBox.Text = code.Codigo;
                    }
                    OnCodigoBarras(code);
                    e.Handled = true;
                }
            }
            else {
                timeCounter.Reset();
                timeCounter.Start();
            }
        }
    }
}
