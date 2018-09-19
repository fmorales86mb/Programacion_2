using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_31";
            
            Negocio negocio = new Negocio("Negocio de Prueba");
            Cliente cliente;
            for(int i = 0; i<5; i++)
            {
                cliente = new Cliente(i, "Cliente de prueba");
                negocio.Cliente = cliente;                
            }            

            
            
            while (negocio.ClientesPendientes>0)
            {
               if(~negocio)
                Console.WriteLine("Clientes Pendientes: " + negocio.ClientesPendientes.ToString());
            }

            Console.ReadKey();
        }
    }
}
