using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntidadesEjercicio64
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            
            foreach(string cliente in this.FilaClientes)
            {
                Thread.Sleep(2000);
                Console.WriteLine(
                    string.Format("Cliente: {0} ; Caja nro: {1}", cliente, Thread.CurrentThread.Name)
                    );
            }
        }
    }
}
