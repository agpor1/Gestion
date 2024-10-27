using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDatletas
    {
        private clsPatletas objetoPatletas = new clsPatletas();

        public List<clsEatletas> listarAtletas()
        {
            return objetoPatletas.listarAtleta();
        }
        public List<clsEatletas> ObtenerAtletas()
        {
            return objetoPatletas.ObtenerAtletas();
        }
        public void insertarAtletas(string cedula, int idCategoria, string carnetF, string fechaNac, string peso, string sexo, string pais, string nombre, string apellido)
        {
            objetoPatletas.altaAtleta(Convert.ToInt32(cedula), idCategoria,carnetF,Convert.ToDateTime(fechaNac), peso, sexo, pais, nombre, apellido);
        }
        public void actualizarAtletas(string cedula, int idCategoria, string carnetF, string fechaNac, string peso, string sexo, string pais, string nombre, string apellido)
        {
            objetoPatletas.editarAtleta(Convert.ToInt32(cedula), idCategoria, carnetF, Convert.ToDateTime(fechaNac), peso, sexo, pais, nombre, apellido);
        }
        public void eliminarAtletas(string cedula, string carnetF, string fechaNac, string peso, string sexo, string pais, string nombre, string apellido)
        {
            objetoPatletas.eliminarAtleta(Convert.ToInt32(cedula),carnetF, Convert.ToDateTime(fechaNac), peso, sexo, pais, nombre, apellido);
        }
    }
}
