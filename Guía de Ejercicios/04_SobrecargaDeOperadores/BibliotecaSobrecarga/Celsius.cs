using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
{
    public class Celsius
    {
        private double grados;

        public Celsius(double grados)
        {
            this.grados = grados;
        }

        public Celsius() : this(0) { }

        public double GetGrados() { return this.grados; }
        
        public static explicit operator Celsius(Fahrenheit f)
        {
            double grados = (f.GetGrados() - 32) * 5 / 9;
            return new Celsius(grados);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return ((Celsius)((Fahrenheit)k)); // chequear
        }


    }
}
