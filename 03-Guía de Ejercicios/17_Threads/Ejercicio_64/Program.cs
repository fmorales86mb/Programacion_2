using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EntidadesEjercicio64;

namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tNegocio;
            Thread tCaja1;
            Thread tCaja2;

            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);

            negocio.Clientes.Add("cliente1");
            negocio.Clientes.Add("cliente2");
            negocio.Clientes.Add("cliente3");
            negocio.Clientes.Add("cliente4");
            negocio.Clientes.Add("cliente5");

            tNegocio = new Thread(negocio.AsignarCaja);
            tCaja1 = new Thread(negocio.Caja1.AtenderClientes);
            tCaja2 = new Thread(negocio.Caja2.AtenderClientes);

            tCaja1.Name = "Caja 1";
            tCaja2.Name = "Caja 2";
            
            tNegocio.Start();
            tNegocio.Join(); // frena el flujo hasta que termine el hilo.
            tCaja1.Start();
            tCaja2.Start();


            Console.ReadKey();
        }
    }
}
