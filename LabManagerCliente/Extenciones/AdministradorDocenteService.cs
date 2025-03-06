using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorDocenteService
{
    partial class View_Docente : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
