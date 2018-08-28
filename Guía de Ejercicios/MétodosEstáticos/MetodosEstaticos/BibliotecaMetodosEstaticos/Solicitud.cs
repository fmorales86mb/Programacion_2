using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
    public class Solicitud
    {
        /// <summary>
        /// Solicita un entero por consola.
        /// </summary>
        /// <param name="mSolicitud"> Mensaje de solicitud.</param>
        /// <param name="mError">Mensaje de error.</param>
        /// <param name="nro">referencia al entero.</param>
        /// <returns>Validación del valor ingresado.</returns>
        public static bool PedirEntero(string mSolicitud, string mError, ref int nro)
        {
            bool valido = false;

            Console.Write(mSolicitud);
            string linea = Console.ReadLine();

            if (!string.IsNullOrEmpty(linea)) valido = int.TryParse(linea, out nro);
            if (!valido) Console.WriteLine(mError);

            return valido;
        }

        /// <summary>
        /// Solicita valor por consola.
        /// </summary>
        /// <param name="mSolicitud"> Mensaje de solicitud.</param>
        /// <param name="mError">Mensaje de error.</param>
        /// <param name="nro">referencia al double.</param>
        /// <returns>Validación del valor ingresado.</returns>
        public static bool PedirDouble(string mSolicitud, string mError, ref double nro)
        {
            bool valido = false;

            Console.Write(mSolicitud);
            string linea = Console.ReadLine();

            if (!string.IsNullOrEmpty(linea)) valido = double.TryParse(linea, out nro);
            if (!valido) Console.WriteLine(mError);

            return valido;
        }

        /// <summary>
        /// Solicita valor por consola.
        /// </summary>
        /// <param name="mSolicitud"> Mensaje de solicitud.</param>
        /// <param name="mError">Mensaje de error.</param>
        /// <param name="texto">referencia al string.</param>
        /// <returns>Validación del valor ingresado.</returns>
        public static bool PedirSoloLetras(string mSolicitud, string mError, ref string texto)
        {
            bool valido = false;
            char[] chars = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            Console.Write(mSolicitud);
            string linea = Console.ReadLine();

            if (!string.IsNullOrEmpty(linea) && linea.IndexOfAny(chars) < 0)
            {
                texto = linea;
                valido = true;
            }
            else Console.WriteLine(mError);

            return valido;
        }
    }
}
