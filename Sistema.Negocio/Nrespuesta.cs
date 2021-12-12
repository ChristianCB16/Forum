using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema.Negocio
{
    public class Nrespuesta
    {
        public static DataTable Buscar_respuestas(int quest_id)
        {
            Datos.DRespuesta Datos = new Datos.DRespuesta();
            //DUsuarios Datos = new DPersona();
            return Datos.Buscar_respuestas(quest_id);
        }

        public static string insert(string descripcion, string username, int quest_id)
        {
            Datos.DRespuesta Datos = new Datos.DRespuesta();
            string Existe = Datos.Posible(quest_id);

            if (Existe.Equals("1")) {
                if (Datos.Insert_respuesta(descripcion, username, quest_id))
                {

                    return "Agregado Exitosamente";
                }
                else
                {
                    return "Ocurrió un error en la inserción, intente más tarde.";
                }
            }
            else
            {
                return "La pregunta seleccionada está cerrada. Por favor seleccione otra.";
            }
        }
    }
}
