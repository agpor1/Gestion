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
           string consultaSQL = "INSERT INTO `personas`(`docPersona`, `primerNombre`, `segundoNombre`, `primerApellido`, `segundoApellido`, `correo`, `nacionalidad`, `rol`, `contrasena`) " +
                "VALUES ('"+cedula+"','"+nombre+"','"+segundoNombre+"','"+apellido+"','"+segundoApellido+"','"+email+"','"+nacionalidad+"','"+rol+"','"+contrasena+"')";
            ejecutarSQL(consultaSQL);
        }
    
        public void editarUsuario(int cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL = "UPDATE `personas` SET `primerNombre`='"+nombre+"',`segundoNombre`='"+segundoNombre+"',`primerApellido`='"+apellido+"'," +
                "`segundoApellido`='"+segundoApellido+"',`correo`='"+email+"',`nacionalidad`='"+nacionalidad+"',`rol`='"+rol+"',`contrasena`='"+contrasena+"' WHERE docPersona = "+cedula+";'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarUsuario(int cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string contrasena)
        {
            string consultaSQL = "DELETE FROM `personas` WHERE `docPersona`= '" + cedula + "'";
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

        public bool ExisteUsuario(string cedula)
        {
            bool existe = false;
            string consultaSQL = "SELECT COUNT(*) FROM personas WHERE docPersona = @docPersona;";

            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
        new MySqlParameter("@docPersona", cedula)
            };

            MySqlDataReader datos = ejecutarYdevolver(consultaSQL, parametros);

            // Verificar si datos es null antes de leer
            if (datos != null)
            {
                if (datos.Read())
                {
                    existe = datos.GetInt32(0) > 0;
                }

                // Cerrar el lector y la conexión
                CerrarLectorYConexion(datos);
            }
            else
            {
                Console.WriteLine("Error: No se pudieron obtener los datos del usuario.");
            }

            return existe;
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
