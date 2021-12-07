using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    class Conexion
    {

        private string dbName;
        private string serverName;
        private string dbUser;
        private string dbKeyCode;
        private bool dbSecurity;
        private static Conexion instance = null;

        private Conexion()
        {
            
            
            this.dbName = "forumBD";
            this.serverName = "PAVILION16"; 
            this.dbUser = "sa";
            this.dbKeyCode = "1234";
            this.dbSecurity = true; 
           
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = "Server=" + this.serverName + "; Database=" + this.dbName + ";";

                if (this.dbSecurity)
                {
                    connection.ConnectionString = connection.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    connection.ConnectionString = connection.ConnectionString + "User Id=" + this.dbUser + "; Password=" + this.dbKeyCode;

                }

            }
            catch (Exception)
            {
                throw;
            }

            return connection;
        }

        public static Conexion GetInstance()
        {
            if (instance == null)
                instance = new Conexion();

            return instance;
        }

    }
}
