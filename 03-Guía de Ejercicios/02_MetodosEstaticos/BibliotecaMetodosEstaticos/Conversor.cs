using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
    public class Conversor
    {
        /* 
         * Falta pulir el código.
         * Se pueden extraer varios métodos privados.
         */

        /// <summary>
        /// Convierte un número decimal a su equivalente binario.
        /// </summary>
        /// <param name="valor">Decimal a convertir.</param>
        /// <returns>Binario en formato string.</returns>
        public static string DecimalBinario(double valor)
        {
            string nroBinario = string.Empty;
            bool esNegativo = valor < 0;
            if (esNegativo) valor *= -1;
            double nroAux;
            int enteroAux;
            int valEntero = (int)valor;
            double valFrac = valor - valEntero;

            // Parte entera.  
            if (valEntero == 0) nroBinario = "0";
            else
            {
                while (valEntero > 0)
                {
                    if (valEntero % 2 == 0) nroBinario = "0" + nroBinario; //ingreso los nros como pila.
                    else nroBinario = "1" + nroBinario;
                    valEntero = (int)(valEntero / 2); // tomo la parte entera                
                }
            }

            // Parte fraccional            
            if (valFrac!=0)
            {
                nroBinario += ","; // ingreso como cola

                for (int i = 0; i < 3; i++)
                {
                    nroAux = valFrac * 2;
                    enteroAux = (int)nroAux;
                    valFrac = nroAux - enteroAux;

                    nroBinario += enteroAux.ToString();
                }
            }

            if (esNegativo) nroBinario = "-" + nroBinario;
            return nroBinario;
        }

        /// <summary>
        /// Convierte un número binario a decimal.
        /// </summary>
        /// <param name="valor">String con el valor sin espacios y con '.' preparando parte fraccional de entera.</param>
        /// <returns>Decimal equivalente.</returns>
        public static double BinarioDecimal(string valor)
        {
            int acumuladorEntero = 0;
            bool esNegativo = valor.StartsWith("-");
            double acumuladorFraccional = 0;
            int nro;
            int factorProducto;
            int j;        

            string[] enteroFraccional = valor.Split('.');
            j = enteroFraccional[0].Length - 1;

            // Parte entera.
            for (int i = 0; i<enteroFraccional[0].Length; i++, j--)
            {
                // voy de derecha a izquierda. El factor arranca en 1 con i = 0
                factorProducto = (int)Math.Pow(2, i); 
                
                // La toma de dígitos es de derecha a izquierda. con j igual al último índice del string.
                if (int.TryParse((enteroFraccional[0][j]).ToString(), out nro))
                {
                    acumuladorEntero += nro * factorProducto;
                }              
            }
            
            // Parte Fraccional.
            if (enteroFraccional.GetLength(0)==2) //Chequeo que exista el índice 1.
            {
                for (int i = 0; i < enteroFraccional[1].Length; i++)
                {
                    factorProducto = (int)Math.Pow(2, i + 1);

                    if (int.TryParse(enteroFraccional[1][i].ToString(), out nro))
                    {
                        acumuladorFraccional += (double)nro / factorProducto;
                    }
                    else
                    {
                        acumuladorFraccional = 0;
                        break;
                    }
                }
            }
            
            return esNegativo ? (acumuladorEntero + acumuladorFraccional) * (-1) : acumuladorEntero + acumuladorFraccional;
        }
    }
}
