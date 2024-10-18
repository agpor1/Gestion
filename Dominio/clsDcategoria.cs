using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDcategoria
    {
        private clsPcategoria categoria = new clsPcategoria();

        public List<clsEcategoria> ObtenerCategorias()
        {
            return categoria.ObtenerCategorias();
        }
        public List<clsEcategoria> listarCategoria()
        {
            return categoria.listarCategoria();
        }

        public void insertarCategoria(string id, string nombre, string sexo, string edad, string peso)
        {
            categoria.altaCategoria(Convert.ToInt32(id), nombre, sexo, Convert.ToInt32(edad), peso);
        }

        public void actualizarCategoria(string id, string nombre, string sexo, string edad, string peso)
        {
            categoria.editarCategoria(Convert.ToInt32(id), nombre, sexo, Convert.ToInt32(edad), peso);
        }
        public void eliminarCategoria(string id, string nombre, string sexo, string edad, string peso)
        {
            categoria.eliminarCategoria(Convert.ToInt32(id), nombre, sexo, Convert.ToInt32(edad), peso);
        }

    }
}
