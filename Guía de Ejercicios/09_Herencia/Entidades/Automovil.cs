using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{   
    public class Automovil : VehiculoTerrestre
    {
        //private short cantidadRuedas;
        //private short cantidadPuertas;
        //private short cantidadMarchas;
        private short cantidadPasajeros;        
        //private Colores color;

        public Automovil(short cantRuedas, short cantPuertas, short cantMarchas, 
            short cantPasajeros, Colores color) : base(cantRuedas, cantPuertas, cantMarchas, color)
        {            
            this.cantidadPasajeros = cantPasajeros;         
        }        
    }
}
