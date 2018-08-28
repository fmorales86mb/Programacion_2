using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMetodosEstaticos;

namespace Ejercicio_12
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio_12";
      int valor = 0;
      char respuesta = '0';
      
      do
      {
        Console.Clear();
        Solicitud.PedirEntero("Ingrese un nro entero: ", "Valor erroneo.", ref valor);
        Matematica.Sumador(valor);
        Solicitud.PedirCharLetra("¿Continuar? (S/n) ", "Valor erroneo.", ref respuesta);
      } while (ValidarRespuesta.ValidaS_N(respuesta));

      Console.WriteLine("Sumatoria = " + Matematica.Sumatoria.ToString());
      Console.ReadKey();
    }
  }
}
