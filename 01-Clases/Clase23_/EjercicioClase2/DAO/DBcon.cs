using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DBcon
    {
        private static string strConexion = "Data Source =[SQLEXPRESS]; Initial Catalog =[dbEjercicio]; Integrated Security = True";

        public static string StrConexion
        {
            get
            {
                return strConexion;
            }
        }
    }
}
