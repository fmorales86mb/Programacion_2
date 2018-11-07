using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("GranFulbo");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("GranBasque");

            EquipoBasquet b1 = new EquipoBasquet("basquet1", DateTime.Now);
            EquipoBasquet b2 = new EquipoBasquet("basquet2", DateTime.Now);
            EquipoBasquet b3 = new EquipoBasquet("basquet3", DateTime.Now);

            EquipoFutbol f1 = new EquipoFutbol("futbol1", DateTime.Now);
            EquipoFutbol f2 = new EquipoFutbol("futbol2", DateTime.Now);
            EquipoFutbol f3 = new EquipoFutbol("futbol3", DateTime.Now);
            EquipoFutbol f4 = new EquipoFutbol("futbol3", DateTime.Now);

            torneoFutbol = torneoFutbol + f1;
            torneoFutbol = torneoFutbol + f2;
            torneoFutbol = torneoFutbol + f3;
            torneoFutbol = torneoFutbol + f2;
            torneoFutbol = torneoFutbol + f4;

            bool a = f2 == f1;
            bool b = f3 == f4;

            torneoBasquet = torneoBasquet + b1;
            torneoBasquet = torneoBasquet + b2;
            torneoBasquet = torneoBasquet + b3;
            torneoBasquet = torneoBasquet + b1;

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido);
            Thread.Sleep(100);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Thread.Sleep(100);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Thread.Sleep(100);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Thread.Sleep(100);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Thread.Sleep(100);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
