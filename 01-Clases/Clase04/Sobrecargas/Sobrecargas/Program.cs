using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine( (new Metro(3) + new Centimetro(5)).valor );
      if (new Metro(2) != new Centimetro(3)) {
        Console.WriteLine("bla"); }
      Console.ReadKey();
    }
  }
}
