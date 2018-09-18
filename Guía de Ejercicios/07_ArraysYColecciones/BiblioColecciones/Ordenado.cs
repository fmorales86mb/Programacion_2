using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioColecciones
{
    public class Ordenado
    {
        /// <summary>
        /// Compara dos valores.
        /// </summary>
        /// <param name="a"> primer valor</param>
        /// <param name="b"> segundo valor</param>        
        /// <returns>a menor que b, -1; a mayor q b, 1; a igual a b, 0 </returns>
        public static int Comparador (double  a, double b)
        {
            int retorno = 0;
            if (a > b) retorno = 1;
            else if (a < b) retorno = -1;
            return retorno;
        }
    }
}
