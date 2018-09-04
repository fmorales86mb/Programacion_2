using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
  public class Metro
  {
    /*
     * Sobrcarga del operador '+'
     * 
     * Console.WriteLine( (new Metro(3) + new Centimetro(5)).valor );
     * Console.ReadKey();
     * 
    */
    public Metro(float val)
    {
      valor = val;      
    }    

    public float valor;

    // acceso static tipoRetorno operator nombOperador (tipo a, tipo b)
    public static Metro operator +(Metro metro, Centimetro cent)
    {
      metro.valor += cent.valor / 100;
      return metro;
    }

    //Sobrecarga de comparacaión (es necesario realizar los dos operadores)
    public static bool operator == (Metro metro, Centimetro cent)
    {
      return (metro.valor == cent.valor/100);
    }

    public static bool operator !=(Metro metro, Centimetro cent)
    {
      return (metro.valor != cent.valor / 100);
    }

    // sobrecarga de casteo.
    // explicito: uso (metro)centimetro
    public static explicit operator Metro(Centimetro cent)
    {
      return new Metro(cent.valor / 100);
    }

    //implicito no uso nada, el casteo se hace soo
    public static implicit operator Centimetro(Metro cent)
    {
      return new Centimetro(cent.valor / 100);
    }
  }
}
