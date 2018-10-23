using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Torneo<T> : IEnumerable where T : Equipo
    {
        // Atributos
        private List<T> equipos;
        private string nombre;

        // Propiedades
        public string JugarPartido
        {
            get
            {
                Random rdm = new Random();
                int i1 = rdm.Next(this.equipos.Count - 1);
                int i2 = rdm.Next(this.equipos.Count - 1);
                return CalcularPartido(this.equipos[i1], this.equipos[i2]);
            }
        }

        // Constructores
        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        // Métodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Torneo {0}", this.nombre);
            sb.AppendLine();
            foreach(T t in this.equipos)
            {
                sb.AppendLine(t.Ficha());
            }

            return sb.ToString();
        }
        private string CalcularPartido(T t1, T t2)
        {
            StringBuilder sb = new StringBuilder();
            Random rdm = new Random();            
            int resultado1 = rdm.Next(100);
            int resultado2 = rdm.Next(100);

            sb.AppendFormat("{0} {1} - {2} {3}",
                t1.Ficha(), resultado1, t2.Ficha(), resultado2);

            return sb.ToString();
        }

        // Operadores
        public static bool operator == (Torneo<T> t, T e)
        {
            bool inscripto = false;

            foreach(T equipo in t.equipos)
            {
                //if (equipo.Equals(e))
                if (equipo == e)
                {
                    inscripto = true;
                    break;
                }
            }

            return inscripto;
        }
        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }
        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if(t!=e)            
                t.equipos.Add(e);

            return t;
        }

        // Interface
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i<this.equipos.Count; i++)
            {
                yield return this.equipos[i];
            }
        }
    }
}
