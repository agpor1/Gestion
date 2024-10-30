using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class clsPjuez : clsPersistencia
    {
        public List<clsEjuez> listarJuez()
        {
            List<clsEjuez> colJuez = new List<clsEjuez>();
            string consultaSQL = "SELECT * FROM jueces INNER JOIN personas ON jueces.docJueces = personas.docPersona;";
            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colJuez.Add(recrearJuez(datos));
            }
            CerrarLectorYConexion(datos);
            return colJuez;
        }

        public void altaJueces(int cedula, int categoria, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "INSERT INTO `personas`(`docPersona`, `primerNombre`, `segundoNombre`, `primerApellido`, `segundoApellido`, `correo`, `nacionalidad`, `rol`, `contrasena`) " +
                "VALUES ('" + cedula + "','" + nombre + "','" + segundoNombre + "','" + apellido + "','" + segundoApellido + "','" + email + "','" + nacionalidad + "','" + rol + "','" + contrasena + "')";
            string consultaSQL2 = "INSERT INTO `jueces`(`docJueces`, `categoria`) VALUES ('" + cedula + "','" + categoria + "')";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);

        }



        public void editarJueces(int cedula, int categoria, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "UPDATE `personas` SET `primerNombre`='" + nombre + "',`segundoNombre`='" + segundoNombre + "',`primerApellido`='" + apellido + "'," +
                "`segundoApellido`='" + segundoApellido + "',`correo`='" + email + "',`nacionalidad`='" + nacionalidad + "',`rol`='" + rol + "',`contrasena`='" + contrasena + "' WHERE docPersona = " + cedula + ";'";
            string consultaSQL2 = "UPDATE `jueces` SET `categoria`='" + categoria + "' WHERE `docJueces`='" + cedula + "'";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
        }


        public void eliminarJueces(int cedula, string nombre, string apellido, string email, string nacionalidad, string contrasena)
        {
            string consulaSQL1 = "DELETE FROM personas WHERE docPersona= '" + cedula + "'";
            string consulaSQL2 = "DELETE FROM jueces WHERE docJueces= '" + cedula + "'";
            ejecutarSQL(consulaSQL1);
            ejecutarSQL(consulaSQL2);
        }

        public bool ExisteUsuario(string cedula)
        {
            bool existe = false;
            string consultaSQL = "SELECT COUNT(*) FROM jueces WHERE docJueces = @docJueces;";

            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
        new MySqlParameter("@docJueces", cedula)
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
        public clsEjuez recrearJuez(MySqlDataReader fila)
        {
            clsEjuez unP = new clsEjuez();

            unP.Cedula = fila.GetInt32("docJueces");
            unP.Categoria = fila.GetInt32("categoria");
            unP.Nombre = fila.GetString("primerNombre");
            unP.segundoNombre = fila.IsDBNull(fila.GetOrdinal("segundoNombre")) ? "" : fila.GetString("segundoNombre");
            unP.Apellido = fila.GetString("primerApellido");
            unP.segundoApellido = fila.IsDBNull(fila.GetOrdinal("segundoApellido")) ? "" : fila.GetString("segundoApellido");
            unP.Email = fila.GetString("correo");
            unP.Nacionalidad = fila.GetString("nacionalidad");
            unP.Rol = fila.GetString("rol");
            unP.Contrasena = fila.GetString("contrasena");

            return unP;
        }
    }
}
