using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public VehiculoDeCarrera this[int i] 
        {
            
        }

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
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

        // parche, ver qué hace
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static short RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return (short)random.Next(min, max);
            }
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool agregado = false;
            Random rand = new Random();
            
            if (c != a && c.competidores.Count < c.cantidadCompetidores)
            {
                // short aux = (short)rand.Next(15, 100);
                short aux = RandomNumber(15, 100);
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
