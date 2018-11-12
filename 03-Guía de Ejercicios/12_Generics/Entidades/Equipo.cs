using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        // Atributos
        protected string nombre;
        protected DateTime fechaCreacion;

        // Constructor
        

        // Métodos
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} fundado el {1}", this.nombre, this.fechaCreacion.ToShortDateString());
            return sb.ToString();
        }

        // Operadores
        public static bool operator == (Equipo e1, Equipo e2)
        {
            return (e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion);
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
    }
}
