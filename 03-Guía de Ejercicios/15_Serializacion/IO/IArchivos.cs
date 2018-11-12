using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public interface IArchivos<T>
    {
        bool Guardar(string ruta, T obj);
        T Leer(string ruta);
    }
}
