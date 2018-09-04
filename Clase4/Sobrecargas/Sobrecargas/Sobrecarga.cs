using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
  public class Sobrecarga
  {

    /*
     * cuando creo un constructor (con al menos un parametro!) desaparece el constructor por defecto, ergo tengo que crearlo manualmente.
     *
     * Sobrecarga de casteo (explicito e implicito)
     * implícito cuando no hay pérdida de información (de int a double)
     * siempre static
    */

    // este método llama a la sobrecarga y le pasa el string. 
    public Sobrecarga(): this("Metro")
    {
      // acá puedo llamar a métodos
      //tipoNumero = "Metro";
    }

    public Sobrecarga(string tipo)
    {
      tipoNumero = tipo;
    }

    public string tipoNumero;

    public int Sumar(int nro1, int nro2, int nro3)
    {
      return nro1 + nro2 + nro3;
    }

    public float Sumar(int nro1, int nro2)
    {
      float salida;

      if (tipoNumero == "Metro")
      {
        salida = (nro1 + nro2) * 100;
      }
      else
      {
        salida = (nro1 + nro2);
      }
      return salida;
    }

    public int Sumar(float a, float b)
    {
      return (int)(a + b);
    }



    //public static float Sumar (float nro1, int nro2)
    //{
    //  return (nro1*100)
    //}
  }
}
