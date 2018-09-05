using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
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
    }
}
