using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        // Atributos
        private List<Mascota> manada;
        private string nombre;
        private static TipoManda tipo;
        
        // Propiedades
        public static TipoManda Tipo
        {
            set
            {
                tipo = value;
            }
        }

        // Constructores
        static Grupo()
        {
            Tipo = TipoManda.Unica;
        }
        private Grupo()
        {
            manada = new List<Mascota>();
        }
        public Grupo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, TipoManda tipo)
            : this(nombre)
        {
            Tipo = tipo;
        }

        // Métodos

        // Operadores
        public static bool operator ==(Grupo g, Mascota m)
        {
            return g.manada.Contains(m);
        }
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
                g.manada.Add(m);
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
                g.manada.Remove(m);
            return g;
        }
        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("**{0} {1}**\n", g.nombre, tipo.ToString());
            sb.AppendLine("Integrantes:");
            foreach (Mascota m in g.manada)
            {
                sb.AppendLine(m.ToString());
            }

            return sb.ToString();
        }

        // Enumerables
        public enum TipoManda
        {
            Unica,
            Mixta
        }

    }
}
