using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
  public class Automovil
  {
    //Atributo no estático
    public Single velocidadActual;

    //Atributo estático.
    public static byte cantidadRuedas;

    //Método estático.
    public static void MostrarCantidadRuedas()
    {
      Console.Write(Automovil.cantidadRuedas);
    }

    //Métdos no estáticos.
    public void Acelerar (Single velocidad)
    {
      this.velocidadActual += velocidad;
    }
  }
}
