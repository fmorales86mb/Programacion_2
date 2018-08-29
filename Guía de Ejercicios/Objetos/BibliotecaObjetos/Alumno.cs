using System;
using System.Text;

namespace BibliotecaObjetos
{
  public class Alumno
  {
    private byte nota1;
    private byte nota2;
    private float notaFinal;

    public string apellido;
    public string nombre;
    public int legajo;

    public void CalcularFinal()
    {
      if (nota1 >= 4 && nota2 >= 4)
      {
        notaFinal = new Random().Next();
      }
      else notaFinal = -1;
    }

    public void Estudiar(byte notaUno, byte notaDos)
    {
      nota1 = notaUno;
      nota2 = notaDos;
    }

    public string Mostrar()
    {     
      StringBuilder sb = new StringBuilder();

      sb.AppendFormat("Nombre: {0}", nombre);
      sb.AppendLine();
      sb.AppendFormat("Apellido: {0}", apellido);
      sb.AppendLine();
      sb.AppendFormat("Legajo: {0}", legajo.ToString());
      sb.AppendLine();
      sb.AppendFormat("Nota Final: {0}", notaFinal > -1? notaFinal.ToString(): "Alumno desaprobado");

      return sb.ToString();
    }

    public Alumno(string nom, string ape, int leg)
    {
      nombre = nom;
      apellido = ape;
      legajo = leg;
    }
  }
}
