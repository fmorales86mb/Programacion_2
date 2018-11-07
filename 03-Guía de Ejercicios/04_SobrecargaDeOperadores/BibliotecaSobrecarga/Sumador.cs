using System;

namespace BibliotecaSobrecarga
{
  public class Sumador
  {
    // Atributo de la clase, variable del objeto.
    private int cantidadSumas;

    public Sumador(int cantidadSumas)
    {
      this.cantidadSumas = cantidadSumas;
    }

    public Sumador() : this(0) { }

    // Los métodos Sumar no deben ser estáticos, ya que sino no podrían interactuar con la variable del objeto cantsumas.
    public long Sumar(long a, long b)
    {
      this.cantidadSumas++;
      return a + b;
    }

    public string Sumar (string a, string b)
    {
      this.cantidadSumas++;
      return a + b;
    }

    public static explicit operator int(Sumador s)
    {
      return s.cantidadSumas;
    }

    public static long operator + (Sumador s, Sumador s2)
    {
      return (int)s + (int)s2;
    }

    public static bool operator | (Sumador s, Sumador ss)
    {
      return (int)s == (int)ss;
    }
  }
}
