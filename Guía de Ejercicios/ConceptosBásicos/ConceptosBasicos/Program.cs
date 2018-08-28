using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_01";
            int nro;
            int max = 0;
            int min = 0;
            float acumulador = 0;
            int cantNros = 5;
            float promedio;
            string linea;

            for (int i = 0; i < cantNros; i++)
            {
                Console.Write("Ingrese Nro: ");
                linea = Console.ReadLine();

                if (!string.IsNullOrEmpty(linea) && int.TryParse(linea, out nro))
                {
                    if (i == 0)
                    {
                        max = nro;
                        min = nro;
                    }
                    else
                    {
                        if (nro > max) max = nro;
                        if (nro < min) min = nro;
                    }
                    acumulador += nro;
                }
            }

            promedio = acumulador / cantNros;

            Console.WriteLine("Máximo = " + max.ToString());
            Console.WriteLine("Mínimo = " + min.ToString());
            Console.WriteLine("Promedio = " + promedio.ToString());
            Console.ReadKey();
        }
    }
}
