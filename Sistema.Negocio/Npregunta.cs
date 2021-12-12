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

        public static DataTable Listar_Mispregnutas(string username)
        {
            Dpregunta Datos = new Dpregunta();
            return Datos.Listar_Mispreguntas(username);
        }

        public static DataTable cerrar_pregunta(int id)
        {
            Dpregunta Datos = new Dpregunta();
            return Datos.cerrar_pregunta(id);
        }
        public static string insert(string titulo, string descripcion, int estado, string username)
        {
            Dpregunta Datos = new Dpregunta();



            if (Datos.Insert_pregunta(titulo,descripcion, estado, username))
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
