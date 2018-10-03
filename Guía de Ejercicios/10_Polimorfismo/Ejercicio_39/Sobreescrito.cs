using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public abstract string MiPropiedad
        {
            get;
        }

        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "Este es mi método ToString sobreeescito";
        }
        public override bool Equals(object obj)
        {
            return (obj is Sobreescrito);
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
