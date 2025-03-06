using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorRestriccionService
{
    partial class View_Restriccion : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        public View_Restriccion()
        {
            RestriccionId = -1;           
        }
    }
}
