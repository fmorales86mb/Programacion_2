using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioColecciones;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 26";

            int aux;
            int[] vector = new int[20];
            Random rand = new Random();

            // Creo el vector de nros random
            for (int i = 0; i < vector.Length; i++)
            {
                // Creo un random que es positivo y le asigno signo.
                aux = rand.Next();
                aux = aux * (rand.NextDouble() > 0.5 ? 1 : -1);                
                vector[i] = aux;
            }

            // Muestro el vector 
            Console.WriteLine("Muestro el vector:");
            Console.WriteLine();
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.WriteLine();

            // Muestro positivos en forma decreciente.            
            Console.WriteLine("Muestro positivos en forma decreciente:");
            Console.WriteLine();
            for (int i = 0; i < vector.Length -1; i++)
            {
                for (int j = i+1; j < vector.Length; j++)
                {
                    if (Ordenado.Comparador(vector[i], vector[j]) < 0)
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }                
            }
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i]>0) Console.WriteLine(vector[i]);
            }
            Console.WriteLine();

            // Muestro negativos en forma creciente.
            Console.WriteLine("Muestro negativos en forma creciente:");
            Console.WriteLine();
            for (int i = vector.Length -1; i >=0 ; i--)
            {
                if (vector[i]<0) Console.WriteLine(vector[i]);
            }

            Console.ReadKey();
        }
    }
}
