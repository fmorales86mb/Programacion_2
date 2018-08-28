using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosEstaticos
{
  public class ValidarRespuesta
  {
    public static bool ValidaS_N(char c)
    {
      bool isS = false;
      if (c == 'S') isS = true;
      return isS;
    }
  }
}
