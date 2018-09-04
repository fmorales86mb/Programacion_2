using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
{
  public class Euro
  {
    private double cantidad;
    private static float cotizRespectoEuro;

    public Euro(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public static double GetCotizacion ()
    {
      return cotizRespectoEuro;
    }
  }
}
