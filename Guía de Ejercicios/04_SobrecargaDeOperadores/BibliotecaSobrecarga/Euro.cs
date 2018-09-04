using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {
            cotizRespectoDolar = (float)1.3642;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotiz)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotiz;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return d.GetCantidad() / Euro.GetCotizacion();
        }
        
        public static explicit operator Euro(Peso p)
        {
            return ((Dolar)p).GetCantidad() / Euro.GetCotizacion();
        }

        public static implicit operator Euro(double cant)
        {
            return new Euro(cant);
        }

        public static bool operator == (Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return e != (Euro)d;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e == (Euro)p;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return e != (Euro)p;
        }

        public static bool operator ==(Euro e, Euro e2)
        {
            return (e.GetCantidad() == e2.GetCantidad());
        }
        public static bool operator !=(Euro e, Euro e2)
        {
            return (e.GetCantidad() != e2.GetCantidad());
        }

        public static Euro operator + (Euro e, Dolar d)
        {
            return e.GetCantidad() + ((Euro)d).GetCantidad();
        }

        public static Euro operator - (Euro e, Dolar d)
        {
            return e.GetCantidad() - ((Euro)d).GetCantidad();
        }

        public static Euro operator + (Euro e, Peso p)
        {
            return e.GetCantidad() + ((Euro)p).GetCantidad();
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return e.GetCantidad() - ((Euro)p).GetCantidad();
        }
    }
}
