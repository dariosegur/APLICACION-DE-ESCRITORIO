using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorAdministrativoService
{
    partial class View_Administrativo : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
