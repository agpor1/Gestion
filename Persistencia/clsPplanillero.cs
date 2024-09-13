using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class clsPplanillero : clsPersistencia
    {

        private clsPersistencia conexion = new clsPersistencia();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();

            try
            {
                AbrirConexion();
                comando.Connection = con;
                comando.CommandText = "SELECT * FROM planillero";

                using (var leer = comando.ExecuteReader())
                {
                    tabla.Load(leer);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return tabla;
        }

        public void altaPlanillero(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "INSERT INTO persona VALUES('" + cedula + "','" + nombre + "','" + apellido + "','" + email + "','" + nacionalidad + "','" + rol + "','" + contrasena + "')";
            string consultaSQL2 = "INSERT INTO planillero VALUES Cedula= (" + cedula + ")";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);

        }

        public void editarPlanillero(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "UPDATE persona SET  Nombre= '" + nombre + "',  Apellido= '" + apellido + "', Email= '" + email + "', Nacionalidad= '" + nacionalidad + "', Rol= '" + rol + "', Contrasena= '" + contrasena + "' WHERE Cedula= '" + cedula + "'";
            string consultaSQL2 = "UPDATE planillero SET WHERE Cedula= '" + cedula + "'";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
        }


        public void eliminarPlanillero(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consulaSQL1 = "DELETE FROM persona WHERE cedula= '" + cedula + "'";
            string consulaSQL2 = "DELETE FROM planillero WHERE cedula= '" + cedula + "'";
            ejecutarSQL(consulaSQL1);
            ejecutarSQL(consulaSQL2);
        }
    }
}
