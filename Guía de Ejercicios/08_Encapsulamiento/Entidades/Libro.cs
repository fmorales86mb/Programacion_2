using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Libro
    {
        private List<string> paginas;

        public string this[int i]
        {
            get
            {
                string pagina = string.Empty;
                if (i < this.paginas.Count())                
                    pagina = this.paginas[i];

                return pagina;                
            }
            set { }
        }
            

    }
}
