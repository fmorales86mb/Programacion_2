using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if (this != value) clientes.Enqueue(value);
            }
        }
        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool yaExiste = false;

            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)
                {
                    yaExiste = true;
                    break;
                }                    
            }

            return yaExiste;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool seAgrega = false;

            if (n != c)
            {
                seAgrega = true;
                n.Cliente = c;
            }                                            

            return seAgrega;
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
    }
}
