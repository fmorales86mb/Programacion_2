using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 6)
                    this.patente = value;
            }
        }

        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public abstract string ConsultarDatos();
        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendLine("Fecha y Hora de ingreso: " + this.ingreso.ToString());

            return sb.ToString();
        }
        public override string ToString()
        {
            return string.Format("Patente {0}", this.Patente);
        }

        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente && object.Equals(v1, v2));
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
