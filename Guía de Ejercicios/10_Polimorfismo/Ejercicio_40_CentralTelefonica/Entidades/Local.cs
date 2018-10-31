using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        // Atributos.
        protected float costo;        

        // Propiedades.
        public override float CostoLlamada
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
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());

            sb.AppendLine();
            sb.AppendFormat("Costo de la llamada: {0}", this.CostoLlamada.ToString());
            sb.AppendLine();
            sb.AppendLine("--------------------------------");

            return sb.ToString();
        }
        /// <summary>
        /// Equals retornará true sólo si el objeto que recibe es de tipo Local.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (obj is Local);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
