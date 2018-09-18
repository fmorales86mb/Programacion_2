using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioColecciones
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)totalGoles / partidosJugados;
            return promedioGoles;
        }

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(long dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.promedioGoles = 0;
        }

        public Jugador(long dni, string nombre, int partidosJugados, int totalGoles):this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("DNI: " + this.dni.ToString());
            sb.AppendLine("Partidos Jugados: " + this.partidosJugados.ToString());
            sb.AppendLine("Goles totales: " + this.totalGoles.ToString());
            sb.AppendLine("Promedio de gol: " + this.GetPromedioGoles().ToString());
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
