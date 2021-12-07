using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class Dpregunta
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("pregunta_list_all", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listar_Mispreguntas(int user_id)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            SqlParameter[] param = {
                 new SqlParameter("@user_id", SqlDbType.VarChar) {
                    Value = user_id
                } };
            try
            {
                SqlCon = Conexion.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("Mipregunta_list_all", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddRange(param);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        
        public bool Insert_pregunta(string titulo, string descripcion, int estado, int user_id)
        {
            
            bool inserted = false;
            DateTime myDateTime = DateTime.Now;
            string fecha = myDateTime.ToString("yyyy-MM-dd");

            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                 new SqlParameter("@titulo", SqlDbType.VarChar) {
                    Value = titulo
                },
                 new SqlParameter("@descripcion", SqlDbType.VarChar) {
                    Value = descripcion
                },
                 new SqlParameter("@fecha", SqlDbType.VarChar) {
                    Value = fecha
                },
                 new SqlParameter("@user_id", SqlDbType.VarChar) {
                    Value = user_id
                },
                  
                  new SqlParameter("@estado", SqlDbType.Int){
                    Value= estado
                }
            };

            try
            {
                conn = Conexion.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("crear_pregunta", conn);
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
    }
}
