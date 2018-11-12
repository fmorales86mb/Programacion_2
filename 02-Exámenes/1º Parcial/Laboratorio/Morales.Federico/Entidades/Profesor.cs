using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {                
                DateTime hoy = DateTime.Today;
                DateTime ingreso = this.fechaIngreso;
                int dias;

                for (dias = 0; ingreso<DateTime.Today; dias++)
                {
                    ingreso = ingreso.AddDays(1);
                }

                //TimeSpan dif = hoy - ingreso;
                //int difdias = dif.Days;

                return dias;
            }
        }

        public Profesor(string nombre, string apellido, string documento) 
            : base(nombre, apellido, documento)
        {
        }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder(base.ExponerDatos());

            sb.AppendFormat("Antiguedad: {0}\n", this.Antiguedad);
            sb.AppendLine();

            return sb.ToString();
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            bool valido = false;

            if (doc.Length == 8)
                valido = true;

            return valido;
        }
    }
}
