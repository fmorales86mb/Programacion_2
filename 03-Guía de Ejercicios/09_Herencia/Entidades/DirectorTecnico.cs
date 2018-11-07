using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento{
            get 
            { 
                return this.fechaNacimiento; 
            }
        }

        private DirectorTecnico(string nombre)
            : base(nombre)
        { 
        }
        // constructor público o privado? dice privado pero debería ser público.
        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendFormat("Fecha de Nacimiento: {0}", this.FechaNacimiento);

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return (dt1.Nombre == dt2.Nombre && dt1.FechaNacimiento == dt2.FechaNacimiento);
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
