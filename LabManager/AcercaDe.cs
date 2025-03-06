using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager
{
    public partial class AcercaDe : MetroFramework.Forms.MetroForm
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {
            mtAcercaDe.Text =
                "Aplicación realizada por:\r\n"
                + "Facultad de Ingeniería Electrónica\r\n"
                + "Universidad Santo Tomas\r\n"
                + "Programador principal:\r\n"
                + "\tDario Alejandro Segura Torres, <dariosegura@usantotomas.edu.co>;<togo3@hotmail.com>\r\n"
                + "Programadores junior (Estudiantes):\r\n"
                + "\tMiguel Elkin Jiménez Avila <miguel.jimenez@usantotomas.edu.co>:<elkin1198@hotmail.com>,\r\n"
                + "\tMaria Carolina Bravo Navarro, <mariabravon@usantotomas.edu.co>;<mariak29m@outlook.com>\r\n"
                + "Especiales gracias a:\r\n"
                + "\tA los creadores de la primera versión (2002-2017) Eriwn Shroeder y Dario Segura.\r\n"
                + "\tLos compañeros de laboratorio:\r\n"
                + "\t\tWilliam Rodríguez Yara\r\n"
                + "\t\tYobany Fuentes Pulido\r\n"
                + "\t\tEdwin Andres Torres\r\n"
                + "\t\tLuis Javier Rondon\r\n"
                + "\t\tJuan De Jesus Hernandez\r\n"
                + "\t\tJeison Javier Sarmiento\r\n"
                + "\t\tFranklim Alam Gonzales\r\n1"
                + "\t\tJuan Carlos Sanchez\r\n"
                + "\tAl personal que gestionó y apoyó el proyeto administrativamente:\r\n"
                + "\tLeonel Giraldo\r\n"
                + "\tJavier Barajas\r\n"
                + "\tNelson Rojas\r\n"
                + "\t\r\n";
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            lVersion.Text = "Versión " + version;
        }
    }
}
