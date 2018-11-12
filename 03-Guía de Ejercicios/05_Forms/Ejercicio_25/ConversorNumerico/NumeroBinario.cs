using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorNumerico
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static string operator +(NumeroBinario bin, NumeroDecimal dec)
        {
            string resultado = Conversor.DecimalBinario(Conversor.BinarioDecimal(bin.numero) + (double)dec);
            return resultado;
        }

        public static string operator -(NumeroBinario bin, NumeroDecimal dec)
        {
            string resultado = Conversor.DecimalBinario(Conversor.BinarioDecimal(bin.numero) - (double)dec);
            return resultado;
        }

        public static bool operator == (NumeroBinario bin, NumeroDecimal dec)
        {
            return Conversor.BinarioDecimal(bin.numero) == (double)dec;
        }

        public static bool operator !=(NumeroBinario bin, NumeroDecimal dec)
        {
            return !(bin == dec);
        }

        public static implicit operator NumeroBinario (string strBin)
        {
            return new NumeroBinario(strBin);
        }

        public static explicit operator string(NumeroBinario bin)
        {
            return bin.numero;
        }
    }
}
