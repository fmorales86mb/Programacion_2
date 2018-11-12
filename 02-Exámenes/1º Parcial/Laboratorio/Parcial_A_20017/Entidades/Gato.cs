using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        // Atributos

        // Propiedades

        // Constructores
        public Gato(string nombre, string raza)
            : base(nombre, raza)
        {
        }

        // Métodos
        protected override string Ficha()
        {
            return base.DatosCompletos();
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
        public static bool operator ==(Gato g1, Gato g2)
        {
            return ((g1.Nombre == g2.Nombre) && (g2.Raza == g2.Raza));
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
    }
}
