using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDjuez
    {
        private clsPjuez objetoPjuez = new clsPjuez();
        public List<clsEjuez> listarJuez()
        {
            return objetoPjuez.listarJuez();
        }

        public void insertarArbitro(string cedula, int idCategoria, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPjuez.altaJueces(Convert.ToInt32(cedula), idCategoria, nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }

        public void actualizarArbitro(string cedula, int idCategoria, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPjuez.editarJueces(Convert.ToInt32(cedula), idCategoria, nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }
        public void eliminarArbitro(string cedula, string nombre, string apellido, string email, string nacionalidad, string contrasena)
        {
            objetoPjuez.eliminarJueces(Convert.ToInt32(cedula), nombre, apellido, email, nacionalidad, contrasena);
        }

    }
}
