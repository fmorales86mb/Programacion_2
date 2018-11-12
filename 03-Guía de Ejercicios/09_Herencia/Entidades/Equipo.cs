using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool agregado = true;
            
            for(int i = 0; i<e.jugadores.Count;i++)
            {
                if(e.jugadores[i] == j)
                {
                    agregado = false;
                    break;
                }
            }

            if (agregado && e.jugadores.Count < e.cantidadDeJugadores)
                e.jugadores.Add(j);
            else
                agregado = false;

            return agregado;
        }
    }
}
