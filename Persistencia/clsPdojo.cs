using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class clsPdojo : clsPersistencia  
    {
        public void altaDojo(int idDojo, int idEscuela, int docAtleta, string nombre, int cantInsriptos)
        {
            string consultaSQL = "INSERT INTO dojos VALUES ( idDojo='" + idDojo + "', idEscuela= '" + idEscuela + "', docAtleta='" + docAtleta + "', nombre= '" + nombre + "', cantInscriptos= '" + cantInsriptos +"')";
            ejecutarSQL(consultaSQL);
        }

        public void editarDojo(int idDojo, int idEscuela, int docAtleta, string nombre, int cantInsriptos)
        {
            string consultaSQL = "UPDATE dojos SET idEscuela= '" + idEscuela + "', docAtleta='" + docAtleta + "', nombre= '" + nombre + "', cantInscriptos= '" + cantInsriptos + "'" +
                 "' WHERE idDojo= '" + idDojo + "'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarDojo(int idDojo, int idEscuela, int docAtleta, string nombre, int cantInsriptos)
        {
            string consultaSQL = "DELETE FROM dojos WHERE idDojo= '" + idDojo + "'";
            ejecutarSQL(consultaSQL);
        }

        public List<clsEdojo> listarDojos()
        {
            List<clsEdojo> colDojo = new List<clsEdojo>();
            string consultaSQL = "SELECT * FROM  dojos;";
            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colDojo.Add(recrearDojo(datos));
            }
            CerrarLectorYConexion(datos);
            return colDojo;
        }

        public clsEdojo recrearDojo(MySqlDataReader fila)
        {
            clsEdojo unD = new clsEdojo();

            unD.idDojo = fila.GetInt32("idDojo");
            unD.idEscuela = fila.GetInt32("idEscuela");
            unD.docAtleta = fila.GetInt32("docAtleta");
            unD.nombre = fila.GetString("nombre");
            unD.cantInscriptos = fila.GetInt32("cantInscriptos");

            return unD;
        }




    }
}
