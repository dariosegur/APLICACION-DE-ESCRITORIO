using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorMultaService
{
    partial class View_Multas : ICloneable
    {
        public enum EstadosMulta {
            Activa=1,
            Pagada=2,
            Anulada=3
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
