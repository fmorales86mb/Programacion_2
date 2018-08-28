using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_04";            
            int cantNrosPerfectos = 4;
            
            for (int i = 1; cantNrosPerfectos > 0; i++)
            {
                if (IsPerfecto(i))
                {
                    Console.WriteLine(i.ToString());
                    cantNrosPerfectos--;
                }
            }
            
            Console.ReadKey();
        }
        
        /// <summary>
        /// Evalua si el nro es perfecto.
        /// </summary>
        /// <param name="nro">Entero positivo.</param>
        /// <returns></returns>
        private static bool IsPerfecto(int nro)
        {
            bool isPerfecto;
            int acumulador = 0;           

            for (int i = 1; i < nro; i++)
            {
                if (nro % i == 0) acumulador += i;                
            }

            isPerfecto = acumulador == nro ? true : false;

            return isPerfecto;
        }
    }
}

