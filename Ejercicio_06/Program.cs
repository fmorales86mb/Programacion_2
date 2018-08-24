using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGuiaEjercicios;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";
            string linea;
            int year;

            Console.Write("Ingrese año: ");
            linea = Console.ReadLine();

            if(!string.IsNullOrEmpty(linea) && int.TryParse(linea, out year))
            {
                if (ConceptosBasicos.IsBisiesto(year)) Console.WriteLine("Año bisiesto.");
                else Console.WriteLine("El año ingresado no es bisiesto.");
            }

            Console.ReadKey();
        }
    }
}
