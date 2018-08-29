using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
    public class Validacion
    {
        /// <summary>
        /// Evalua si el valor está dentro del intevalo [min - max].
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Verdadero si está dentro.</returns>
        public static bool Validar (double valor, double min, double max)
        {
            bool valido = false;
            if (valor >= min && valor <= max) valido = true;
            return valido;   
        }
    }
}
