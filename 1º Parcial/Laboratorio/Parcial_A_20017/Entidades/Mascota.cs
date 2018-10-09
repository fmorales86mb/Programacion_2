using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        // Atributos
        private string nombre;
        private string raza;

        // Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        // Constructor
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        // Métodos.
        protected virtual string DatosCompletos()
        {
            return string.Format("{0} {1}", this.Nombre, this.Raza);
        }
        protected abstract string Ficha();

    }
}
