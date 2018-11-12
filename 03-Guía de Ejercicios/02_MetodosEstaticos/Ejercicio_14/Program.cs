using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMetodosEstaticos;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_14";
            int opcion = 0;
            char seguir = '0';
            double valor1 = 0;
            double valor2 = 0;

            do
            {
                Console.WriteLine("--- MENU ---");
                Console.WriteLine();
                Console.WriteLine("1- Área de un Cuadrado.");
                Console.WriteLine("2- Área de un Triángulo.");
                Console.WriteLine("3- Área de un Círculo.");

                Solicitud.PedirEntero("Ingrese una opción: ", "Valor erroneo.", ref opcion);

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        if (Solicitud.PedirDouble("Ingrese lado del cuadrado: ", "Valor erroneo.", ref valor1))
                        {
                            Console.WriteLine("Área = " + (CalculoDeArea.CalcularCuadrado(valor1)).ToString());
                        }
                        break;
                    case 2:
                        Console.Clear();
                        if (Solicitud.PedirDouble("Ingrese báse del triángulo: ", "Valor erroneo.", ref valor1) &&
                          Solicitud.PedirDouble("Ingrese altura del triángulo: ", "Valor erroneo.", ref valor2))
                        {
                            Console.WriteLine("Área = " + (CalculoDeArea.CalcularTriangulo(valor1, valor2)).ToString());
                        }
                        break;
                    case 3:
                        Console.Clear();
                        if (Solicitud.PedirDouble("Ingrese radio del círculo: ", "Valor erroneo.", ref valor1))
                        {
                            Console.WriteLine("Área = " + (CalculoDeArea.CalcularCirculo(valor1)).ToString());
                        }
                        break;
                    default:
                        Console.Clear();
                        break;
                }

                Solicitud.PedirCharLetra("Salir? (S/n) ", "Valor erroneo.", ref seguir);
            } while (!ValidarRespuesta.ValidaS_N(seguir));

        }
    }
}
