using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioColecciones
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de Competidores: " + this.cantidadCompetidores.ToString());
            sb.AppendLine("Cantidad de Vueltas: " + this.cantidadVueltas.ToString());
            sb.AppendLine("Competidores: \n");
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine(auto.MostrarDatos());
            }
            sb.AppendLine();
            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool agregado = true;
            for(int i = 0; i < c.competidores.Count; i++)
            {
                if(c.competidores[i] == a || c.competidores.Count < c.cantidadCompetidores)
                {
                    agregado = false;
                    break;
                }
            }
            if (agregado)
                c.competidores.Add(a);

            return agregado;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {

        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {

        }

    }
}
