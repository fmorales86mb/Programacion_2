using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaObjetos;

namespace Ejercicio_17
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";
            Boligrafo boliAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boliRojo = new Boligrafo(50, ConsoleColor.Red);
            string[] menuEleccionBoligrafo = { "Usar bolígrafo Rojo", "Usar bolígrafo azul", "Salir" };            
            int opcion = 0;
            bool salir = false; 

            do
            {
                Console.Clear();
                Console.WriteLine(Menu.CrearMenu(menuEleccionBoligrafo, "Bolígrafos"));

                if (Solicitud.PedirEntero("Elija una opción: ", "Valor erroneo.", ref opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            EjecutarMenuBoligrafos(boliRojo);                           
                            break;
                        case 2:
                            EjecutarMenuBoligrafos(boliAzul);
                            break;
                        case 3:
                            salir = true;
                            break;
                        default:
                            break;
                    }
                }

            } while (!salir);            
        }

        private static void EjecutarMenuBoligrafos(Boligrafo boligrafo)
        {
            string[] menuOpcionesBoligrafo = { "Pintar", "Recargar", "Volver" };
            int opcion = 0;
            int gasto = 0;
            string dibujo = string.Empty;
            bool volver = false;
            
            do
            {
                Console.Clear();
                Console.WriteLine(Menu.CrearMenu(menuOpcionesBoligrafo, "Acciones del bolígrafo"));

                if (Solicitud.PedirEntero("Elija una opción: ", "Valor erroneo.", ref opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            if (Solicitud.PedirEntero("Gasto de tinta: ", "Valor erroneo.", ref gasto))
                            {
                                boligrafo.Pintar(gasto, out dibujo);
                                Console.WriteLine(dibujo);
                            }                            
                            break;
                        case 2:
                            boligrafo.Recargar();
                            Console.WriteLine("Se recargó el bolígrafo.");                            
                            break;
                        case 3:
                            volver = true;
                            break;
                        default:
                            break;
                    }
                }
            } while (!volver);
        }
    }
}
