using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;

        public int PartidosJugados { get => partidosJugados; }
        public float PromedioGoles { get =>  PartidosJugados != 0? (float)TotalGoles / PartidosJugados: 0; }
        public int TotalGoles { get => totalGoles; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //public float GetPromedioGoles()
        //{
        //    this.promedioGoles = (float)TotalGoles / PartidosJugados;
        //    return PromedioGoles;
        //}

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
            //this.promedioGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.Dni = dni;
            this.Nombre = nombre;            
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles):this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("DNI: " + this.Dni.ToString());
            sb.AppendLine("Partidos Jugados: " + this.PartidosJugados.ToString());
            sb.AppendLine("Goles totales: " + this.TotalGoles.ToString());
            sb.AppendLine("Promedio de gol: " + (Math.Round((double)this.PromedioGoles,2)).ToString());
            sb.AppendLine();
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
