using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaSobrecarga;

namespace Ejercicio_19
{
  class Program
  {
    static void Main(string[] args)
    {
      Sumador sumador1 = new Sumador(5);
      Sumador sumador2 = new Sumador();

      while (!(sumador1 | sumador2))
      {
        sumador2.Sumar(123, 23);
        Console.WriteLine("sumas1 = {0} y sumas2 = {1}", ((int)sumador1).ToString(), ((int)sumador2).ToString());
      }

      Console.ReadKey();
    }
  }
}
