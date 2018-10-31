using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        // Enum.
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        // Atributos
        protected Franja franjaHoraria;

        // Propiedades
        public override float CostoLlamada
        {
            get { return 0; }
        }

        // Métodos.
        public Provincial(string nroOrigen, Franja franja, float duracion, string nroDestino) 
            : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = franja;
        }

        public Provincial(Franja franja, Llamada llamada) 
            : this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino)
        {
        }

        /// <summary>
        /// Retorna el valor de la llamada a partir de la duración y el costo de la misma según la franja horaria.
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float costo = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = (float)0.99 * base.Duracion;
                    break;
                case Franja.Franja_2:
                    costo = (float)1.25 * base.Duracion;
                    break;
                case Franja.Franja_3:
                    costo = (float)0.66 * base.Duracion;
                    break;
                default:
                    break;
            }

            return costo;
        }

        /// <summary>
        /// Genera un string con los datos de la clase base y la derivada.
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());

            sb.AppendFormat("Franja horaria: {0}", this.franjaHoraria);
            sb.AppendLine();
            sb.AppendFormat("Costo de la llamada: {0}", this.CostoLlamada.ToString());
            sb.AppendLine();
            sb.AppendLine("--------------------------------");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
