using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        // Enum.
        public enum ETipoLlamada
        {
            Local, 
            Provincial,
            Todas
        }

        // Atributos.
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        // Propiedades.
        public float Duracion
        {
            get { return duracion; }
        }
        public string NroDestino
        {
            get { return nroDestino; }
        }
        public string NroOrigen
        {
            get { return nroOrigen; }
        }

        // Métodos.
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        /// <summary>
        /// Genera un string con los datos de la instancia.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Duración: {0}", this.duracion);
            sb.AppendFormat("Nro. destino: {0}", this.nroDestino);
            sb.AppendFormat("Nro. origen: {0}", this.nroOrigen);            

            return sb.ToString();
        }

        /// <summary>
        /// Método de clase. Se utiliza para ordenar una lista de llamadas de forma ascendente según su duración.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns>Retorna 1 si llamada1 tiene menor duración que llamada 2, caso contrario retorna -1. Retorna 0 si son iguales.</returns>
        public static int OrdenarPorDuracion (Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1.Duracion < llamada2.Duracion)
                retorno = 1;
            else if (llamada1.Duracion > llamada2.Duracion)
                retorno = -1;

            return retorno;
        }
    }
}
