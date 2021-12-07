using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Sistema.Datos
{
    public class DUsuarios
    {
        public Usuarios SignIn(string username, string password)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@username", SqlDbType.VarChar)
                {
                    Value = username
                },
                new SqlParameter("@password", SqlDbType.VarChar)
                {
                    Value = password
                }
            };

            try
            {
                connection = Conexion.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("usuarios_login", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddRange(parameters);
                connection.Open();

                result = command.ExecuteReader();

                table.Load(result);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                return new Usuarios()
                {
                    UsersId = row.Field<int>("users_id"),
                    FirstName = row.Field<string>("first_name"),
                    LastName = row.Field<string>("last_name"),
                    Email = row.Field<string>("email")
                    
                };
            }
            else
            {
                return Usuarios.EmptyUser();
            }
        }

        public DataTable List()
        {

            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("usuarios_list_all", conn);
                command.CommandType = CommandType.StoredProcedure;

                conn.Open();

                result = command.ExecuteReader();
                table.Load(result);
                return table;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
        }

        public DataTable getOne(int id)
        {

            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                 new SqlParameter("@id", SqlDbType.Int) {
                    Value = id
                }, 
            };

            try
            {
                conn = Conexion.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("usuario_getOne", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(param);

                conn.Open();

                result = command.ExecuteReader();
                table.Load(result);
                return table;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
        }

        public void BeginSession(Usuarios user)
        {
            ManejodeSesion.GetInstance().BeginSession(user);
        }

        public void ExpireSession()
        {
            ManejodeSesion.GetInstance().ExpireSession();
        }

        public bool GetUserSessionRole()
        {
            return Convert.ToBoolean(ManejodeSesion.GetInstance().GetSessionProperty("role"));
        }





    }
}
