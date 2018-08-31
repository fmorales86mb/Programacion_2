using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
    public class Conversor
    {
        public static string DecimalBinario(double valor)
        {
            string nroBinario = string.Empty;
            
            do
            {
                if (valor % 2 == 0) nroBinario += '0';
                else nroBinario += '1';
                    valor = valor / 2;
                
            } while (valor >= 2);

            return nroBinario;
        }

        public static double BinarioDecimal(string valor)
        {
            return 2;
        }
    }
}
