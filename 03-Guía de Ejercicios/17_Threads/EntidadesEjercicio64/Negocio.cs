using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EntidadesEjercicio64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }
        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }
        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");

            foreach(string cliente in this.Clientes)
            {                
                if (this.Caja1.FilaClientes.Count() < this.Caja2.FilaClientes.Count())
                {
                    this.Caja1.FilaClientes.Add(cliente);
                }
                else
                {
                    this.Caja2.FilaClientes.Add(cliente);
                }
                Thread.Sleep(1000);
            }            
        }
        
    }
}
