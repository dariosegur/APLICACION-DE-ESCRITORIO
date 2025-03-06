using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.BarcodeScaner
{
    public class CodigoBarras
    {

        public string Codigo { get; set; }
        public bool EsEquipo { get; set; }
        public CodigoBarras(char[] cod)
        {
            string X = new string(cod);
            new CodigoBarras(X);
        }
        public CodigoBarras(string cod)
        {
            try
            {
                Codigo = cod;
                if (cod.Length>=3&&cod[0] == '.' && cod[1] == '3' && cod[cod.Length-1] == '$')
                {
                    EsEquipo = true;
                    Codigo = Codigo.Remove(0,2);
                    Codigo = Codigo.Remove(Codigo.Length - 1, 1);
                }
                else
                {
                    EsEquipo = false;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
