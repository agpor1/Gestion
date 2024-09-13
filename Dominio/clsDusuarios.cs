﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.Cache;
using Persistencia;

namespace Dominio
{
    public class clsDusuarios
    {
        private clsPusuarios objetoPusuario = new clsPusuarios();

        public List<clsEusuario> listarUsuarios()
        {
            clsPusuarios unPu = new clsPusuarios();
            return unPu.listarUsuarios();
        }

        public void insertarUsuario (string cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena) {
            objetoPusuario.altaUsuario (Convert.ToInt32(cedula),nombre,apellido,email,nacionalidad,rol,contrasena);
        }

        public void actualizarUsuario (string cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena){
            objetoPusuario.editarUsuario(Convert.ToInt32(cedula),nombre,apellido,email,nacionalidad,rol,contrasena);
        }
        public void eliminarUsuarios(string cedula, string nombre, string apellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoPusuario.eliminarUsuario(Convert.ToInt32(cedula), nombre, apellido, email, nacionalidad, rol, contrasena);
        }

    }
}
