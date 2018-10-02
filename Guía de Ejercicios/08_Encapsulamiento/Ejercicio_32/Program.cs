using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(32386131, "Federico", 3, 1);
            Jugador j2 = new Jugador(32386132, "Randhall", 9, 2);
            Jugador j3 = new Jugador(32386133, "Lucas", 15, 5);
            Jugador j4 = new Jugador(32386134, "José", 16, 5);
            List<Jugador> lista = new List<Jugador>();
            lista.Add(j1);
            lista.Add(j2);
            lista.Add(j3);
            lista.Add(j4);

            Equipo equipo = new Equipo(3, "Los Mantenidos");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Se agregan jugadores: \n");

            for (int i = 0; i < lista.Count; i++)
            {
                // agrego los jugadores.
                if (equipo + lista[i])
                    sb.AppendLine(lista[i].MostrarDatos());
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
