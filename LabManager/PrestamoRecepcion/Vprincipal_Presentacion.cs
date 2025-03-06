using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager
{
    partial class Vprincipal
    {
        private void SearchControls(GroupBox Gb, Panel Pn1, Panel Pn2, string Color)
        {   
            foreach (var C in Gb.Controls)
            {
                PaintControls((Control)C, Color);
            }
            foreach (var C in Pn1.Controls)
            {
                PaintControls((Control)C, Color);
            }
            foreach (var C in Pn2.Controls)
            {
                PaintControls((Control)C, Color);
            }
        }
        private void PaintControls(Control Ctrl, string Color)
        {
            if (Ctrl is TextBox || Ctrl.Name.StartsWith("Tb_"))
            {
                switch (Color)
                {
                    case "DodgerBlue":
                        {
                            Ctrl.BackColor = System.Drawing.Color.DodgerBlue;
                        }
                        break;
                    case "RoyalBlue":
                        {
                            Ctrl.BackColor = System.Drawing.Color.RoyalBlue;
                        }
                        break;
                    case "SkyBlue":
                        {
                            Ctrl.BackColor = System.Drawing.Color.SkyBlue;
                        }
                        break;
                    case "DeepSkyBlue":
                        {
                            Ctrl.BackColor = System.Drawing.Color.DeepSkyBlue;
                        }
                        break;
                    default:
                        {
                            Ctrl.BackColor = System.Drawing.Color.White;
                        }
                        break;
                }
            }
        }

        private void ClearPantalla()
        {
            DataGV_Equipos.Rows.Clear();
            Tb_Nombres.Text = "";
            Tb_Apellidos.Text = "";
            Tb_Facultad.Text = "";
            Tb_Anotaciones.Text = "";
            Tb_Multas.Text = "";
            Btn_Nequipos.Text = "";
            Gb_Equipos.Text = "Equipos";
            FocoDeseado = EstadoFoco.CodUsuario;
        }

        private void DataGV_Equipos_Resize(object sender, EventArgs e)
        {
            Clm_TipoEquipo.Width = DataGV_Equipos.Width / 2;
            Clm_CodigoEquipo.Width = DataGV_Equipos.Width / 2;
        }

        private void DataGV_Equipos_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            try
            {
                Clm_CodigoEquipo.Width = DataGV_Equipos.Width - Clm_TipoEquipo.Width;
            }
            catch
            {
                Mensaje.Error("Error", "Error al establecer tamaño de las columnas ");
            }
        }

        private void Btn_Nequipos_Click(object sender, EventArgs e)
        {
            Mensaje.Informacion("Numero de equipos", "numero de equipos");
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                string posX = SpCn_Usuario.SplitterDistance.ToString(), posY = SpCn_EquiposInformacion.SplitterDistance.ToString();
                string direccion = Application.StartupPath + @"\PosicionApp.txt"; ;
                string[] texto = { posX, posY };
                File.WriteAllLines(direccion, texto);
                Close();
            }
            catch
            {
                Mensaje.Error("Error", "Se generó un error al cerrar la aplicación");
            }
        }
    }
}
