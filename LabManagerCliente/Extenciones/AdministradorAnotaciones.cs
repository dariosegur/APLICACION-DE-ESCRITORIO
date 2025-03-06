using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagerCliente.AdministradorAnotacionService
{
    partial class View_Anotaciones : ICloneable
    {
        public enum EstadosAnotacion {
            Activa=1,
            Atendida=2,
            Anulada=3
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
