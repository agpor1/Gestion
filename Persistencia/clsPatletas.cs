﻿using Entidad;
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
        public void altaAtleta(int cedula, int idCategoria, string carnetF, DateTime fechaNac, string peso, string sexo, string pais, string nombre, string apellido)
        {
            string consultaSQL = "INSERT INTO `atletas`(`docAtleta`, `idCategoria`, `carneFederado`, `fechaNacimiento`, `peso`, `sexo`, `pais`, `nombre`, `apellido`) VALUES " +
                "('"+cedula+"','"+idCategoria+"','"+carnetF+"','"+fechaNac.ToString("yyyy-MM-dd") + "','"+peso+"','"+sexo+"','"+pais+"','"+nombre+"','"+apellido+"')";

            ejecutarSQL(consultaSQL);
        }

        public void editarAtleta(int cedula, int idCategoria, string carnetF, DateTime fechaNac, string peso, string sexo, string pais, string nombre, string apellido)
        {
            string consultaSQL = "UPDATE `atletas` SET `idCategoria`='"+idCategoria+"',`carneFederado`='"+carnetF+"',`fechaNacimiento`='"+fechaNac.ToString("yyyy-MM-dd")+"',`peso`='"+peso+"'," +
                "`sexo`='"+sexo+"',`pais`='"+pais+"',`nombre`='"+nombre+"',`apellido`='"+apellido+ "' WHERE `docAtleta`='" + cedula+"'";
            ejecutarSQL(consultaSQL);
        }

        public void eliminarAtleta(int cedula, string carnetF, DateTime fechaNac, string peso, string sexo, string pais, string nombre, string apellido)
        {
            string consultaSQL = "DELETE FROM atletas WHERE docAtleta= '" + cedula + "'";
            ejecutarSQL(consultaSQL);
        }

        public List<clsEatletas> listarAtleta()
        {
            List<clsEatletas> colAtletas = new List<clsEatletas>();
            string consultaSQL = "SELECT * FROM `atletas`;";
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
        public List<clsEatletas> ListarAtletasPorFiltro(string valor, string tipoFiltro)
        {
            List<clsEatletas> colAtleta = new List<clsEatletas>();
            string consultaSQL = "";

            switch (tipoFiltro)
            {
                case "pais":
                    consultaSQL = "SELECT * FROM atletas WHERE pais LIKE '%" + valor + "%'";
                    break;
                case "cedula":
                    consultaSQL = "SELECT * FROM atletas WHERE docAtleta LIKE '%" + valor + "%'";
                    break;
                case "sexo":
                    consultaSQL = "SELECT * FROM atletas WHERE sexo LIKE '%" + valor + "%'";
                    break;
                default:
                    consultaSQL = "SELECT * FROM atletas";
                    break;
            }

            MySqlDataReader datos = ejecutarYdevolver(consultaSQL);

            while (datos.Read())
            {
                colAtleta.Add(recrearAtletas(datos));
            }

            CerrarLectorYConexion(datos);
            return colAtleta;
        }
        public bool ExisteUsuario(string cedula)
        {
            bool existe = false;
            string consultaSQL = "SELECT COUNT(*) FROM atletas WHERE docAtleta = @docAtleta;";

            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
            new MySqlParameter("@docAtleta", cedula)
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
        public clsEatletas recrearAtletas(MySqlDataReader fila)
        {
            clsEatletas unA = new clsEatletas();

            unA.Cedula = fila.GetInt32("docAtleta");
            unA.idCategoria = fila.GetInt32("idCategoria");
            unA.Nombre = fila.GetString("nombre");
            unA.Apellido = fila.GetString("apellido");
            unA.Nacionalidad = fila.GetString("pais");
            unA.Peso = fila.GetString("peso");
            unA.Sexo = fila.GetString("sexo");
            unA.CarnetFederado = fila.GetString("carneFederado");
            unA.FechaNac = fila.GetDateTime("fechaNacimiento");

            return unA;
        }


        public List<clsEatletas> ObtenerAtletas()
        {
            List<clsEatletas> atletas = new List<clsEatletas>();
            string consultaSQL = "SELECT `docAtleta` FROM `atletas`;";
            MySqlDataReader datos = null;

            try
            {
                datos = ejecutarYdevolver(consultaSQL);
                if (datos != null && datos.HasRows)
                {
                    while (datos.Read())
                    {
                        atletas.Add(new clsEatletas
                        {
                            Cedula = Convert.ToInt32(datos["docAtleta"]),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener altetas: {ex.Message}");
            }
            finally
            {
                if (datos != null)
                {
                    CerrarLectorYConexion(datos);
                }
            }

            return atletas;
        }
    }
}

