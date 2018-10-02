using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision
        {
            get
            {
                return string.Format("{0}º{1}", this.anio.ToString(), this.division.ToString());
            }
        }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division) 
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder(base.ExponerDatos());

            sb.AppendFormat("Año/División: {0}\n", this.AnioDivision);
            sb.AppendLine();

            return sb.ToString();
        }        
        protected override bool ValidarDocumentacion(string doc)
        {            
            Regex expresion = new Regex(@"\d{2}-\d{4}-\d$");                       
            return expresion.IsMatch(doc);
        }
    }
}
