using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            List<string> listaPaginas = new List<string> { "Aquí me pongo a cantar",
                "Al compaz de la viguela", "Como el ave solitaria", "Una pena extraordinaria" };

            for (int i = 0; i < listaPaginas.Count; i++)
            {
                libro[i] = listaPaginas[i];
                Console.WriteLine(libro[i]);
            }

            Console.WriteLine();
            libro[9] = libro[2];
            libro[2] = "Que al hombre que lo desvela";
            libro[7] = "Con el cantar se consuela";

            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine(libro[i]);
            }

            Console.ReadKey();

        }
    }
}
