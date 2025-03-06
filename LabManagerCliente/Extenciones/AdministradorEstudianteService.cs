using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorEstudianteService
{
    partial class View_Estudiante : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
