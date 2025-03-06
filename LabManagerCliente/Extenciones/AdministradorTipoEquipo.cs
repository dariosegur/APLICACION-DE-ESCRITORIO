using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorTipoEquipoService
{
    partial class View_TipoEquipo : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
