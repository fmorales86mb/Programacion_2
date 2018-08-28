using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMetodosEstaticos;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_11";
            int valor = 0;
            int limIzquierdo = -100;
            int limDerecho = 100;
            int max = 0;
            int min = 0;
            double media;

            // recorro 10 nros.
            for (int i = 0; i<10; i++)
            {
                if (Solicitud.PedirEntero("Ingrese un nro: ", "Valor erroneo.", ref valor))
                {
                    if (Validacion.Validar(valor, limIzquierdo, limDerecho))
                    {
                        if (i == 0)
                        {
                            max = min = valor;
                        }
                        else if (valor > max) max = valor;
                        else if (valor < min) min = valor;
                    }
                }
            }
        }
    }
}
