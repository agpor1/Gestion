using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
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
            clsPatletas unPu = new clsPatletas();
            return unPu.listarAtleta();
        }

        public void insertarAtletas(string cedula, string idCategoria, string carnetF, string fechaNac, string peso, string sexo, string pais, string nombre, string apellido)
        {
            if (int.TryParse(cedula, out int cedulaInt) && int.TryParse(idCategoria, out int idCategoriaInt) && DateTime.TryParse(fechaNac, out DateTime fechaNac1))
            {
                objetoPatletas.altaAtleta(cedulaInt, idCategoriaInt, carnetF, fechaNac1, peso, sexo, pais, nombre,apellido);
            }
        }
        public void actualizarAtletas(string cedula, string idCategoria, string carnetF, string fechaNac, string peso, string sexo, string pais, string nombre, string apellido)
        {
            if (int.TryParse(cedula, out int cedulaInt) && int.TryParse(idCategoria, out int idCategoriaInt) && DateTime.TryParse(fechaNac, out DateTime fechaNac1))
            {
                objetoPatletas.editarAtleta(cedulaInt, idCategoriaInt, carnetF, fechaNac1, peso, sexo, pais, nombre, apellido);
            }
        }
        public void eliminarAtletas(string cedula, string idCategoria, string carnetF, string fechaNac, string peso, string sexo, string pais, string nombre, string apellido)
        {
            if (int.TryParse(cedula, out int cedulaInt) && int.TryParse(idCategoria, out int idCategoriaInt) && DateTime.TryParse(fechaNac, out DateTime fechaNac1))
            {
                objetoPatletas.eliminarAtleta(cedulaInt, idCategoriaInt, carnetF, fechaNac1, peso, sexo, pais, nombre, apellido);
            }
        }
    }
}
