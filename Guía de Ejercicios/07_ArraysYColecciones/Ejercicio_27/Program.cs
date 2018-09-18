using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioColecciones;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 27";

            int aux;            
            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int>();
            Queue<int> cola = new Queue<int>();
            Random rand = new Random();

            #region Lista            
            // Creo el vector de nros random
            for (int i = 0; i < 20; i++)
            {   
                // Creo un random que es positivo y le asigno signo.
                aux = rand.Next();
                aux = aux * (rand.NextDouble() > 0.5 ? 1 : -1);
                lista.Add(aux); // asigna valor o agrega objeto? en este caso es el mismo objeto.
            }

            // Muestro el vector 
            Console.WriteLine("Muestro la Lista:");
            Console.WriteLine();
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();

            // Muestro positivos en forma decreciente.            
            Console.WriteLine("Muestro positivos en forma decreciente:");
            Console.WriteLine();
            
            // Ordeno la lista en forma decreciente.
            lista.Sort();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > 0) Console.WriteLine(lista[i]);
            }
            Console.WriteLine();

            // Muestro negativos en forma creciente.
            Console.WriteLine("Muestro negativos en forma creciente:");
            Console.WriteLine();
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] < 0) Console.WriteLine(lista[i]);
            }
            #endregion

            #region Pila
            // Asigno valores a la pila
            for (int i = 0; i < 20; i++)
            {
                // Creo un random que es positivo y le asigno signo.
                aux = rand.Next();
                aux = aux * (rand.NextDouble() > 0.5 ? 1 : -1);
                pila.Push(aux); // asigna valor o agrega objeto? en este caso es el mismo objeto.
            }

            // Muestro el vector 
            Console.WriteLine("Muestro la Pila:");
            Console.WriteLine();
            for (int i = 0; i < pila.Count; i++)
            {
                Console.WriteLine(pila.Pop());
            }
            Console.WriteLine();

            // Muestro positivos en forma decreciente.            
            Console.WriteLine("Muestro positivos en forma decreciente:");
            Console.WriteLine();

            // Ordeno la lista en forma decreciente.
            

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > 0) Console.WriteLine(lista[i]);
            }
            Console.WriteLine();

            // Muestro negativos en forma creciente.
            Console.WriteLine("Muestro negativos en forma creciente:");
            Console.WriteLine();
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] < 0) Console.WriteLine(lista[i]);
            }
            #endregion

            #region Cola

            #endregion

            Console.ReadKey();
        }
    }
}
