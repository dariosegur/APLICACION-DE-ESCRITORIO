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
    public partial class InputFieldText : IInput
    {
        public InputFieldText()
        {
            InitializeComponent();
        } 

        public string Valor {
            get { return mControl.Text; }
            set { mControl.Text = value; }
        }

        public string WaterMark
        {
            get { return mControl.WaterMark; }
            set { mControl.WaterMark = value; }
        }

        public char PasswordChar
        {
            get { return mControl.PasswordChar; }
            set { mControl.PasswordChar = value; }
        }

        public bool Multiline
        {
            get { return mControl.Multiline; }
            set { mControl.Multiline=value; }
        }

        public new event KeyPressEventHandler KeyPress
        {
            add { mControl.KeyPress += value; }
            remove { mControl.KeyPress -= value; }
        }

        public int MaxLength
        {
            get { return mControl.MaxLength; }
            set { mControl.MaxLength = value; }
        }
    }
}
