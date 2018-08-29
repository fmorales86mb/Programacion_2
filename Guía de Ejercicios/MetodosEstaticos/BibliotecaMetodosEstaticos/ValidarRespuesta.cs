using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
    public class ValidarRespuesta
    {
        /// <summary>
        /// Evalua si el valor es S
        /// </summary>
        /// <param name="c"></param>
        /// <returns>Verdadero si es 'S' o 's'</returns>
        public static bool ValidaS_N(char c)
        {
            bool isS = false;
            if (c == 'S' || c == 's') isS = true;
            return isS;
        }
    }
}
