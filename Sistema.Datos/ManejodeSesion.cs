using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class ManejodeSesion {

        private Usuarios SessionUser = Usuarios.EmptyUser();
        public static ManejodeSesion instance = null;

        public static ManejodeSesion GetInstance()
        {
            if (instance == null)
                instance = new ManejodeSesion();

            return instance;
        }

        public void BeginSession(Usuarios user)
        {
            SessionUser = user;
        }
        public void ExpireSession()
        {
            SessionUser = Usuarios.EmptyUser();
        }

        public string GetSessionProperty(string property)
        {
            return this.SessionUser.Email;
        }
    }
}

