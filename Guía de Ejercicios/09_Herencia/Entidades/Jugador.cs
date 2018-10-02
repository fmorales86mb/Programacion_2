using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {        
        private int partidosJugados;        
        private int totalGoles;

        public int PartidosJugados 
        { 
            get
            { 
                return partidosJugados; 
            }
        }
        public float PromedioGoles 
        { 
            get 
            {  
                return PartidosJugados != 0? (float)TotalGoles / PartidosJugados: 0; 
            }
        }
        public int TotalGoles 
        { 
            get 
            {
                return totalGoles;
            }
        }

        public Jugador(int dni, string nombre)
            : base(dni, nombre)
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
            : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());
          
            sb.AppendLine("Partidos Jugados: " + this.PartidosJugados.ToString());
            sb.AppendLine("Goles totales: " + this.TotalGoles.ToString());
            sb.AppendLine("Promedio de gol: " + (Math.Round((double)this.PromedioGoles,2)).ToString());
            sb.AppendLine("----------------------------");

            return sb.ToString();
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.Dni == jugador2.Dni;
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
