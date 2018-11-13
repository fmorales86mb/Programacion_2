using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class AlumnoDB
    {
        public List<Alumno> Traer()
        {
            // se puede poner en el constructor
            List<Alumno> lista = new List<Alumno>();

            SqlConnection con = new SqlConnection(DBcon.StrConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = con;
            comando.CommandText = "select * from dbo.alumnos";

            Alumno alum;

            try
            {
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    alum = new Alumno();

                    alum.Apellido = reader["apellido"].ToString();
                    alum.Nombre = reader["nombre"].ToString();

                    lista.Add(alum);
                }

                con.Close();
            }
            catch (Exception e)
            {

            }

            return lista;
        }
    }
}
