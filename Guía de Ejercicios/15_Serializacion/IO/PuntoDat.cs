using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return contenido;
            }
            set
            {
                contenido = value;
            } 
        }

        protected override bool ValidarArchivo(string ruta)
        {
            if (base.ValidarArchivo(ruta))
                if (Path.GetExtension(ruta) == ".dat") 
                    throw new ArchivoIncorrectoException("El archivo no es un dat.");

            return true;
        }

        bool IArchivos<PuntoDat>.Guardar(string ruta, PuntoDat obj)
        {
            FileStream fs;
            BinaryFormatter ser;

            fs = new FileStream(ruta, FileMode.Create);
            ser = new BinaryFormatter();

            ser.Serialize(fs, obj);
            fs.Close();

            return true;
        }

        PuntoDat IArchivos<PuntoDat>.Leer(string ruta)
        {
            PuntoDat oPuntoDat = new PuntoDat();
            FileStream fs;
            BinaryFormatter ser;

            fs = new FileStream(ruta, FileMode.Open);
            ser = new BinaryFormatter();

            oPuntoDat = (PuntoDat)ser.Deserialize(fs);            

            return oPuntoDat;
        }
    }
}
