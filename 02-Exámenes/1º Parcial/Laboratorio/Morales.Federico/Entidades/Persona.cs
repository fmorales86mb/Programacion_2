using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //public enum Divisiones
    //{
    //    A,
    //    B,
    //    C,
    //    D,
    //    E
    //}

    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private string documento;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }       
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if(ValidarDocumentacion(value))
                    this.documento = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n", this.Nombre);
            sb.AppendFormat("Apellido: {0}\n", this.Apellido);
            sb.AppendFormat("Documento: {0}\n", this.Documento);

            return sb.ToString();
        }
        protected abstract bool ValidarDocumentacion(string doc);
    }
}
