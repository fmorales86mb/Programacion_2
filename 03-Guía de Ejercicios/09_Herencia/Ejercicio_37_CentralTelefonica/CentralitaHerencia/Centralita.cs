using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        // Atributos.
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        // Propiedades.
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.ETipoLlamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(Llamada.ETipoLlamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(Llamada.ETipoLlamada.Todas); }
        }
        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        // Métodos.
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string NombreEmpresa) : this()
        {
            this.razonSocial = NombreEmpresa;
        }

        /// <summary>
        ///  Calcula el valor de lo recaudado de la lista de llamadas, según el criterio elegido en el filtro.
        /// </summary>
        /// <param name="tipo">Filtro para calcular lo recaudado.</param>
        /// <returns>Valor de lo recaudado según el filtro.</returns>
        private float CalcularGanancia(Llamada.ETipoLlamada tipo)
        {
            float ganancia = 0;
            foreach(Llamada llamada in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.ETipoLlamada.Local:
                        if (llamada is Local)
                            ganancia += ((Local)llamada).CostoLlamada;
                        break;
                    case Llamada.ETipoLlamada.Provincial:
                        if (llamada is Provincial)
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        break;
                    default:
                        if (llamada is Local)
                            ganancia += ((Local)llamada).CostoLlamada;
                        else if (llamada is Provincial)
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        break;
                }
            }
            
            return ganancia;
        }

        /// <summary>
        /// Genera un string con la razón social, la ganancia total, ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Razón Social: {0}", this.razonSocial);
            sb.AppendFormat("Ganancia Total: {0}", Math.Round(this.GananciasPorTotal, 2));
            sb.AppendFormat("Ganancia Total: {0}", Math.Round(this.GananciasPorLocal, 2));
            sb.AppendFormat("Ganancia Total: {0}", Math.Round(this.GananciasPorProvincial, 2));
            sb.AppendLine();
            // Mostrar es un método virtual, por lo tanto en tiempo de ejecución va a tomar la implementación del tipo de dato real.
            foreach(Llamada llamada in this.Llamadas)            
                llamada.Mostrar();            

            return sb.ToString();
        }

        /// <summary>
        /// Ordena en forma ascendente la lista de llamadas.
        /// </summary>
        public void OrdenarLlamadas()
        {
            Llamada llamadaAux;

            for (int i = 0; i < this.listaDeLlamadas.Count - 1; i++)
            {
                for (int j = i + 1; j < this.listaDeLlamadas.Count; j++)
                {
                    if (Llamada.OrdenarPorDuracion(this.listaDeLlamadas[i], this.listaDeLlamadas[j]) < 0)
                    {
                        llamadaAux = this.listaDeLlamadas[i];
                        this.listaDeLlamadas[i] = this.listaDeLlamadas[j];
                        this.listaDeLlamadas[j] = llamadaAux;
                    }
                }
            }
        }
    }
}
