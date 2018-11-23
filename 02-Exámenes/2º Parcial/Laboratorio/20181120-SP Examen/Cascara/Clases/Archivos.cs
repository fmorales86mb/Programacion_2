using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Archivos
    {
        private static StreamReader streamReader;
        private static StreamWriter streamWriter;        

        //lo tiene que leer completo??
        public static bool Guardar(string path, string mensaje)
        {
            streamWriter = null;
            bool guardado = true;
            //string aux = string.Empty;

            try
            {
                //Archivos.Leer(path, out aux);
                streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine(mensaje);
            }
            catch(Exception ex)
            {
                
                guardado = false;
                throw ex;
            }
            finally
            {
                streamWriter.Close();
            }                                    

            return guardado;
        }

        public static bool Leer(string path, out string mensaje)
        {
            bool leido = false;
            streamReader = null;
            mensaje = string.Empty;

            if (File.Exists(path))
            {
                try
                {
                    streamReader = new StreamReader(path);
                    mensaje = streamReader.ReadToEnd();
                    leido = true;
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    streamReader.Close();
                } 
            }
            
            return leido;
        }
    }
}
