using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class clsPrank : clsPersistencia
    {
        public List<clsErank> listarRank()
        {
            List<clsErank> colEscuela = new List<clsErank>();
            string consultaSQL = "SELECT medallero, nombre FROM escuelas;";
            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colEscuela.Add(recrearRank(datos));
            }
            CerrarLectorYConexion(datos);
            return colEscuela;
        }

        public clsErank recrearRank(MySqlDataReader fila)
        {
            clsErank rank = new clsErank();

            rank.nombre = fila.GetString("nombre");
            rank.medallero = fila.GetString("medallero");

            return rank;
        }


    }
}
