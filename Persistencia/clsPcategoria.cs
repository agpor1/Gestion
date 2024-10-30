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
        public void altaCategoria(int id, string nombre, string sexo, int edad, string peso)
        {
            string consultaSQL = "INSERT INTO `categorias` (`idCategoria`, `nombre`, `sexo`, `edad`, `peso`) VALUES ('"+id+"', '"+nombre+"', '"+sexo+"', '"+edad+"', '"+peso+"')";
            ejecutarSQL(consultaSQL);
        }

        public void editarCategoria(int id, string nombre, string sexo, int edad, string peso)
        {
            string consultaSQL = "UPDATE categorias SET  nombre= '" + nombre + "', sexo='" + sexo + "', edad= '" + edad + "', peso= '" +peso+ "' WHERE idCategoria= '" + id+ "'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarCategoria(int id, string nombre, string sexo, int edad, string peso)
        {
            string consultaSQL = "DELETE FROM categorias WHERE idCategoria= '" + id + "'";
            ejecutarSQL(consultaSQL);
        }
        
        public List<clsEcategoria> listarCategoria()
        {
            List<clsEcategoria> colCategoria = new List<clsEcategoria>();
            string consultaSQL = "SELECT * FROM  categorias;";
            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colCategoria.Add(recrearCategoria(datos));
            }
            CerrarLectorYConexion(datos);
            return colCategoria;
        }
        public List<clsEcategoria> ListarCategoriaPorFiltro(string valor, string tipoFiltro)
        {
            List<clsEcategoria> colCategoria = new List<clsEcategoria>();
            string consultaSQL = "";

            switch (tipoFiltro)
            {
                case "peso":
                    consultaSQL = "SELECT * FROM categorias WHERE peso LIKE '%" + valor + "%'";
                    break;
                case "edad":
                    consultaSQL = "SELECT * FROM categorias WHERE edad LIKE '%" + valor + "%'";
                    break;
                case "sexo":
                    consultaSQL = "SELECT * FROM categorias WHERE sexo LIKE '%" + valor + "%'";
                    break;
                default:
                    consultaSQL = "SELECT * FROM categorias";
                    break;
            }

            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colCategoria.Add(recrearCategoria(datos));
            }

            CerrarLectorYConexion(datos);
            return colCategoria;
        }
        public clsEcategoria recrearCategoria(MySqlDataReader fila)
        {
            clsEcategoria unUsuario = new clsEcategoria();

            unUsuario.IdCategoria = fila.GetInt32("idCategoria");
            unUsuario.Nombre = fila.GetString("nombre");
            unUsuario.Sexo = fila.GetString("sexo");
            unUsuario.Edad = fila.GetInt32("edad");
            unUsuario.Peso = fila.GetString("peso");

            return unUsuario;
        }

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
