using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


/*
 * Atajos:
 * Ctrl + k + s
 * ctor + tab + tab
 * prop + tab + tab
*/

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {
        private static string StrConnection;
        private static SqlConnection Con;        

        static Dao()
        {
            StrConnection = @"Data Source =.\SQLEXPRESS; Initial Catalog =votacion-sp-2018; Integrated Security = True";
            Con = new SqlConnection(StrConnection);
        }

        public bool Guardar(string rutaArchivo, Votacion objeto)
        {
            bool guardado = false;
            string query = string.Format("insert into dbo.Votaciones values ('{0}', {1},{2},{3},'MoralesFederico')",
                objeto.NombreLey, objeto.ContadorAfirmativo, objeto.ContadorNegativo, objeto.ContadorAbstencion);
            SqlCommand command = new SqlCommand(query, Con);

            try
            {
                Con.Open();
                if (command.ExecuteNonQuery() > 0)
                    guardado = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (Con.State != System.Data.ConnectionState.Closed)
                    Con.Close();
            }

            return guardado;
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new System.NotImplementedException();
        }
    }
}
