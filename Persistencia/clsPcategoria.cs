using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class clsPcategoria: clsPersistencia
    {
        public List<clsEcategoria> ObtenerCategorias()
        {
            List<clsEcategoria> categorias = new List<clsEcategoria>();
            string consultaSQL = "SELECT idCategoria, nombre FROM categorias;";
            MySqlDataReader datos = null;

            try
            {
                datos = ejecutarYdevolver(consultaSQL);
                if (datos != null && datos.HasRows)
                {
                    while (datos.Read())
                    {
                        categorias.Add(new clsEcategoria
                        {
                            IdCategoria = Convert.ToInt32(datos["idCategoria"]),
                            Nombre = datos["nombre"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener categorías: {ex.Message}");
            }
            finally
            {
                if (datos != null)
                {
                    CerrarLectorYConexion(datos);
                }
            }

            return categorias;
        }
    }
}
