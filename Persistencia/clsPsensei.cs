using Entidad;
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
        public List<clsEsensei> listarSensei()
        {
            List<clsEsensei> colUsuarios = new List<clsEsensei>();
            string consultaSQL = "SELECT * FROM senseis INNER JOIN personas ON senseis.docSensei = personas.docPersona;";
            MySqlDataReader datos = null;

            try
            {
                datos = ejecutarYdevolver(consultaSQL);

                if (datos != null && datos.HasRows)
                {
                    while (datos.Read())
                    {
                        colUsuarios.Add(recrearSensei(datos));
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

            return colUsuarios;
        }
        public List<clsEsensei> listarSenseiPorEscuela(string idEscuela)
        {
            List<clsEsensei> colJuez = new List<clsEsensei>();
            string consultaSQL = "SELECT * FROM senseis INNER JOIN personas ON sensei.docSensei = personas.docPersona WHERE personas.idEscuela LIKE '" + idEscuela + "%';";
            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colJuez.Add(recrearSensei(datos));
            }

            CerrarLectorYConexion(datos);
            return colJuez;
        }

        public List<clsEsensei> obtenerSenseis()
        {
            List<clsEsensei> senseis = new List<clsEsensei>();
            string consultaSQL = "SELECT docSensei FROM senseis;";
            MySqlDataReader datos = null;

            try
            {
                datos = ejecutarYdevolver(consultaSQL);
                if (datos != null && datos.HasRows)
                {
                    while (datos.Read())
                    {
                        int docSensei;
                        if (int.TryParse(datos["docSensei"].ToString(), out docSensei))
                        {
                            senseis.Add(new clsEsensei
                            {
                                Cedula = docSensei
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener senseis: {ex.Message}");
            }
            finally
            {
                if (datos != null)
                {
                    CerrarLectorYConexion(datos);
                }
            }

            return senseis;
        }


        public void altaSensei(int cedula, int idEscuela,string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "INSERT INTO `personas`(`docPersona`, `primerNombre`, `segundoNombre`, `primerApellido`, `segundoApellido`, `correo`, `nacionalidad`, `rol`, `contrasena`) " +
                "VALUES ('" + cedula + "','" + nombre + "','" + segundoNombre + "','" + apellido + "','" + segundoApellido + "','" + email + "','" + nacionalidad + "','" + rol + "','" + contrasena + "')";
            string consultaSQL2 = "INSERT INTO `senseis`(`docSensei`, `idEscuela`) VALUES ('"+cedula+"','"+idEscuela+"')";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
                 
        }



        public void editarSensei(int cedula, int idEscuela, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "UPDATE `personas` SET `primerNombre`='" + nombre + "',`segundoNombre`='" + segundoNombre + "',`primerApellido`='" + apellido + "'," +
                "`segundoApellido`='" + segundoApellido + "',`correo`='" + email + "',`nacionalidad`='" + nacionalidad + "',`rol`='" + rol + "',`contrasena`='" + contrasena + "' WHERE docPersona = " + cedula + ";'";
            string consultaSQL2 = "UPDATE `senseis` SET `idEscuela`='"+idEscuela+"' WHERE `docSensei`='"+cedula+"'";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
        }


        public void eliminarSensei(int cedula, string nombre, string apellido, string email, string nacionalidad,string contrasena)
        {
            string consulaSQL1 = "DELETE FROM personas WHERE docPersona= '" + cedula + "'";
            string consulaSQL2 = "DELETE FROM senseis WHERE docSensei= '" + cedula + "'";
            ejecutarSQL(consulaSQL1);
            ejecutarSQL(consulaSQL2);
        }
        public bool ExisteUsuario(string cedula)
        {
            bool existe = false;
            string consultaSQL = "SELECT COUNT(*) FROM senseis WHERE docSensei = @docSensei;";

            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
            new MySqlParameter("@docSensei", cedula)
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

        public clsEsensei recrearSensei(MySqlDataReader fila)
        {
            clsEsensei unP = new clsEsensei();

            unP.Cedula = fila.GetInt32("docSensei");
            unP.Nombre = fila.GetString("primerNombre");
            unP.segundoNombre = fila.IsDBNull(fila.GetOrdinal("segundoNombre")) ? "" : fila.GetString("segundoNombre");
            unP.Apellido = fila.GetString("primerApellido");
            unP.segundoApellido = fila.IsDBNull(fila.GetOrdinal("segundoApellido")) ? "" : fila.GetString("segundoApellido");
            unP.Email = fila.GetString("correo");
            unP.Nacionalidad = fila.GetString("nacionalidad");
            unP.Rol = fila.GetString("rol");
            unP.Contrasena = fila.GetString("contrasena");
            unP.IdEscuela = fila.GetInt32("idEscuela");

            return unP;
        }
    }
}
