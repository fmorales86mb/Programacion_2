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
            bool agregado = false;
            Random rand = new Random();
            
            if (c != a && c.competidores.Count < c.cantidadCompetidores)
            {
                short aux = (short)rand.Next(15, 100);
                
                // consultar, acá esta el error.
                a.CantidadCombustible = aux;
                a.VueltasRestantes = c.cantidadVueltas;
                a.EnCompetencia = true;
                c.competidores.Add(a);
                //c.competidores.Last().EnCompetencia = true;
                //c.competidores.Last().VueltasRestantes = c.cantidadVueltas;
                //c.competidores.Last().CantidadCombustible = aux;
                aux = 0;
                rand = null;
                agregado = true;
            }

            return agregado;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool removido = false;
            if(c==a)
            {
                c.competidores.Remove(a);
                removido = true;
            }
            return removido;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool yaExiste = false;
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a) yaExiste = true;
            }

            return yaExiste;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {            
            return !(c==a);
        }
    }
}
