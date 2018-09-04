using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
{
  public class Pesos
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    private Pesos()
    {
      cotizRespectoDolar = (float) (Dolar.GetCotizacion() / 17.55);
    }

    public Pesos(double cant) : this()
    {
      this.cantidad = cant;
    }

    public Pesos (double cant, float cotiz)
    {
      this.cantidad = cant;
      cotizRespectoDolar = cotiz;
    }

    public double GetCantidad ()
    {
      return this.cantidad;
    }

    public static float GetCotizacion()
    {
      return cotizRespectoDolar;
    }


  }
}
