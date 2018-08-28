using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
  class Program
  {
    static void Main(string[] args)
    {
      ClaseEstatica.valorEstatico = 3;
      Person persona = new Person();
      persona.name = "fede";

      // uso mètodos/atributos estaticos
      Automovil.cantidadRuedas = 3;
      Automovil.MostrarCantidadRuedas();

      // instancia de una clase con metodos y atributos no estaticos.
      Automovil auto = new Automovil();
      auto.Acelerar(2);
      Console.WriteLine(auto.velocidadActual);

      Console.ReadKey();
    }
  }
}
