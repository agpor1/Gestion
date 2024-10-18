using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class clsPtorneo : clsPersistencia
    {
        public void altaTorneo(int idTorneo, int idPool, int idEscuela, string nombre, string alcance, DateTime fechaInicio, DateTime fechaFin)
        {
            string consultaSQL = "INSERT INTO torneos VALUES ( idTorneo='" + idTorneo + "', idPool= '" + idPool + "', idEscuela='" + idEscuela + "',  nombre= '" + nombre + "', alcance= '" + alcance + "'" +
                ", fechaInicio= '" + fechaInicio + "', fechaFinal= '" + fechaFin +"')";

            ejecutarSQL(consultaSQL);
        }

        public void editarTorneo(int idTorneo, int idPool, int idEscuela, string nombre, string alcance, DateTime fechaInicio, DateTime fechaFin)
        {
            string consultaSQL = "UPDATE torneos SET idPool= '" + idPool + "', idEscuela='" + idEscuela +"',  nombre= '" + nombre + "', alcance= '" + alcance + "'" +
                ", fechaInicio= '" + fechaInicio + "', fechaFinal= '" + fechaFin + "'WHERE idTorneo= '" + idTorneo + "'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarTorneo(int idTorneo, int idPool, int idEscuela, string nombre, string alcance, DateTime fechaInicio, DateTime fechaFin)
        {
            string consultaSQL = "DELETE FROM torneos WHERE idTorneo= '" + idTorneo + "'";
            ejecutarSQL(consultaSQL);
        }

        public List<clsEtorneo> listarTorneo()
        {
            List<clsEtorneo> colAtletas = new List<clsEtorneo>();
            string consultaSQL = "SELECT * FROM torneos;";
            MySqlDataReader datos = null;

            try
            {
                datos = ejecutarYdevolver(consultaSQL);

                if (datos != null && datos.HasRows)
                {
                    while (datos.Read())
                    {
                        colAtletas.Add(recrearTorneos(datos));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar atletas: {ex.Message}");

            }
            finally
            {
                if (datos != null)
                {
                    CerrarLectorYConexion(datos);
                }
            }

            return colAtletas;
        }

        public clsEtorneo recrearTorneos(MySqlDataReader fila)
        {
            clsEtorneo unT = new clsEtorneo();

            unT.idTorneo = fila.GetInt32("idTorneo");
            unT.idPool = fila.GetInt32("idPool");
            unT.idEscuela = fila.GetInt32("idEscuela");
            unT.nombre = fila.GetString("nombre");
            unT.alcance = fila.GetString("alcance");
            unT.fechaInicio = fila.GetDateTime("fechaInicio");
            unT.fechaFinal = fila.GetDateTime("fechaFinal");

            return unT;
        }



    }
}
