using Excepciones;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            bool guardado = true;
            XmlSerializer serializer;
            XmlTextWriter writer = null;


            if (File.Exists(rutaArchivo) && Path.GetExtension(rutaArchivo) == ".xml")
            {
                try
                {
                    writer = new XmlTextWriter(rutaArchivo, Encoding.ASCII);
                    serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, objeto);
                }
                catch (Exception e)
                {                    
                    throw new ErrorArchivoException("Error al serializar el objeto.");
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                } 
            }
            else
            {
                guardado = false;
            }

            return guardado;
        }

        //Leer retornará un elemento del tipo T leído desde el archivo ubicado en rutaArchivo.
        public T Leer(string rutaArchivo)
        {
            object aux = null;
            XmlSerializer serializer;
            XmlTextReader reader = null;

            if (File.Exists(rutaArchivo) && Path.GetExtension(rutaArchivo) == ".xml")
            {
                try
                {
                    reader = new XmlTextReader(rutaArchivo);
                    serializer = new XmlSerializer(typeof(T));
                    aux = (T)serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    throw new ErrorArchivoException("Error al desserializar el objeto.");
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                } 
            }            

            return (T)aux;
        }
    }
}
