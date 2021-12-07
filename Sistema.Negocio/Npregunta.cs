using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;

namespace Sistema.Negocio
{
    public class Npregunta
    {
        public static DataTable Listar()
        {
            Dpregunta Datos = new Dpregunta();
            return Datos.Listar();
        }

        public static DataTable Listar_Mispregnutas(int user_id)
        {
            Dpregunta Datos = new Dpregunta();
            return Datos.Listar_Mispreguntas(user_id);
        }
        public static string insert(string titulo, string descripcion, int estado, int user_id)
        {
            Dpregunta Datos = new Dpregunta();



            if (Datos.Insert_pregunta(titulo,descripcion, estado, user_id))
            {

                return "Agregado Exitosamente";
            }
            else
            {
                return "Ocurrió un error en la inserción, intente más tarde.";
            }

        }
    }
}
