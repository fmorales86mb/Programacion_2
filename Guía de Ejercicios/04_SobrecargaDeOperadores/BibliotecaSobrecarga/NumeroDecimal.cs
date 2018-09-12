using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static double operator +(NumeroDecimal dec, NumeroBinario bin)
        {
            return dec.numero + Conversor.BinarioDecimal((string)bin);
        }

        public static double operator -(NumeroDecimal dec, NumeroBinario bin)
        {
            return dec.numero - Conversor.BinarioDecimal((string)bin);
        }

        public static bool operator == (NumeroDecimal dec, NumeroBinario bin)
        {
            return dec.numero == Conversor.BinarioDecimal((string)bin);
        }

        public static bool operator !=(NumeroDecimal dec, NumeroBinario bin)
        {
            return !(dec == bin);
        }

        public static implicit operator NumeroDecimal(double val)
        {
            return new NumeroDecimal(val);
        }

        public static explicit operator double (NumeroDecimal dec)
        {
            return dec.numero;
        }
    }
}
