    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                string pagina = string.Empty;
                if (i < this.paginas.Count())                
                    pagina = this.paginas[i];

                return pagina;                
            }
            set
            {
                if (this.paginas.Count <= i)
                    this.paginas.Add(value);
                else
                    this.paginas[i] = value;
                
                    //this.paginas[i] = value;
            }
        }
            

    }
}
