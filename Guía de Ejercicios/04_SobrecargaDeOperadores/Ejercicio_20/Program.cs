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

            // Suma

            // Resta

            Console.ReadKey();
    }
  }
}
