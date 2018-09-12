using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSobrecarga
{
    public class Conversor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string DecimalBinario(double valor)
        {
            string nroBinario = string.Empty;
            
            do
            {
                if (valor % 2 == 0) nroBinario += '0';
                else nroBinario += '1';

                valor = (int)(valor / 2); // tomo la parte entera
                
            } while (valor >= 2);

            return nroBinario;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static double BinarioDecimal(string valor)
        {
            double acumulador = 0;            
            int nro;
            double factorProducto;
            int j = valor.Length -1;

            for(int i = 0; i<valor.Length; i++, j--)
            {
                // voy de derecha a izquierda. El factor arranca en 1 con i = 0
                factorProducto = Math.Pow(2, i); 

                // La toma de dígitos es de derecha a izquierda. con j igual al último índice del string.
                if (int.TryParse(valor[j].ToString(), out nro))
                {
                    acumulador += nro * factorProducto;
                }
                else
                {
                    acumulador = 0;
                    break;
                }
            }

            return acumulador;
        }
    }
}
