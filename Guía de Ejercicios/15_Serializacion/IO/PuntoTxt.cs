using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class PuntoTxt : Archivo, IArchivos<string>
    {
        bool IArchivos<string>.Guardar(string ruta, string obj)
        {
            throw new NotImplementedException();
        }

        string IArchivos<string>.Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
