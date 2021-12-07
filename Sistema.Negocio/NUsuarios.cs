using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;
using Sistema.Datos;
using System.Data;

namespace Sistema.Negocio
{
    public class NUsuarios
    {
        public static bool SignIn(string username, string password)
        {
            DUsuarios duser = new DUsuarios();
            Usuarios user = duser.SignIn(username, password);

            if (Usuarios.IsEmpty(user))
                return false;
            else
            {
                duser.BeginSession(user);
                return true;
            }
        }
        
        public static DataTable List()
        {
            DUsuarios du = new DUsuarios();
            return du.List();
        }

        public static DataTable getOne(int id) {
            DUsuarios du = new DUsuarios();

            return du.getOne(id);
        }


    }
}
