using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaObjetos;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";
            string[] opciones = { "Agregar alumnos", "Agregar notas", "Mostrar alumnos" };
            int opcion = 0;

            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            do
            {
                Console.Clear();
                Console.WriteLine(Menu.CrearMenu(opciones, "Menú Alumnos"));
                if (Solicitud.PedirEntero("Ingrese una opción: ", "Valor erroneo.", ref opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            alumno1.Inicializar("Federico", "Morales", 01);
                             alumno2.Inicializar("Randhal", "Rangel", 02);
                             alumno3.Inicializar("Alejandro", "Aguero", 03);
                            break;
                        case 2:
                            alumno1.Estudiar(4, 5);
                            alumno2.Estudiar(1, 1);
                            alumno3.Estudiar(0, 9);
                            break;
                        case 3:
                            Console.WriteLine(alumno1.Mostrar());
                            Console.WriteLine(alumno2.Mostrar());
                            Console.WriteLine(alumno3.Mostrar());
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }
                }
            } while (Solicitud.PedirS_N("¿Continuar? (S/n): ", "Valor erroneo."));
            

            Console.ReadKey();
        
        }
    }
}
