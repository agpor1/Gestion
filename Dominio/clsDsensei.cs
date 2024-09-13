using Entidad.Cache;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class clsDsensei
     {
        private clsPsensei objetoPsensei = new clsPsensei();

        public DataTable mostrarSensei()
        {
            DataTable tabla = new DataTable();
            tabla = objetoPsensei.Mostrar();
            return tabla;
        }

        public void insertarSensei(string cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPsensei.altaSensei(Convert.ToInt32(cedula),nombre, apellido, email, nacionalidad, rol, contrasena);
        }

        public void actualizarSensei(string cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPsensei.editarSensei(Convert.ToInt32(cedula), nombre, apellido, email, nacionalidad, rol, contrasena);
        }
        public void eliminarSensei(string cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPsensei.eliminarSensei(Convert.ToInt32(cedula), nombre, apellido, email, nacionalidad, rol, contrasena);
        }

        public List<clsEusuario> listarUsuarios()
        {
            clsPsensei unPu = new clsPsensei();
            return unPu.listarSensei();
        }

    }
}
