using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class clsParbitros : clsPersistencia
    {
        public List<clsEarbitro> listarArbitro()
        {
            List<clsEarbitro> colArbitros = new List<clsEarbitro>();
            string consultaSQL = "SELECT * FROM arbitros INNER JOIN personas ON arbitros.docArbitro = personas.docPersona;";
            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colArbitros.Add(recrearArbitro(datos));
            }
            CerrarLectorYConexion(datos);
            return colArbitros;
        }

        public bool ExisteUsuario(string cedula)
        {
            bool existe = false;
            string consultaSQL = "SELECT COUNT(*) FROM arbitros WHERE docArbitro = @docArbitro;";

            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
        new MySqlParameter("@docArbitro", cedula)
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

        public void altaArbitro(int cedula, int idCategoria, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "INSERT INTO `personas`(`docPersona`, `primerNombre`, `segundoNombre`, `primerApellido`, `segundoApellido`, `correo`, `nacionalidad`, `rol`, `contrasena`) " +
                "VALUES ('" + cedula + "','" + nombre + "','" + segundoNombre + "','" + apellido + "','" + segundoApellido + "','" + email + "','" + nacionalidad + "','" + rol + "','" + contrasena + "')";
            string consultaSQL2 = "INSERT INTO `arbitros`(`docArbitro`, `categoria`) VALUES ('"+ cedula +"','" + idCategoria +"')";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);

        }



        public void editarArbitro(int cedula, int idCategoria, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "UPDATE `personas` SET `primerNombre`='" + nombre + "',`segundoNombre`='" + segundoNombre + "',`primerApellido`='" + apellido + "'," +
                "`segundoApellido`='" + segundoApellido + "',`correo`='" + email + "',`nacionalidad`='" + nacionalidad + "',`rol`='" + rol + "',`contrasena`='" + contrasena + "' WHERE docPersona = " + cedula + ";'";
            string consultaSQL2 = "UPDATE `arbitros` SET `categoria`='"+ idCategoria +"' WHERE `docArbitro`='"+ cedula +"'";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
        }


        public void eliminarArbitro(int cedula, string nombre, string apellido, string email, string nacionalidad, string contrasena)
        {
            string consulaSQL1 = "DELETE FROM personas WHERE docPersona= '" + cedula + "'";
            string consulaSQL2 = "DELETE FROM arbitros WHERE docArbitro= '" + cedula + "'";
            ejecutarSQL(consulaSQL1);
            ejecutarSQL(consulaSQL2);
        }



        public clsEarbitro recrearArbitro(MySqlDataReader fila)
        {
            clsEarbitro unP = new clsEarbitro();

            unP.Cedula = fila.GetInt32("docArbitro");
            unP.IdCategoria = fila.GetInt32("categoria");
            unP.Nombre = fila.GetString("primerNombre");
            unP.segundoNombre = fila.IsDBNull(fila.GetOrdinal("segundoNombre")) ? "" : fila.GetString("segundoNombre");
            unP.Apellido = fila.GetString("primerApellido");
            unP.segundoApellido = fila.IsDBNull(fila.GetOrdinal("segundoApellido")) ? "" : fila.GetString("segundoApellido");
            unP.Email = fila.GetString("correo");
            unP.Nacionalidad = fila.GetString("nacionalidad");
            unP.Rol = fila.GetString("rol");

            return unP;
        }
    }
}
