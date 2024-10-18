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


        public void altaSensei(int cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "INSERT INTO personas VALUES ( docPersona='" + cedula + "', primerNombre= '" + nombre + "', segundoNombre='" + segundoNombre + "',  primerApellido= '" + apellido + "', correo= '" + email + "'" +
                        ", nacionalidad= '" + nacionalidad + "', rol= '" + rol + "', contrasena= '" + contrasena + "')";
            string consultaSQL2 = "INSERT INTO senseis  VALUES docSensei= " + cedula+ "";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
                 
        }



        public void editarSensei(int cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "UPDATE personas SET  primerNombre= '" + nombre + "',  segundoNombre= '" + apellido + "', primerApellido= '" + apellido + "', apellido= '" + apellido + "', " +
                        "correo= '" + email + "', nacionalidad= '" + nacionalidad + "', rol= '" + rol + "', contrasena= '" + contrasena + "' WHERE docPersona= '" + cedula + "'";
            string consultaSQL2 = "UPDATE senseis SET WHERE docSensei= '" + cedula + "'";
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

       

        public clsEsensei recrearSensei(MySqlDataReader fila)
        {
            clsEsensei unUsuario = new clsEsensei();

            unUsuario.Cedula = fila.GetInt32("cedula");
            unUsuario.Apellido = fila.GetString("apellido");
            unUsuario.Nombre = fila.GetString("nombre");
            unUsuario.Email = fila.GetString("email");
            unUsuario.Nacionalidad = fila.GetString("nacionalidad");

            return unUsuario;

        }


    }
}
