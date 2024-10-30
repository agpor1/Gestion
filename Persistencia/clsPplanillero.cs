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
    public class clsPplanillero : clsPersistencia
    {

        public List<clsEplanillero> listarPlanillero()
        {
            List<clsEplanillero> colPlanillero = new List<clsEplanillero>();
            string consultaSQL = "SELECT * FROM planilleros INNER JOIN personas ON planilleros.docPlanillero = personas.docPersona;";
            MySqlDataReader datos = null;

            try
            {
                datos = ejecutarYdevolver(consultaSQL);

                if (datos != null && datos.HasRows)
                {
                    while (datos.Read())
                    {
                        colPlanillero.Add(recrearPlanillero(datos));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar sensei: {ex.Message}");
            }
            finally
            {
                if (datos != null)
                {
                    CerrarLectorYConexion(datos);
                }
            }

            return colPlanillero;
        }

       


        public void altaPlanillero(int cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "INSERT INTO `personas`(`docPersona`, `primerNombre`, `segundoNombre`, `primerApellido`, `segundoApellido`, `correo`, `nacionalidad`, `rol`, `contrasena`) " +
                "VALUES ('" + cedula + "','" + nombre + "','" + segundoNombre + "','" + apellido + "','" + segundoApellido + "','" + email + "','" + nacionalidad + "','" + rol + "','" + contrasena + "')";
            string consultaSQL2 = "INSERT INTO `planilleros`(`docPlanillero`) VALUES ('"+cedula +"')";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);

        }



        public void editarPlanillero(int cedula,string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "UPDATE `personas` SET `primerNombre`='" + nombre + "',`segundoNombre`='" + segundoNombre + "',`primerApellido`='" + apellido + "'," +
                "`segundoApellido`='" + segundoApellido + "',`correo`='" + email + "',`nacionalidad`='" + nacionalidad + "',`rol`='" + rol + "',`contrasena`='" + contrasena + "' WHERE docPersona = " + cedula + ";'";
            string consultaSQL2 = "UPDATE `planilleros` SET `docPlanillero`='" + cedula + "' WHERE `docPlanillero`='" + cedula + "'";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
        }


        public void eliminarPlanillero(int cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string contrasena)
        {
            string consulaSQL1 = "DELETE FROM personas WHERE docPersona= '" + cedula + "'";
            string consulaSQL2 = "DELETE FROM planilleros WHERE docPlanillero= '" + cedula + "'";
            ejecutarSQL(consulaSQL1);
            ejecutarSQL(consulaSQL2);
        }
        public bool ExisteUsuario(string cedula)
        {
            bool existe = false;
            string consultaSQL = "SELECT COUNT(*) FROM planilleros WHERE docPlanillero = @docPlanillero;";

            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
        new MySqlParameter("@docPlanillero", cedula)
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
        public clsEplanillero recrearPlanillero(MySqlDataReader fila)
        {
            clsEplanillero unP = new clsEplanillero();

            unP.Cedula = fila.GetInt32("docPlanillero");
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
