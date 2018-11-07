using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; }

        public Cliente (int numero)
        {
            this.numero = numero;
        }

        public Cliente (int numero, string nombre): this(numero)
        {
            Nombre = nombre;
        }

        public static bool operator == (Cliente cliente1, Cliente cliente2)
        {
            return cliente1.Numero == cliente2.Numero;
        }

        public static bool operator != (Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }
    }
}
