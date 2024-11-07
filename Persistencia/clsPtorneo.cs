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
        public void altaTorneo(int idTorneo, int idEscuela, string nombre, string ubicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            string consultaSQL = "INSERT INTO `torneos`(`idTorneo`, `idEscuela`, `nombre`, `ubicacion`, `fechaInicio`, `fechaFinal`) " +
                "VALUES ('"+idTorneo+"','"+idEscuela+"','"+nombre+"','"+ ubicacion + "','"+fechaInicio.ToString("yyyy-MM-dd") + "','"+fechaFin.ToString("yyyy-MM-dd") + "')";

            ejecutarSQL(consultaSQL);
        }

        public void editarTorneo(int idTorneo, int idEscuela, string nombre, string ubicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            string consultaSQL = "UPDATE torneos SET idEscuela='" + idEscuela +"',  nombre= '" + nombre + "', ubicacion= '" + ubicacion + "'" +
                ", fechaInicio= '" + fechaInicio.ToString("yyyy-MM-dd") + "', fechaFinal= '" + fechaFin.ToString("yyyy-MM-dd") + "'WHERE idTorneo= '" + idTorneo + "'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarTorneo(int idTorneo, int idEscuela, string nombre, string ubicacion, DateTime fechaInicio, DateTime fechaFin)
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
        public List<clsEtorneo> ListarTorneoPorFiltro(string valor, string tipoFiltro)
        {
            List<clsEtorneo> colTorneo = new List<clsEtorneo>();
            string consultaSQL = "";

            switch (tipoFiltro)
            {
                case "fechaInicio":
                    consultaSQL = "SELECT * FROM torneos WHERE fechaInicio LIKE '%" + valor + "%'";
                    break;
                case "año creado":
                    consultaSQL = "SELECT * FROM torneos WHERE fechaCreacion LIKE '%" + valor + "%'";
                    break;
                case "ubicacion":
                    consultaSQL = "SELECT * FROM torneos WHERE ubicacion LIKE '%" + valor + "%'";
                    break;
                case "fechaFinal":
                    consultaSQL = "SELECT * FROM torneos WHERE fechaFinal LIKE '%" + valor + "%'";
                    break;
                default:
                    consultaSQL = "SELECT * FROM torneos";
                    break;
            }

            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colTorneo.Add(recrearTorneos(datos));
            }

            CerrarLectorYConexion(datos);
            return colTorneo;
        }

        public clsEtorneo recrearTorneos(MySqlDataReader fila)
        {
            clsEtorneo unT = new clsEtorneo();

            unT.idTorneo = fila.GetInt32("idTorneo");
            unT.idEscuela = fila.GetInt32("idEscuela");
            unT.nombre = fila.GetString("nombre");
            unT.ubicacion = fila.GetString("ubicacion");
            unT.fechaInicio = fila.GetDateTime("fechaInicio");
            unT.fechaFinal = fila.GetDateTime("fechaFinal");

            return unT;
        }

    }
}
