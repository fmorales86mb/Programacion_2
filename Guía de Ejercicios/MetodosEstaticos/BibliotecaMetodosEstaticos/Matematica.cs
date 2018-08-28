using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
  public class Matematica
  {
    public static double Max = 0;
    public static double Min = 0;
    public static double Media = 0;
    public static double Sumatoria = 0;
    private static double Acumulador = 0;
    private static int Cant = 0;

    public static double Sumador (double valor)
    {
      return Sumatoria += valor;
    }

    public static void AsignarMaxMinMedia (int index, double valor)
    {
      Acumulador += valor;
      Cant++;

      if (index == 0)
      {
        Max = valor;
        Min = valor;        
      }
      else if (valor > Max) Max = valor;
      else if (valor < Min) Min = valor;

      Media = CalcularMedia(Acumulador, Cant);
    }

    private static double CalcularMedia(double acumulador, int cantidad)
    {
      double media = 0;
      if (Cant != 0)
      {
        media = acumulador / cantidad;
      }
      return media;
    }
  }
}
