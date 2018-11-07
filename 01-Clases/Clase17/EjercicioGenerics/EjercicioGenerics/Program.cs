using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

/*
Ejercicios
Dado el siguiente Main [DESCARGAR]:
Utilizar Generics y Arrays construir la clase MiLista que imitará el comportamiento de List. Se deberán crear los métodos:

Add: agregá un ítem al array.
Remove: eliminará el primer elemento igual que encuentre.
Count: propiedad que retornará la cantidad ítems del array.
Implementar IEnumerable para poder recorrerla con, por ejemplo, foreach.

NOTA: se deberá redimensionar el array con Array.Resize tanto en el método Add como en el Remove. 
*/

namespace EjercicioGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            MiLista<String> miLista = new MiLista<String>();

            string item1 = "Item 1";
            string item2 = "Item 2";
            string item3 = "Item 3";
            string item4 = "Item 4";
            string item5 = "Item 5";
            string item6 = "Item 6";

            // Agregar los 6 items y mostrar
            miLista.Add(item1);
            miLista.Add(item2);
            miLista.Add(item3);
            miLista.Add(item4);
            miLista.Add(item5);
            miLista.Add(item6);

            Console.WriteLine("Mostrar Lista Completa");
            Console.WriteLine("Cantidad de items: " + miLista.Count.ToString());
            foreach (string item in miLista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("<**********************************>");
            Console.WriteLine("");
            Console.ReadKey();

            // Quitar un item y mostrar
            miLista.Remove(item4);

            // Intento quitar un item que no está en la lista
            miLista.Remove("Item No Agregado");

            Console.WriteLine("Mostrar Lista Sin Ítem 4.");
            Console.WriteLine("Cantidad de items: " + miLista.Count.ToString());
            foreach (string item in miLista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("<**********************************>");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
