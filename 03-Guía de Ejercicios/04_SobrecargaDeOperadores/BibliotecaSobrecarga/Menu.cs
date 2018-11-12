using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSobrecarga
{
    public class Menu
    {
        public static string CrearMenu (string[]opciones, string titulo)
        {
            StringBuilder menu = new StringBuilder();

            menu.AppendFormat("---- {0} ----", titulo);
            menu.AppendLine();
            
            for (int i = 0; i<opciones.Length; i++)
            {
                menu.AppendLine();
                menu.AppendFormat("·{0}) {1}.", i + 1, opciones[i]);
            }
            menu.AppendLine();

            return menu.ToString();
        }
    }
}
