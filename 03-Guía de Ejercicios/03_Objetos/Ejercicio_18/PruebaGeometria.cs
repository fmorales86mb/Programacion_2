using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaObjetos;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_18";

            Punto pto1 = new Punto(0, 0);
            Punto pto3 = new Punto(3, 1);
            Rectangulo objRectangulo = new Rectangulo(pto1, pto3);

            Console.WriteLine("Área: " + objRectangulo.Area().ToString());
            Console.WriteLine("Perímetro: " + objRectangulo.Perimetro().ToString());

            Console.ReadKey();
        }

        public static void clase (Rectangulo objRectangulo)
        {
            Console.WriteLine("Área: " + objRectangulo.Area().ToString());
            Console.WriteLine("Perímetro: " + objRectangulo.Perimetro().ToString());
            //Console.WriteLine(string.Format("Vértice 1: {0},{1}", objRectangulo.)
        }
    }
}
