using Entidad;
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
        public void altaUsuario (int cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena) 
        {
           string consultaSQL = "INSERT INTO personas VALUES ( docPersona='" + cedula + "', primerNombre= '" + nombre + "', segundoNombre='" + segundoNombre + "',  primerApellido= '" + apellido + "', correo= '" + email + "'" +
                ", nacionalidad= '" + nacionalidad + "', rol= '" + rol + "', contrasena= '" + contrasena + "')";
            ejecutarSQL(consultaSQL);
        }
    
        public void editarUsuario(int cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL = "UPDATE personas SET  primerNombre= '" + nombre + "',  segundoNombre= '" + apellido + "', primerApellido= '" + apellido + "', apellido= '" + apellido + "', " +
                "correo= '" + email + "', nacionalidad= '" + nacionalidad + "', rol= '" + rol + "', contrasena= '" + contrasena + "' WHERE docPersona= '" + cedula+"'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarUsuario(int cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL = "DELETE FROM personas WHERE docPerona= '" + cedula + "'";
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

            unUsuario.Cedula = fila.GetInt32("docPersona");
            unUsuario.Nombre = fila.GetString("primerNombre");
            unUsuario.Apellido = fila.GetString("primerApellido");
            unUsuario.Email = fila.GetString("correo");
            unUsuario.Nacionalidad = fila.GetString("nacionalidad");
            unUsuario.Rol = fila.GetString("rol");

            return unUsuario;
        }



   }
}
