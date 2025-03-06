using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorSedeService
{
    partial class View_Sede : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
