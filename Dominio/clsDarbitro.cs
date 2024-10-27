﻿using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDarbitro
    {
        private clsParbitros objetoParbitro = new clsParbitros();
        public List<clsEarbitro> listarArbitro()
        {
            return objetoParbitro.listarArbitro();
        }

        public void insertarArbitro(string cedula, string idCategoria, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoParbitro.altaArbitro(Convert.ToInt32(cedula), Convert.ToInt32(idCategoria), nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }

        public void actualizarArbitro(string cedula, string idCategoria, string nombre, string segundoNombre, string apellido, string segundoApellido, string email, string nacionalidad, string rol, string contrasena)
        {
            objetoParbitro.editarArbitro(Convert.ToInt32(cedula), Convert.ToInt32(idCategoria), nombre, segundoNombre, apellido, segundoApellido, email, nacionalidad, rol, contrasena);
        }
        public void eliminarArbitro(string cedula, string nombre, string apellido, string email, string nacionalidad, string contrasena)
        {
            objetoParbitro.eliminarArbitro(Convert.ToInt32(cedula), nombre, apellido, email, nacionalidad, contrasena);
        }

    }
}
