
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Entidad;


namespace Persistencia
{
    public class VerificacionLogin : clsPersistencia
    {
        public bool Login(string usuario, string contra)
        {
            AbrirConexion();
            
                using (var command = new MySqlCommand())
                {
                    command.Connection = con;
                    command.CommandText = "SELECT * FROM personas WHERE cedula=@cedula AND contraseña=@contraseña";
                    command.Parameters.AddWithValue("@cedula", usuario);
                    command.Parameters.AddWithValue("@contraseña", contra);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            LoginUsuarioCache.Cedula = reader.GetInt32(reader.GetOrdinal("cedula"));
                            LoginUsuarioCache.Nombre = reader.GetString(reader.GetOrdinal("nombre"));
                            LoginUsuarioCache.Apellido = reader.GetString(reader.GetOrdinal("apellido"));
                            LoginUsuarioCache.Email = reader.GetString(reader.GetOrdinal("email"));
                            LoginUsuarioCache.Nacionalidad = reader.GetString(reader.GetOrdinal("nacionalidad"));
                            LoginUsuarioCache.Rol = reader.GetString(reader.GetOrdinal("rol"));
                            LoginUsuarioCache.Contrasena = reader.GetString(reader.GetOrdinal("contraseña"));

                    }
                        return true;
                    }
                    else
                        return false;
                }
        }


        public void permiso()
        {
            if (LoginUsuarioCache.Rol == Cargos.Administrador)
            {

            }
           
        }
    }
}
