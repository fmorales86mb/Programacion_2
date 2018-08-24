using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";
            double nro;                                                         
            string linea;
   
            Console.Write("Ingrese Nro: ");
            linea = Console.ReadLine();

            if (!string.IsNullOrEmpty(linea) && double.TryParse(linea, out nro))
            {
                if (nro > 0)
                {
                    Console.WriteLine("Cuadrado = " + Math.Pow(nro, 2));
                    Console.WriteLine("Cubo = " + Math.Pow(nro, 3));
                }
                else
                {
                    Console.WriteLine("El nro debe ser positivo.");
                }
            }
                        
            Console.ReadKey();
        }
    }
}
