using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class DRespuesta
    {
        public DataTable Buscar_respuestas(int quest_id)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("verRespuestasId", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@answer_id", SqlDbType.Int).Value = quest_id;
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


        public bool Insert_respuesta(string descripcion, string username, int quest_id)
        {

            bool inserted = false;
            DateTime myDateTime = DateTime.Now;
            string fecha = myDateTime.ToString("yyyy-MM-dd");

            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                 
                 new SqlParameter("@descripcion", SqlDbType.VarChar) {
                    Value = descripcion
                },
                 new SqlParameter("@fecha", SqlDbType.VarChar) {
                    Value = fecha
                },
                 new SqlParameter("@username", SqlDbType.VarChar) {
                    Value = username
                },

                  new SqlParameter("@quest_id", SqlDbType.Int){
                    Value= quest_id
                }
            };

            try
            {
                conn = Conexion.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("crear_respuesta", conn);
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

        public string Posible(int id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("respuesta_posible", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
    }

}
