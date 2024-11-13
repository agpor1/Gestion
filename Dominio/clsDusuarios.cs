using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Persistencia;

namespace Dominio
{
    public class clsDusuarios
    {
        private clsPusuarios objetoPusuario = new clsPusuarios();

        public List<clsEusuario> listarUsuarios()
        {
            return objetoPusuario.listarUsuarios();
        }
        public bool verificarExistenciaUsuario(string cedula)
        {
            return objetoPusuario.ExisteUsuario(cedula);
        }

        public void insertarUsuario (string cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena) {
            objetoPusuario.altaUsuario (Convert.ToInt32(cedula),nombre,segundoNombre,apellido,segundoApellido,email,nacionalidad,rol,contrasena);
        }

        public void actualizarUsuario (string cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPusuario.editarUsuario(Convert.ToInt32(cedula), nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }
        public void eliminarUsuarios(string cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string contrasena)
        {
            objetoPusuario.eliminarUsuario(Convert.ToInt32(cedula), nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, contrasena);
        }

    }
}
