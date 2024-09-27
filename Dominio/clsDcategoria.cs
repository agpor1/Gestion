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

    }
}
