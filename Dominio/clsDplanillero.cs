using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDplanillero
    {
        private clsPplanillero objetoPplanillero = new clsPplanillero();

        public List<clsEplanillero> listarPlanillero()
        {
            return objetoPplanillero.listarPlanillero();
        }

        public void insertarPlanillero(string cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPplanillero.altaPlanillero(Convert.ToInt32(cedula), nombre,segundoNombre, apellido,segundoApellido ,email, nacionalidad, rol, contrasena);
        }

        public void actualizarPlanillero(string cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPplanillero.editarPlanillero(Convert.ToInt32(cedula), nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }
        public void eliminarPlanillero(string cedula, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string contrasena)
        {
            objetoPplanillero.eliminarPlanillero(Convert.ToInt32(cedula), nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, contrasena);
        }
    }
}
