using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
  public class Calcluladora
  {
    public static double Calcular(double nro1, double nro2, char operacion)
    {
      double resultado = 0;
      switch(operacion)
      {
        case '+':
          resultado = nro1 + nro2;
          break;
        case '-':
          resultado = nro1 - nro2;
          break;
        case '*':
          resultado = nro1 * nro2;
          break;
        case '/':
          if (Validar(nro2)) resultado = nro1 / nro2;
          else if (nro1 > 0) resultado = double.PositiveInfinity;
          else if (nro1 < 0) resultado = double.NegativeInfinity;          
          break;
        default:
          break;
      }

      return resultado;
    }

    private static bool Validar(double nro2)
    {
      bool esValido = false;
      if (nro2 != 0) esValido = true;
      return esValido;
    }
  }
}
