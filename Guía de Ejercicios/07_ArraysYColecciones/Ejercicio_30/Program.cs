using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioColecciones;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_30";

            AutoF1 a1 = new AutoF1(01, "Ford");
            AutoF1 a2 = new AutoF1(02, "Chevrolet");
            AutoF1 a3 = new AutoF1(3, "Fiat");
            AutoF1 a4 = new AutoF1(4, "Jeep");
            List<AutoF1> listaAutos = new List<AutoF1> { a1, a2, a3, a4 };

            Console.WriteLine(a1.MostrarDatos());

            Competencia competencia = new Competencia(6, 3);

            foreach (AutoF1 auto in listaAutos)
            {
                var i = competencia + auto;                
            }

            // Muestra la misma cantidad de combustible para todos. Pero si debagueo no.
            Console.Write(competencia.MostrarDatos());

            Console.ReadKey();
        }
    }
}
