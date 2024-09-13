using Entidad;
using Entidad.Cache;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Persistencia
{
    public class clsPsensei : clsPersistencia
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
                comando.CommandText = "SELECT * FROM sensei";

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

        public void altaSensei(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "INSERT INTO persona VALUES('" + cedula + "','" + nombre + "','" + apellido + "','" + email + "','" + nacionalidad + "','" + rol + "','" + contrasena + "')";
            string consultaSQL2 = "INSERT INTO sensei  VALUES Cedula= (" + cedula+")";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
                 
        }

        public void editarSensei(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "UPDATE persona SET  Nombre= '" + nombre + "',  Apellido= '" + apellido + "', Email= '" + email + "', Nacionalidad= '" + nacionalidad + "', Rol= '" + rol + "', Contrasena= '" + contrasena + "' WHERE Cedula= '" + cedula + "'";
            string consultaSQL2 = "UPDATE sensei SET WHERE Cedula= '" + cedula + "'";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
        }


        public void eliminarSensei(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consulaSQL1 = "DELETE FROM persona WHERE cedula= '" + cedula + "'";
            string consulaSQL2 = "DELETE FROM usuario WHERE cedula= '" + cedula + "'";
            ejecutarSQL(consulaSQL1);
            ejecutarSQL(consulaSQL2);
        }


        public List<clsEusuario> listarSensei()
        {
            List<clsEusuario> colUsuarios = new List<clsEusuario>();
            string consultaSQL = "SELECT * FROM senesei INNER JOIN personas ON sensei.cedulaSensei = personas.cedula;";
            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colUsuarios.Add(recrearUsuario(datos));
            }
            CerrarLectorYConexion(datos);
            return colUsuarios;

        }

        public clsEusuario recrearUsuario(MySqlDataReader fila)
        {
            clsEusuario unUsuario = new clsEusuario();

            unUsuario.Cedula = fila.GetInt32("cedula");
            unUsuario.Apellido = fila.GetString("apellido");
            unUsuario.Nombre = fila.GetString("nombre");
            unUsuario.Email = fila.GetString("email");
            unUsuario.Nacionalidad = fila.GetString("nacionalidad");
            unUsuario.Rol = fila.GetString("rol");


            return unUsuario;

        }


    }
}
