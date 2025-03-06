using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace LabManager.General
{
    public partial class InputFielComboBoxSiNo : IInput
    {
        public InputFielComboBoxSiNo()
        {
            InitializeComponent();
        }

        public bool? Valor
        {
            get
            {
                switch (mControl.SelectedIndex)
                {
                    case 1: return true;
                    case 2: return false;
                    default: return null;
                }
            }

            set {
                mControl.SelectedIndex =
                    value == null ? 0 : ((value??true) ? 1 : 2);
            }
        }
    }
}
