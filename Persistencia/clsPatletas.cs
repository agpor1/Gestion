using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class clsPatletas: clsPersistencia
    {
        public void altaAtleta(int cedula, string nombre, string apellido, string peso, string sexo, string nacionalidad, string email, string carnetF, string fechaNac)
        {
            string consultaSQL = "INSERT INTO atletas VALUES ('" + cedula + "','" + nombre + "','" + apellido + "','" + peso + "','" + sexo + "','" + nacionalidad + "','" + email + "','" + carnetF + "','" + fechaNac +"',)";
            ejecutarSQL(consultaSQL);
        }

        public void editarAtleta(int cedula, string nombre, string apellido, string peso, string sexo, string nacionalidad, string email, string carnetF, string fechaNac)
        {
            string consultaSQL = "UPDATE atletas SET  nombre= '" + nombre + "',  apellido= '" + apellido + "', peso= '" + peso + "', sexo= '" + sexo + "', pais= '" + nacionalidad + "', correo= '" + email + "', carnertFederado='" + carnetF + "', fechaNacimiento= '" +fechaNac + "' WHERE ciAtleta= '" + cedula + "'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarAtleta(int cedula, string nombre, string apellido, string peso, string sexo, string nacionalidad, string email, string carnetF, string fechaNac)
        {
            string consultaSQL = "DELETE FROM atletas WHERE ciAtleta= '" + cedula + "'";
            ejecutarSQL(consultaSQL);
        }

        public List<clsEatletas> listarAtleta()
        {
            List<clsEatletas> colAtletas = new List<clsEatletas>();
            string consultaSQL = "SELECT * FROM atletas;";
            MySqlDataReader datos = null;

            try
            {
                datos = ejecutarYdevolver(consultaSQL);

                if (datos != null && datos.HasRows)
                {
                    while (datos.Read())
                    {
                        colAtletas.Add(recrearAtletas(datos));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar atletas: {ex.Message}");
                
            }
            finally
            {
                if (datos != null)
                {
                    CerrarLectorYConexion(datos);
                }
            }

            return colAtletas;
        }

        public clsEatletas recrearAtletas(MySqlDataReader fila)
        {
            clsEatletas unUsuario = new clsEatletas();

            unUsuario.Cedula = fila.GetInt32("cedula");
            unUsuario.Nombre = fila.GetString("nombre");
            unUsuario.Apellido = fila.GetString("apellido");
            unUsuario.Email = fila.GetString("correo");
            unUsuario.Nacionalidad = fila.GetString("pais");
            unUsuario.Peso = fila.GetString("peso");
            unUsuario.Sexo = fila.GetString("sexo");

            return unUsuario;
        }
    }
}

