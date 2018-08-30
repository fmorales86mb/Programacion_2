using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area = -1;
        private float perimetro = -1;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {
            if (this.area < 0)
            {
                int base_ = Math.Abs(vertice1.GetX() - vertice2.GetX());
                int h = Math.Abs(vertice1.GetY() - vertice4.GetY());
                return base_ * h;
            }
            else
            {
                return this.area;
            }            
        }

        public float Perimetro()
        {
            if (this.perimetro < 0)
            {
                int base_ = Math.Abs(vertice1.GetX() - vertice2.GetX());
                int h = Math.Abs(vertice1.GetY() - vertice4.GetY());
                return 2 * (base_ + h);
            }
            else
            {
                return this.perimetro;
            }
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {           
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());            
        }        
    }
}
