using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager
{
    public class Mensaje
    {
        static private int llamados=0;
        static private object sync = new object();

        static public void Error(string Titulo, String Mensaje)
        {
            var error = new MetroUI_Compuesto.Error();
            error.Text = Titulo;
            error.tbMensaje.Text = Mensaje;
            error.ShowDialog();
            //MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static public void Informacion(string Titulo, String Mensaje)
        {
            MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static public DialogResult PreguntaSiNo(string Titulo, String Mensaje)
        {
            return MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        static EsperaForm esperaForm=new EsperaForm();

        static public void IniciaEspera()
        {
            var ts = new System.Threading.ThreadStart(MuestraMensaje);
            var t = new System.Threading.Thread(ts);
            t.Start();
        }

        static public void TerminaEspera()
        {
            lock(sync)
            {
                llamados--;
            }
            if (llamados == 0) esperaForm.Hide();
        }

        static private void MuestraMensaje()
        {
            lock(sync)
            {
                llamados++;
            }
            if (llamados == 1) esperaForm.Show();
        }
    }
}
