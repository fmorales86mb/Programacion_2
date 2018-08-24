using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGuiaEjercicios

{
    public class ConceptosBasicos
    {
        /// <summary>
        /// Evalua si el nro es primo.
        /// </summary>
        /// <param name="nro">Entero mayor a cero.</param>
        /// <returns></returns>
        public static bool IsPrimo(int nro)
        {
            bool isPrimo = true;

            if (nro == 1) isPrimo = false;

            for (int i = 2; i < nro; i++)
            {
                if (nro % i == 0)
                {
                    isPrimo = false;
                    break;
                }
            }

            return isPrimo;
        }

        /// <summary>
        /// Evalua si el nro es perfecto.
        /// </summary>
        /// <param name="nro">Entero positivo.</param>
        /// <returns></returns>
        public static bool IsPerfecto(int nro)
        {
            bool isPerfecto;
            int acumulador = 0;

            for (int i = 1; i < nro; i++)
            {
                if (nro % i == 0) acumulador += i;
            }

            isPerfecto = acumulador == nro ? true : false;

            return isPerfecto;
        }

        /// <summary>
        /// Evalua si el nro es centro numérico.
        /// </summary>
        /// <param name="acumuladoIz">Sumatoria de 1 al nro no inclusive.</param>
        /// <param name="nro">Número a evaluar</param>
        /// <param name="max">Último valor a la derecha del nro a evaluar.</param>
        /// <returns></returns>
        public static bool IsCentroNumerico(int acumuladoL, int nro, int max)
        {
            bool isCentro = false;
            int acumuladoR = 0;

            for (int i = nro + 1; i < max; i++)
            {
                acumuladoR += i;
                if (acumuladoL <= acumuladoR) break;
            }

            if (acumuladoL == acumuladoR) isCentro = true;

            return isCentro;
        }

        /// <summary>
        /// Evalua si un nro es bisiesto.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool IsBisiesto(int year)
        {
            bool isBisiesto = false;

            if (year % 400 == 0) isBisiesto = true;
            else if (year % 4 == 0 && !(year % 100 == 0)) isBisiesto = true;

            return isBisiesto;
        }
    }
}
