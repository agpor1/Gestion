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




        public void insertarAtletas(string cedula, string nombre, string apellido, string peso, string sexo, string nacionalidad, string email, string carnetF, string fechaNac)
        {
            objetoPatletas.altaAtleta(Convert.ToInt32(cedula), nombre, apellido, peso, sexo, nacionalidad, email, carnetF, fechaNac);
        }
        public void actualizarAtletas(string cedula, string nombre, string apellido, string peso, string sexo, string nacionalidad, string email, string carnetF, string fechaNac)
        {
            objetoPatletas.editarAtleta(Convert.ToInt32(cedula), nombre, apellido, peso, sexo, nacionalidad, email, carnetF, fechaNac);
        }
        public void eliminarAtletas(string cedula, string nombre, string apellido, string peso, string sexo, string nacionalidad, string email, string carnetF, string fechaNac)
        {
            objetoPatletas.eliminarAtleta(Convert.ToInt32(cedula), nombre, apellido, peso, sexo, nacionalidad, email, carnetF, fechaNac);
        }
    }
}
