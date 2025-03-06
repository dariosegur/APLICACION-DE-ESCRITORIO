using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager
{
    public partial class EsperaForm : Form
    {
        public EsperaForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void EsperaForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
