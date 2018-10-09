using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        // Atributos
        private int edad;
        private bool esAlfa;

        // Propiedades
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set 
            {
                this.edad = value;
            }
        }
        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }

        // Constructores
        public Perro(string nombre, string raza)
            : base(nombre, raza)
        {
            this.Edad = 0;
            this.EsAlfa = false;
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : this(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }

        // Métodos
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder(base.DatosCompletos());

            sb.Append(this.EsAlfa ? ", alfa de la manada," : "");
            sb.AppendFormat(" edad {0}", this.Edad);

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            return this == obj;
        }

        // Operadores
        public static bool operator ==(Perro p1, Perro p2)
        {
            return ((p1.Nombre == p2.Nombre) && 
                (p1.Raza == p2.Raza) && 
                (p1.Edad == p2.Edad));
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator int(Perro p)
        {
            return p.Edad;
        }        
    }
}
