using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IO
{
    class PuntoTxt : Archivo, IArchivos<string>
    {
        protected override bool ValidarArchivo(string ruta)
        {
            if (base.ValidarArchivo(ruta))
                if (Path.GetExtension(ruta) != ".txt")
                    throw new ArchivoIncorrectoException("El archivo no es correcto.");

            return true;
        }

        bool IArchivos<string>.Guardar(string ruta, string obj)
        {
            XmlTextWriter writer;
            XmlSerializer serializer;

            writer = new XmlTextWriter(ruta, null);
            serializer = new XmlSerializer(typeof(PuntoTxt));
            serializer.Serialize(writer, obj);

            writer.Close();

            return true;
        }

        string IArchivos<string>.Leer(string ruta)
        {
            PuntoTxt oPuntoTxt = new PuntoTxt();
            XmlTextReader reader;
            XmlSerializer serializer;

            reader = new XmlTextReader(ruta);
            serializer = new XmlSerializer(typeof(PuntoTxt));

            oPuntoTxt = (PuntoTxt)serializer.Deserialize(reader);
            reader.Close();

            return oPuntoTxt.ToString(); //ver
        }
    }
}
