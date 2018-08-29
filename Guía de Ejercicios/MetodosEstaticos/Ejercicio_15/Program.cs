using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMetodosEstaticos;

namespace Ejercicio_15
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio_15";

      char[] operadores = { '+', '-', '*', '/' };
      double nro1 = 0;
      double nro2 = 0;
      char operador = '0';

      if (Solicitud.PedirDouble("Ingrese primer nro: ", "Valor erroneo.", ref nro1) &&
        Solicitud.PedirDouble("Ingrese segundo nro: ", "Valor erroneo.", ref nro2) &&
        Solicitud.PedirCharAcotado("Operación (+, -, *, /): ", "Valor erroneo.", operadores, ref operador))
      {
        Console.WriteLine("Resultado = " + (Calcluladora.Calcular(nro1, nro2, operador).ToString()));
        Console.ReadKey();
      }
    }
  }
}
