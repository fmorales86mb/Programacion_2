using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
  public class Estante
  {
    private Producto[] productos;
    private int ubicacionEstante;

    private Estante(int capacidad)
    {
      productos = new Producto[capacidad];
    }

    public Estante (int capacidad, int ubicacion):this(capacidad)
    {
      this.ubicacionEstante = ubicacion;
    }

    public Producto[] GetProductos()
    {
      return this.productos;
    }

    // Es estàtico ya que le tengo que pasar un objeto de la clase. Si no recibiera parámetros, podría no ser estático.
    public static string MostrarEstante(Estante e)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(string.Format("Estante nro {0}",e.ubicacionEstante.ToString()));
      
      for (int i = 0; i < e.GetProductos().Length; i++)
      {        
        sb.AppendLine(Producto.MostrarProducto(e.GetProductos()[i]));
        sb.AppendLine();
      }

      return sb.ToString();
    }

    public static bool operator ==(Estante e, Producto p)
    {
      bool yaExiste = false;

      for (int i = 0; i<e.GetProductos().Length; i++)
      {
        if(e.GetProductos()[i] == p)
        {
          yaExiste = true;
          break;
        }
      }

      return yaExiste;
    }

    // True si p no está en el estante. False si está p en el estante.
    public static bool operator !=(Estante e, Producto p)
    {
      return !(e == p); // reutilizar código.

      //bool noExiste = true;

      //for (int i = 0; i < e.GetProductos().Length; i++)
      //{
      //  if (e.GetProductos()[i] == p)
      //  {
      //    noExiste = false;
      //    break;
      //  }
      //}

      //return noExiste;
    }

    /// <summary>
    /// Adición
    /// </summary>
    /// <param name="e"></param>
    /// <param name="p"></param>
    /// <returns>retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y dicho producto no se encuentra en él; </returns>
    public static bool operator +(Estante e, Producto p)
    {
      bool agregado = false;      
      
      if (e != p)
      {
        for (int i = 0; i < e.GetProductos().Length; i++)
        {
          if (e.GetProductos()[i] is null)
          {
            e.GetProductos()[i] = p;
            agregado = true;
            break;
          }
        }
      }

      return agregado;      
    }

    /// <summary>
    /// Sustracción
    /// </summary>
    /// <param name="e"></param>
    /// <param name="p"></param>
    /// <returns> retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado</returns>
    public static Estante operator -(Estante e, Producto p)
    {
      Estante estante = new Estante(e.GetProductos().Length);
      estante = e;

      if (estante == p)
      {
        for(int i= 0; i<estante.GetProductos().Length; i++)
        {
          if (p == estante.GetProductos()[i])
          {
            estante.GetProductos()[i] = null;
            break;
          }
        }
      }

      return estante;
    }
  }
}
