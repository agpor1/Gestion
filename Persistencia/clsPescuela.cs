using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class clsPescuela : clsPersistencia
    {
        public void altaEscuela(int id, string nombre, string medallero, DateTime fechaCreacion, string direccion)
        {
            string fechaFormateada = fechaCreacion.ToString("yyyy-MM-dd HH:mm:ss");
            string consultaSQL = "INSERT INTO `escuelas` (`idEscuela`, `nombre`, `medallero`, `fechaCreacion`, `dirreccion`) VALUES ('" + id + "', '" + nombre + "', '" + medallero + "', '" + fechaCreacion + "', '" + direccion + "')";
            ejecutarSQL(consultaSQL);
        }

        public void editarEscuela(int id, string nombre, string medallero, DateTime fechaCreacion, string direccion)
        {
            string fechaFormateada = fechaCreacion.ToString("yyyy-MM-dd HH:mm:ss");
            string consultaSQL = "UPDATE escuelas SET  nombre= '" + nombre + "', medallero='" + medallero + "', fechaCreacion= '" + fechaCreacion + "', dirreccion= '" +direccion+ "' WHERE idEscuela= '" + id + "'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarEscuela(int id, string nombre, string medallero, DateTime fechaCreacion, string direccion)
        {
            string consultaSQL = "DELETE FROM escuelas WHERE idEscuela= '" + id + "'";
            ejecutarSQL(consultaSQL);
        }

        public List<clsEescuela> listarEscuela()
        {
            List<clsEescuela> colEscuela = new List<clsEescuela>();
            string consultaSQL = "SELECT * FROM  escuelas;";
            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colEscuela.Add(recrearEscuela(datos));
            }
            CerrarLectorYConexion(datos);
            return colEscuela;
        }

        public clsEescuela recrearEscuela(MySqlDataReader fila)
        {
            clsEescuela unaEscuela = new clsEescuela();

            unaEscuela.idEscuela = fila.GetInt32("idEscuela");
            unaEscuela.nombre = fila.GetString("nombre");
            unaEscuela.medallero = fila.GetString("medallero");
            //unaEscuela.fechaCrea = fila.GetDateTime("fechaCreacion");
            unaEscuela.direccion = fila.GetString("dirreccion");

            return unaEscuela;
        }

        public List<clsEescuela> ObtenerEscuelas()
        {
            List<clsEescuela> escuela = new List<clsEescuela>();
            string consultaSQL = "SELECT idEscuela, nombre FROM escuelas;";
            MySqlDataReader datos = null;

            try
            {
                datos = ejecutarYdevolver(consultaSQL);
                if (datos != null && datos.HasRows)
                {
                    while (datos.Read())
                    {
                        escuela.Add(new clsEescuela
                        {
                            idEscuela = Convert.ToInt32(datos["idEscuela"]),
                            nombre = datos["nombre"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener escuela: {ex.Message}");
            }
            finally
            {
                if (datos != null)
                {
                    CerrarLectorYConexion(datos);
                }
            }

            return escuela;
        }






    }
}
