using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
{
    public class Peso
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Peso()
        {
            cotizRespectoDolar = (float)(1 / 17.55);
        }

        public Peso(double cant) : this()
        {
            this.cantidad = cant;
        }

        public Peso(double cant, float cotiz)
        {
            this.cantidad = cant;
            cotizRespectoDolar = cotiz;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Peso(Euro e)
        {
            return new Peso( ((Dolar)e).GetCantidad() / Peso.GetCotizacion() );
        }

        public static explicit operator Peso (Dolar d)
        {
            return new Peso(d.GetCantidad() / Peso.GetCotizacion());
        }

        public static implicit operator Peso(double cant)
        {
            return new Peso(cant);
        }

        public static Peso operator + (Peso p, Dolar d)
        {
            return p.GetCantidad() + ((Peso)d).GetCantidad();
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return p.GetCantidad() - ((Peso)d).GetCantidad();
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return p.GetCantidad() + ((Peso)e).GetCantidad();
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return p.GetCantidad() + ((Peso)e).GetCantidad();
        }

        public static bool operator == (Peso p, Peso p2)
        {
            return (p.GetCantidad() == p2.GetCantidad());
        }

        public static bool operator !=(Peso p, Peso p2)
        {
            return (p.GetCantidad() != p2.GetCantidad());
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return p == (Peso)d;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return p != (Peso)d;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return p == (Euro)e;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return p != (Euro)e;
        }        
    }
}
