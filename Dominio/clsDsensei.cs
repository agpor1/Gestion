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
     public class clsDsensei
     {
        private clsPsensei objetoPsensei = new clsPsensei();
        public List<clsEsensei> listarSensei()
        {
            return objetoPsensei.listarSensei();
        }
        public List<clsEsensei> ObtenerSenseis()
        {
            return objetoPsensei.obtenerSenseis();
        }
        public bool verificarExistenciaUsuario(string cedula)
        {
            return objetoPsensei.ExisteUsuario(cedula);
        }

        public List<clsEsensei> listarSenseisPorEscuela(string idEsceula)
        {
            return objetoPsensei.listarSenseiPorEscuela(idEsceula);
        }

        public void insertarSensei(string cedula, int idEscuela, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPsensei.altaSensei(Convert.ToInt32(cedula), idEscuela, nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }


        public void actualizarSensei(string cedula, int idEscuela, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPsensei.editarSensei(Convert.ToInt32(cedula), idEscuela, nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }
        public void eliminarSensei(string cedula, string nombre, string apellido, string email, string nacionalidad,string contrasena)
        {
            objetoPsensei.eliminarSensei(Convert.ToInt32(cedula), nombre, apellido, email, nacionalidad,contrasena);
        }

        

     }
}
