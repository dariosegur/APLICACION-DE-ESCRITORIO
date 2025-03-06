using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var result = new DialogResult();
            do {
                var login = new Seguridad.Login();
                result = login.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    
                    Application.Run(new Vprincipal(login.Usuario) {});
                }
            } while (result!=DialogResult.Cancel);
        }
    }
}
