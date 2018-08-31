using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaObjetos
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
        /// Solicita un double por consola.
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
        /// Solicita un texto alfabético por consola.
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

        /// <summary>
        /// Solicita letra por consola.
        /// </summary>
        /// <param name="mSolicitud"> Mensaje de solicitud.</param>
        /// <param name="mError">Mensaje de error.</param>
        /// <param name="c">referencia al char.</param>
        /// <returns>Validación del valor ingresado.</returns>
        public static bool PedirCharLetra(string mSolicitud, string mError, ref char c)
        {
            bool valido = false;
            char[] chars = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            Console.Write(mSolicitud);
            string linea = Console.ReadLine();
            char letra;

            if (!string.IsNullOrEmpty(linea) && linea.IndexOfAny(chars) < 0 && linea.Length == 1)
            {
                letra = (linea.ToCharArray(0, 1))[0];
                c = letra;
                valido = true;
            }
            else Console.WriteLine(mError);

            return valido;
        }

        /// <summary>
        /// Solicita char de entre una lista.
        /// </summary>
        /// <param name="mSolicitud"> Mensaje de solicitud.</param>
        /// <param name="mError">Mensaje de error.</param>
        /// <param name="chars">lista de caracteres posibles.</param>
        /// <param name="c">referencia al char.</param>
        /// <returns>Validación del valor ingresado.</returns>
        public static bool PedirCharAcotado(string mSolicitud, string mError, char[] chars, ref char c)
        {
            bool valido = false;

            Console.Write(mSolicitud);
            string linea = Console.ReadLine();
            char letra;

            if (!string.IsNullOrEmpty(linea) && linea.IndexOfAny(chars) >= 0 && linea.Length == 1)
            {
                letra = (linea.ToCharArray(0, 1))[0];
                c = letra;
                valido = true;
            }
            else Console.WriteLine(mError);

            return valido;
        }

        /// <summary>
        /// Solicita y evalua S o N para continuar.
        /// </summary>
        /// <param name="mSolicitud"> Mensaje de solicitud.</param>
        /// <param name="mError">Mensaje de error.</param>        
        /// <returns>Verdadero si se ingres s o S.</returns>
        public static bool PedirS_N(string mSolicitud, string mError)
        {
            bool valido = false;

            Console.Write(mSolicitud);
            string linea = Console.ReadLine();

            if (!string.IsNullOrEmpty(linea))
            {
                if (linea.ToUpper().Trim() == "S") valido = true;
            }
            else Console.WriteLine(mError);

            return valido;
        }
    }
}
