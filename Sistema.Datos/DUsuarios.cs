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

        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("usuario_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public bool Insert(string name, string lastname, string username, string email, string contra)
        {
            //missing part to get type of book
            bool inserted = false;

            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                 new SqlParameter("@firstname", SqlDbType.VarChar) {
                    Value = name
                },
                 new SqlParameter("@lastname", SqlDbType.VarChar) {
                    Value = lastname
                },
                 new SqlParameter("@username", SqlDbType.VarChar) {
                    Value = username
                },
                 new SqlParameter("@email", SqlDbType.VarChar) {
                    Value = email
                },
                  new SqlParameter("@psswd", SqlDbType.VarChar) {
                    Value = contra
                },
            };

            try
            {
                conn = Conexion.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("usuario_crear", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                conn.Open();

                inserted = cmd.ExecuteNonQuery() == 1;

            }
            catch (Exception)
            {
                throw;
            }

            return inserted;

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
