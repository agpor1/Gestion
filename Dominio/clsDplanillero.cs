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

        public DataTable mostrarPlanillero()
        {
            DataTable tabla = new DataTable();
            tabla = objetoPplanillero.Mostrar();
            return tabla;
        }

        public void insertarPlanillero(string cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPplanillero.altaPlanillero(Convert.ToInt32(cedula), nombre, apellido, email, nacionalidad, rol, contrasena);
        }

        public void actualizarPlanillero(string cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPplanillero.editarPlanillero(Convert.ToInt32(cedula), nombre, apellido, email, nacionalidad, rol, contrasena);
        }
        public void eliminarPlanillero(string cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPplanillero.eliminarPlanillero(Convert.ToInt32(cedula), nombre, apellido, email, nacionalidad, rol, contrasena);
        }
    }
}
