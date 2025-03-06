using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUI_Compuesto
{
    public partial class Error : MetroFramework.Forms.MetroForm
    {
        public Error()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        System.Timers.Timer autoSelectTimer = new System.Timers.Timer(1000);
        private void Error_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            autoSelectTimer.Elapsed += AutoSelectTimer_Elapsed;
            autoSelectTimer.Start();
            autoSelectTimer.Enabled = true;
            pictureBox1.Select();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.RemoveCloseButton();
        }

        private void AutoSelectTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            btnOk.Select();
            autoSelectTimer.Stop();
        }
    }
}
