using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorAuxiliarService
{
    partial class View_Auxiliar : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
