using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaSobrecarga;

namespace Ejercicio_20
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio_20";

      Dolar dolar = new Dolar(2.5);
      Euro euro = new Euro(3.2);
      Peso peso = new Peso(39.1);

      // Equivalencias
      string equiDolar = string.Format("dolar = {0}U$S = {1}€ = {2}$",
          dolar.GetCantidad().ToString(),
          ((Euro)dolar).GetCantidad().ToString(),
          ((Peso)dolar).GetCantidad().ToString());
      Console.WriteLine(equiDolar);

      string equiEuro = string.Format("euro = {0}€ = {1}U$S = {2}$",
          euro.GetCantidad().ToString(),
          ((Dolar)euro).GetCantidad().ToString(),
          ((Peso)euro).GetCantidad().ToString());
      Console.WriteLine(equiEuro);

      string equiPeso = string.Format("peso = {0}$ = {1}€ = {2}U$S",
          peso.GetCantidad().ToString(),
          ((Euro)peso).GetCantidad().ToString(),
          ((Dolar)peso).GetCantidad().ToString());
      Console.WriteLine(equiPeso);



      // Comparaciones
      if (dolar == euro) Console.WriteLine("dolar igual euro");
      else Console.WriteLine("dolar distinto euro");

      if (dolar == peso) Console.WriteLine("dolar igual peso");
      else Console.WriteLine("dolar distinto peso");

      if (euro == peso) Console.WriteLine("euro igual peso");
      else Console.WriteLine("euro distinto peso");

      if (euro == dolar) Console.WriteLine("euro igual dolar");
      else Console.WriteLine("euro distinto dolar");

      if (peso == dolar) Console.WriteLine("peso igual dolar");
      else Console.WriteLine("peso distinto dolar");

      if (peso == euro) Console.WriteLine("peso igual euro");
      else Console.WriteLine("peso distinto euro");

      if (peso == peso) Console.WriteLine("peso igual peso");
      else Console.WriteLine("peso distinto peso");

      if (euro == euro) Console.WriteLine("euro igual euro");
      else Console.WriteLine("euro distinto euro");

      if (dolar == dolar) Console.WriteLine("dolar igual dolar");
      else Console.WriteLine("dolar distinto dolar");
      // Suma

      Console.WriteLine("dolar + peso = {0}", (dolar + peso).GetCantidad().ToString());
      Console.WriteLine("dolar + euro = {0}", (dolar + euro).GetCantidad().ToString());
      Console.WriteLine("euro + peso = {0}", (euro + peso).GetCantidad().ToString());
      Console.WriteLine("euro + dolar = {0}", (euro + dolar).GetCantidad().ToString());
      Console.WriteLine("peso + euro = {0}", (peso + euro).GetCantidad().ToString());
      Console.WriteLine("peso + dolar = {0}", (peso + dolar).GetCantidad().ToString());

      // Resta

      Console.WriteLine("dolar - peso = {0}", (dolar - peso).GetCantidad().ToString());
      Console.WriteLine("dolar - euro = {0}", (dolar - euro).GetCantidad().ToString());
      Console.WriteLine("euro - peso = {0}", (euro - peso).GetCantidad().ToString());
      Console.WriteLine("euro - dolar = {0}", (euro - dolar).GetCantidad().ToString());
      Console.WriteLine("peso - euro = {0}", (peso - euro).GetCantidad().ToString());
      Console.WriteLine("peso - dolar = {0}", (peso - dolar).GetCantidad().ToString());

      Console.ReadKey();
    }
  }
}
