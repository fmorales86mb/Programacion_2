using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro,
    }

    public class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected short cantidadMarchas; // va en el padre o en los hijos?
        //protected short cantidadPasajeros;
        //private int pesoCarga;
        protected Colores color;
        //private short cilindrada;

        protected VehiculoTerrestre(short cantRuedas, short cantPuertas, short cantMarchas, Colores color)
        {
            this.cantidadRuedas = cantRuedas;
            this.cantidadPuertas = cantPuertas;
            this.cantidadMarchas = cantMarchas;
            this.color = color;
        }
    }
}
