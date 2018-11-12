using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        //private short cantidadRuedas;
        //private short cantidadPuertas;        
        //private Colores color;
        private short cilindrada;

        public Moto(short cantRuedas, short cantPuertas, Colores color,
            short cilindrada) : base(cantRuedas, cantPuertas, 0, color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
