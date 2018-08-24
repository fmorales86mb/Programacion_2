using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGuiaEjercicios;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_05";
            int nro;
            string linea;
            int acumuladoL = 0;
            int toEval;

            Console.Write("Ingrese Nro: ");
            linea = Console.ReadLine();

            if (!string.IsNullOrEmpty(linea) && int.TryParse(linea, out nro) )
            {
                for (int i = 1; i+1 < nro; i++)
                {
                    toEval = i + 1;
                    acumuladoL += i;
                    if (ConceptosBasicos.IsCentroNumerico(acumuladoL, toEval, nro)) Console.WriteLine(toEval.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
