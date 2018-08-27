using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGuiaEjercicios;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title= "Ejercicio_09";
            int filas = 0;

            if (ConceptosBasicos.PedirEntero("Número entero positivo: ", "Valor erroneo.", ref filas, 0))
            {
                for (int fila = 1; fila<=filas; fila++)
                {
                    for(int col=1; col <= (2*fila)-1; col++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
