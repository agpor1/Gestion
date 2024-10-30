using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDpresidente
    {
        private clsPpresidente objetoPpresidente = new clsPpresidente();
        public List<clsEpresidente> listarPresidentes()
        {
            return objetoPpresidente.listarPresidente();
        }
        public bool verificarExistenciaUsuario(string cedula)
        {
            return objetoPpresidente.ExisteUsuario(cedula);
        }
        public void insertarPresidente(string cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPpresidente.altaPresidente(Convert.ToInt32(cedula), nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }

        public void actualizarPresidente(string cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPpresidente.editarPresidente(Convert.ToInt32(cedula), nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }
        public void eliminarPresidente(string cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPpresidente.eliminarPresidente(Convert.ToInt32(cedula), nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }

    }
}
