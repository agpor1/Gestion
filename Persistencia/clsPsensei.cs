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
            string consultaSQL = "SELECT * FROM senseis INNER JOIN personas ON senseis.cedula = personas.cedula;";
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
            string consultaSQL = "SELECT idSensei, cedula  FROM senseis;"; 
            MySqlDataReader datos = null;

            try
            {
                datos = ejecutarYdevolver(consultaSQL); 
                if (datos != null && datos.HasRows)
                {
                    while (datos.Read())
                    {
                        senseis.Add(new clsEsensei
                        {
                            IdSensei = Convert.ToInt32(datos["idSensei"]),
                            Cedula = Convert.ToInt32(datos["cedula"])  
                        });
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


        public void altaSensei(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "INSERT INTO personas VALUES ('" + cedula + "','" + nombre + "','" + apellido + "','" + email + "','" + nacionalidad + "','" + rol + "','" + contrasena + "')";
            string consultaSQL2 = "INSERT INTO senseis  VALUES cedula= " + cedula+ "";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
                 
        }



        public void editarSensei(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consultaSQL1 = "UPDATE personas SET  nombre= '" + nombre + "',  apellido= '" + apellido + "', email= '" + email + "', nacionalidad= '" + nacionalidad + "', rol= '" + rol + "', contraseña= '" + contrasena + "' WHERE cedula= '" + cedula + "'";
            string consultaSQL2 = "UPDATE senseis SET WHERE cedula= '" + cedula + "'";
            ejecutarSQL(consultaSQL1);
            ejecutarSQL(consultaSQL2);
        }


        public void eliminarSensei(int cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            string consulaSQL1 = "DELETE FROM personas WHERE cedula= '" + cedula + "'";
            string consulaSQL2 = "DELETE FROM senseis WHERE cedula= '" + cedula + "'";
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
