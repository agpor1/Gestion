using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Persistencia;

namespace Dominio
{
    public class clsLogin
    {
        clsPersistencia clsPersistencia = new clsPersistencia();
        public bool LoginUsuario(string Nombre, string Contrasena) {
            return LoginUsuario(Nombre, Contrasena);
        }


    //seguridad y permisos
        public void permiso()
        {
            //if (clsEusuario.Rol == Cargos.Administrador)
            //{

            //}
            
        }


    }

}
