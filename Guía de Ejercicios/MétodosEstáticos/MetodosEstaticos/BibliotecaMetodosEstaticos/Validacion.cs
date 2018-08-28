using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
    public class Validacion
    {
        public static bool Validar (int valor, int min, int max)
        {
            bool valido = false;
            if (valor > min && valor < max) valido = true;
            return valido;   
        }
    }
}
