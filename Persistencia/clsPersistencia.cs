using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Persistencia
{
   public class clsPersistencia
   {
        public MySqlConnection con;
        public string miConexion;
        public void AbrirConexion()
        {
            try
            {
                miConexion = "server=localhost; uid=root; password=; database=proyecto";
                con = new MySqlConnection(miConexion);
                con.Open();
            }
            catch (MySqlException ex) 
            {
                Console.WriteLine("Eror al abrir la conexion : "+ ex.Message); // Mensaje de error MySql
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eror general : " + ex.Message); // Mensaje de error Genrales
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (MySqlException ex) 
            {
                Console.WriteLine("Error al cerra la conexion: " + ex.Message);
            }
            catch (Exception ex)        
            {
                Console.WriteLine("Error general: " + ex.Message);
            }
        }


        public void ejecutarSQL(string consultaSQL)
        {
            try
            {
                AbrirConexion();
                MySqlCommand comando = new MySqlCommand(consultaSQL, con);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex) 
            {
                Console.WriteLine("Error al ejecutar la consulata SQlL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al ejecutar la consulta: " + ex.Message);
            }
            finally 
            {
                CerrarConexion();
            }
        }

        public MySqlDataReader ejecutarYdevolver(string consultaSQL, List<MySqlParameter> parametros = null)
        {
            MySqlDataReader resultado = null;

            try
            {
                AbrirConexion();
                MySqlCommand comando = new MySqlCommand(consultaSQL, con);

                // Agregar los parámetros a la consulta si existen
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                }

                resultado = comando.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al ejecutar la consulta y devolver resultados: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al ejecutar la consulta: " + ex.Message);
            }

            return resultado;
        }


        public void CerrarLectorYConexion(MySqlDataReader lector)
        {
            try
            {
                if (lector != null && !lector.IsClosed)
                {
                    lector.Close();
                }
            }
            catch (MySqlException ex) 
            {
                Console.WriteLine("Error al cerrar el lector: " +ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al cerrar el lector: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
