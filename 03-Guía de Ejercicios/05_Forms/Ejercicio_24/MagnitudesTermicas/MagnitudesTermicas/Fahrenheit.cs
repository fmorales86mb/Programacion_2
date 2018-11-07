using System;
using System.Collections.Generic;
using System.Text;

namespace MagnitudesTermicas
{
    public class Fahrenheit
    {
        private double grados;

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }

        public Fahrenheit() : this(0) { }

        public double GetGrados() { return this.grados; }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            double grados = k.GetGrados() * 9 / 5 - 459.67;
            return new Fahrenheit(grados);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            double grados = c.GetGrados() * 9 / 5 + 32;
            return new Fahrenheit(grados);
        }
    }
}
