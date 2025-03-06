using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorFacultadService
{
    partial class View_Facultad : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        public View_Facultad() {
            FacultadId = -1;
        }
    }
}
