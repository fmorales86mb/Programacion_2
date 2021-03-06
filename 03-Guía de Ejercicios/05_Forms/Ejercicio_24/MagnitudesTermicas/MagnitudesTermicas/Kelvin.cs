﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MagnitudesTermicas
{
    public class Kelvin
    {
        private double grados;

        public Kelvin() : this(0) { }        

        public Kelvin(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return this.grados;
        }

        //public static double GetCelcius(double grados)
        //{
        //    return (grados - 32) * 5 / 9;
        //}

        public static implicit operator Kelvin(double grados)
        {
            return new Kelvin(grados);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            double grados = (f.GetGrados() + 459.67) * 5 / 9;
            return new Kelvin(grados);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return ((Kelvin)((Fahrenheit)c));
        }

        
        




    }
}
