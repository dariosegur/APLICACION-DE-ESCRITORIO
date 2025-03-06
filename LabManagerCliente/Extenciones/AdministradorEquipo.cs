using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorEquipoService
{
    partial class View_Equipo : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        public View_Equipo() {
            EquipoId = -1;
        }
    }
}
