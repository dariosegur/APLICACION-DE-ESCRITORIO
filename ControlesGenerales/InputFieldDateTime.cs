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
    public partial class InputFieldDateTime : IInput
    {
        public DateTime Valor
        {
            get { return mControl.Value; }
            set { mControl.Value = value; }
        }

        public event EventHandler ValueChanged {
             add{ mControl.ValueChanged+=value; }
             remove{ mControl.ValueChanged-=value; }
        }

        public InputFieldDateTime()
        {
            InitializeComponent();
        }
    }
}
