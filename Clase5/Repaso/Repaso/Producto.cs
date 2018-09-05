using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
  public class Producto
  {
    private string codigoDeBarra;
    private string marca;
    private float precio;

    public Producto(string marca, string codigo, float precio)
    {
      this.marca = marca;
      this.codigoDeBarra = codigo;
      this.precio = precio;
    }

    public string GetMarca()
    {
      return this.marca;
    }

    public float GetPrecio()
    {
      return this.precio;
    }

    // Es estàtico ya que le tengo que pasar un objeto de la clase. Si no recibiera parámetros, podría no ser estático.
    public static string MostrarProducto (Producto p)
    {
      string retorno;
      if (p is null) retorno = string.Empty; 
      else
      {
        retorno = string.Format("Marca: {0}\nCódigo de barra: {1}\nPrecio: {2}",
        p.GetMarca(), (string)p, p.GetPrecio().ToString());
      }
      return retorno;
    }

    public static explicit operator string (Producto p)
    {
      string retorno;
      if (p is null) retorno = string.Empty;
      else
      {
        retorno = p.codigoDeBarra;
      }
      return retorno; 
    }

    public static bool operator == (Producto p, string marca)
    {
      bool esIgual;

      if (p is null || string.IsNullOrEmpty(marca)) esIgual = false;
      else esIgual = (p.GetMarca() == marca);

      return esIgual; 
    }

    public static bool operator !=(Producto p, string marca)
    {
      return !(p == marca);

      //return (p.GetMarca() != marca);
    }

    public static bool operator ==(Producto p, Producto p2)
    {
      bool iguales;

      if (p is null || p2 is null) iguales = false;
      else
      {
        iguales = (p.GetMarca() == p2.GetMarca() && (string)p == (string)p2);
      }

      return iguales;
    }

    public static bool operator !=(Producto p, Producto p2)
    {
      return !(p == p2);
      //return (p.GetMarca() != p2.GetMarca() || (string)p != (string)p2);
    }

  }
}
