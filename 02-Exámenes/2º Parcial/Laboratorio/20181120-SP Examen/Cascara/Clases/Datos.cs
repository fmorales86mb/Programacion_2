using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Datos
    {
        private static string connectionString;

        static Datos()
        {
            connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog =parcial; Integrated Security = True";
        }

        public static void GuardarArribo(int id, DateTime arribo, string mensaje)
        {
            string strComand = string.Format("insert into dbo.trenes values({0}, '{1}', '{2}')",
                id.ToString(), arribo.ToString(), mensaje);

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand comand = new SqlCommand(strComand, con);

            try
            {
                con.Open();
                comand.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
    }
}
