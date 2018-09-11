using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {
            cotizRespectoDolar = 1;
        }

        // Acá reutilizo el código donde seteo la cotizacion
        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        // Al cotizacion ser estático no conviene llamar y pisarlo nuevamente. Otro objeto la puede estar usando
        // y puede quedar en el medio con un valor erroneo.
        public Dolar(double cant, float cotiz)// : this(cant)
        {
            this.cantidad = cant;
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

        public static explicit operator Dolar(Euro e)
        {
            return e.GetCantidad() * Euro.GetCotizacion();
        }

        public static explicit operator Dolar(Peso p)
        {
            return p.GetCantidad() * Peso.GetCotizacion();
        }

        public static implicit operator Dolar(double cant)
        {
            return new Dolar(cant);
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return dolar != (Dolar)euro;
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return dolar == (Dolar)euro;
        }

        public static bool operator !=(Dolar dolar, Peso peso)
        {
            return dolar != (Dolar)peso;
        }

        public static bool operator ==(Dolar dolar, Peso peso)
        {
            return dolar == (Dolar)peso;
        }

        public static bool operator !=(Dolar dolar, Dolar dolar2)
        {
            return dolar.GetCantidad() != dolar2.GetCantidad();
        }

        public static bool operator ==(Dolar dolar, Dolar dolar2)
        {
            return dolar.GetCantidad() == dolar2.GetCantidad();
        }

        public static Dolar operator + (Dolar d, Euro e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d.GetCantidad() - ((Dolar)e).GetCantidad();
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return d.GetCantidad() + ((Dolar)p).GetCantidad();
        }

        public static Dolar operator -(Dolar d, Peso p )
        {
            return d.GetCantidad() - ((Dolar)p).GetCantidad();
        }        
    }
}
