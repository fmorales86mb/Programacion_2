using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
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
                if (Path.GetExtension(ruta) == ".dat") ;
                    //throw 

            return true;
        }

        bool IArchivos<PuntoDat>.Guardar(string ruta, PuntoDat obj)
        {
            throw new NotImplementedException();
        }

        PuntoDat IArchivos<PuntoDat>.Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
