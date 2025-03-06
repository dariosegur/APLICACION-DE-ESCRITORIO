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
    public partial class InputFieldInteger : IInput
    {
        public InputFieldInteger()
        {
            InitializeComponent();
        }

        public string Valor
        {
            get { return mControl.Text; }
            set { mControl.Text = value; }
        }

        public int? ValorEntero
        {
            get { return string.IsNullOrEmpty(mControl.Text)? (int?)null :int.Parse(mControl.Text); }
            set { mControl.Text = value==null?"":value.ToString(); }
        }

        private void mControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9')&&e.KeyChar!=0x8)
            { 
                e.Handled = true;
            }
        }

        public int? Value {
            get {
                if (string.IsNullOrEmpty(mControl.Text)) return null;
                return int.Parse(mControl.Text);
            }
            set {
                if (value == null) mControl.Text = "";
                mControl.Text = value.ToString();
            }
        }
    }
}
