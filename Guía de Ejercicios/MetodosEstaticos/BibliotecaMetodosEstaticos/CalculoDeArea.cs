using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
  public class CalculoDeArea
  {
    public static double CalcularCuadrado(double lado)
    {
      double area = 0;
      if (lado > 0) area = Math.Pow(lado, 3);
      return area;
    }

    public static double CalcularTriangulo(double _base, double h)
    {
      double area = 0;
      if (_base > 0 && h > 0) area = _base * h;
      return area;
    }

    public static double CalcularCirculo (double radio)
    {
      double area = 0;
      if (radio > 0) area = Math.Pow((Math.PI * radio), 2);
      return area;
    }
  }
}
