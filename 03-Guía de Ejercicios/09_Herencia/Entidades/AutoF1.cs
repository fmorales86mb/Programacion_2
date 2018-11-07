using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        // Atributos.
        private short caballosDeFuerza;

        // Propiedades.
        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        // Constructores.
        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {
            this.CaballosDeFuerza = 0;
            this.EnCompetencia = false;
            this.VueltasRestantes = 0;
            this.CantidadCombustible = 0;
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        // Métodos.
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendFormat("Caballos de fuerza: {0}", this.CaballosDeFuerza);
            sb.AppendLine(" -----------------------------------");

            return sb.ToString();
        }

        // Sobrecarga de operadores.
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            return (auto1 == auto2 && auto1.CaballosDeFuerza == auto2.CaballosDeFuerza);
        }
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2); 
        }
    }
}
