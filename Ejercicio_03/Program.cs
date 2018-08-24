using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_03";
            int nro;
            string linea;

            Console.Write("Ingrese Nro: ");
            linea = Console.ReadLine();

            if (!string.IsNullOrEmpty(linea) && int.TryParse(linea, out nro))
            {
                for (int i=2; i<nro; i++)
                {
                    if (IsPrimo(i)) Console.WriteLine(i.ToString());
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Evalua si el nro es primo.
        /// </summary>
        /// <param name="nro">Entero mayor a cero.</param>
        /// <returns></returns>
        private static bool IsPrimo (int nro)
        {
            bool isPrimo = true;

            if (nro == 1) isPrimo = false;
            
            for (int i = 2; i<nro; i++)
            {
                if (nro%i == 0)
                {
                    isPrimo = false;
                    break;
                }
            }
            
            return isPrimo;
        }
    }
}
