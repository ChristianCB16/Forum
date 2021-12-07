using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Usuarios
    {
        public int UsersId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        

        public static Usuarios EmptyUser()
        {
            return new Usuarios
            {
                UsersId = 0,
                FirstName = "",
                LastName = "",
                Username = "",
                Email = ""
               
            };
        }

        public static bool IsEmpty(Usuarios user)
        {
            return user.UsersId == 0;
        }
    }

}
