using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
{
  public class Dolar
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    private Dolar()
    {
      cotizRespectoDolar = 1;
    }

    // Acá reutilizo el código donde seteo la cotizacion
    public Dolar(double cantidad) : this()
    {
      this.cantidad = cantidad;
    }

    // Al cotizacion ser estático no conviene llamar y pisarlo nuevamente. Otro objeto la puede estar usando
    // y puede quedar en el medio con un valor erroneo.
    public Dolar(double cant, float cotiz)// : this(cant)
    {
      this.cantidad = cant;
      cotizRespectoDolar = cotiz;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public static double GetCotizacion()
    {
      return cotizRespectoDolar;
    }

    public static explicit operator Euro(Dolar d)
    {
      return new Euro(d.GetCantidad() * Euro.GetCotizacion());
    }

    public static explicit operator Pesos(Dolar d)
    {
      return new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
    }

    public static bool operator != (Dolar dolar, Euro euro)
    {
      return (dolar.cantidad * cotizRespectoDolar != euro.GetCantidad());
    }

    public static bool operator ==(Dolar dolar, Euro euro)
    {
      return (dolar.cantidad * cotizRespectoDolar == euro.GetCantidad());
    }

    /*
    public static Euro operator Euro(Dolar dolar)
    {
      return new Euro();
    }
    */





  }
}
