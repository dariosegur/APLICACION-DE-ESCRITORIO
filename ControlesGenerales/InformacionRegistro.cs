using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager
{
    public partial class InformacionRegistro : UserControl
    {
        public InformacionRegistro()
        {
            InitializeComponent();
        }

        public string creadoPor
        {
            get { return CreadoPor.Valor; }
            set { CreadoPor.Valor = value; }
        }

        public string modificadoPor
        {
            get { return ModificadoPor.Valor; }
            set { ModificadoPor.Valor = value; }
        }

        public DateTime fechaCreado {
            get { return FechaCreado.Valor; }
            set { FechaCreado.Valor = value; }
        }

        public DateTime fechaModificado
        {
            get { return FechaModificado.Valor; }
            set { FechaModificado.Valor = value; }
        }
    }
}
