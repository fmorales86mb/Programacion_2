using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        // Atributos.
        protected float costo;        

        // Propiedades.
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        // Métodos.
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) 
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        
        /// <summary>
        /// Calcula el costo de la llamada según duración y costo por tiempo.
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto ()
        {
            return (this.Duracion * this.costo);
        }

        /// <summary>
        /// Genera un string con los datos de la instancia y clase padre.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());

            sb.AppendFormat("Costo de la llamada: {0}", this.CostoLlamada.ToString());
            sb.AppendLine("--------------------------------");

            return sb.ToString();
        }
    }
}
