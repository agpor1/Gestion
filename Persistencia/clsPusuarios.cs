using Entidad.Cache;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
   public class clsPusuarios : clsPersistencia
    {
        private clsPersistencia conexion = new clsPersistencia();
        public void altaUsuario (int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena) 
        {
           string consultaSQL = "INSERT INTO personas VALUES ('"+cedula+"','" + nombre+"','"+apellido+"','"+email+ "','"+nacionalidad+"','" + rol+"','"+contrasena+"')";
           ejecutarSQL(consultaSQL);   
        }
    
        public void editarUsuario(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL = "UPDATE personas SET  nombre= '" + nombre + "',  apellido= '" + apellido + "', email= '" + email + "', nacionalidad= '" + nacionalidad + "', rol= '" + rol + "', contraseña= '" + contrasena + "' WHERE cedula= '" + cedula+"'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarUsuario(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL = "DELETE FROM personas WHERE cedula= '" + cedula + "'";
            ejecutarSQL(consultaSQL);
        }

        public List<clsEusuario> listarUsuarios()
        {
            List<clsEusuario> colUsuarios = new List<clsEusuario>();
            string consultaSQL = "SELECT * FROM  personas;";
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
            unUsuario.Nombre = fila.GetString("nombre");
            unUsuario.Apellido = fila.GetString("apellido");
            unUsuario.Email = fila.GetString("email");
            unUsuario.Nacionalidad = fila.GetString("nacionalidad");
            unUsuario.Rol = fila.GetString("rol");

            return unUsuario;
        }



    }
}
