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
      int cant = 3;
      int limIzquierdo = -100;
      int limDerecho = 100;

      // recorro 10 nros.
      for (int i = 0; i < cant; i++)
      {
        // Valido que se haya ingresado un nro.
        if (Solicitud.PedirEntero("Ingrese un nro: ", "Valor erroneo.", ref valor))
        {
          // Valido que esté en el rango.
          if (Validacion.Validar(valor, limIzquierdo, limDerecho))
          {
            Matematica.AsignarMaxMinMedia(i, valor);
          }
        }
      }

      Console.WriteLine("Máximo = " + Matematica.Max.ToString());
      Console.WriteLine("Mínimo = " + Matematica.Min.ToString());
      Console.WriteLine("Promedio = " + Matematica.Media.ToString());

      Console.ReadKey();
    }
  }
}
