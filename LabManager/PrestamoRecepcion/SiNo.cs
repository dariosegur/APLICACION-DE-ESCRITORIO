using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager.PrestamoRecepcion
{
    public partial class SiNo : MetroFramework.Forms.MetroForm
    {
        public SiNo(string Titulo, string Pregunta)
        {
            InitializeComponent();
            lbTitulo.Text = Titulo;
            lbText.Text = Pregunta;
        }

        private void BtnAcepta_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void BtnRechaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void Restricciones_Load(object sender, EventArgs e)
        {
            RemoveCloseButton();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            lbTitulo.Focus();
        }
    }
}
