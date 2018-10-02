using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        //private short cantidadRuedas;
        //private short cantidadPuertas;
        //private short cantidadMarchas;        
        private int pesoCarga;
        //private Colores color;

        public Camion(short cantRuedas, short cantPuertas, short cantMarchas, int pesoCarga, 
            Colores color) : base(cantRuedas, cantPuertas, cantMarchas, color)
        {
            this.pesoCarga = pesoCarga;            
        }
        
    }
}
