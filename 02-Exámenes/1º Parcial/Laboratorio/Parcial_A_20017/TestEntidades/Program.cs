using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo objetos
            Gato g1 = new Gato("Mauricio", "ceo");
            Gato g2 = new Gato("Bruma", "Gris");
            Gato g3 = new Gato("Tito", "Negro");

            Perro p1 = new Perro("Bach", "Siberiano", 1, true);
            Perro p2 = new Perro("Moncho", "Cruza", 15, false);
            Perro p3 = new Perro("Cabezón", "Marrón", 6, false);

            Grupo grupo = new Grupo("Los Mantenidos", Grupo.TipoManda.Mixta);

            // Agrego, operadores +
            Console.WriteLine(grupo);

            grupo += g1;
            Console.WriteLine(grupo);
            grupo += g2;
            Console.WriteLine(grupo);
            grupo += g3;
            Console.WriteLine(grupo);
            grupo += p1;
            Console.WriteLine(grupo);
            grupo += p2;
            Console.WriteLine(grupo);
            grupo += p3;
            Console.WriteLine(grupo);

            // operadores - e ==
            grupo += g3;
            Console.WriteLine(grupo);
            grupo -= g1;
            Console.WriteLine(grupo);

            Console.ReadKey();
        }
    }
}
