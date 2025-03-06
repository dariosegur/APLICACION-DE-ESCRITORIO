using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager.General
{
    public partial class IInput : MetroFramework.Controls.MetroUserControl
    {
        /// <summary>
        /// Texto mostrado en la etiqueta
        /// </summary>
        public string Titulo {
            get {
                return mLabel.Text;
            }
            set
            {
                mLabel.Text = value;
            }
        }

        public IInput()
        {
            InitializeComponent();
        }
    }
}
