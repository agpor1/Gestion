using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDescuela
    {
        private clsPescuela escuela = new clsPescuela();

        public List<clsEescuela> listarEscuela()
        {
            return escuela.listarEscuela();
        }
        public List<clsEescuela> ObtenerEscuelas()
        {
            return escuela.ObtenerEscuelas();
        }

        public void insertarEscuela(string id, string nombre, string medallero, string fechaCreacion, string direccion)
        {
                escuela.altaEscuela(Convert.ToInt32(id), nombre, medallero,Convert.ToDateTime(fechaCreacion), direccion);
        }

        public void actualizarEscuela(string id, string nombre, string medallero, string fechaCreacion, string direccion)
        {
                escuela.editarEscuela(Convert.ToInt32(id), nombre, medallero, Convert.ToDateTime(fechaCreacion), direccion);
        }
        public void eliminarEscuela(string id, string nombre, string medallero, string fechaCreacion, string direccion)
        {
                escuela.eliminarEscuela(Convert.ToInt32(id), nombre, medallero, Convert.ToDateTime(fechaCreacion), direccion);  
        }

    }
}
