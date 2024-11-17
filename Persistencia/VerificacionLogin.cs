
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
                    command.CommandText = "SELECT * FROM personas WHERE docPersona=@docPersona AND contrasena=@contrasena";
                    command.Parameters.AddWithValue("@docPersona", usuario);
                    command.Parameters.AddWithValue("@contrasena", contra);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            LoginUsuarioCache.Cedula = reader.GetInt32(reader.GetOrdinal("docPersona"));
                            LoginUsuarioCache.Nombre = reader.GetString(reader.GetOrdinal("primerNombre"));
                            LoginUsuarioCache.Apellido = reader.GetString(reader.GetOrdinal("primerApellido"));
                            LoginUsuarioCache.Email = reader.GetString(reader.GetOrdinal("correo"));
                            LoginUsuarioCache.Nacionalidad = reader.GetString(reader.GetOrdinal("nacionalidad"));
                            LoginUsuarioCache.Rol = reader.GetString(reader.GetOrdinal("rol"));
                            LoginUsuarioCache.Contrasena = reader.GetString(reader.GetOrdinal("contrasena"));

                    }
                        return true;
                    }
                    else
                        return false;
                }
        }
    }
}
