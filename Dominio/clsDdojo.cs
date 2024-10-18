using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDdojo
    {
        private clsPdojo dojo = new clsPdojo();

        public List<clsEdojo> listarDojo()
        {
            return dojo.listarDojos();
        }

        public void insertarDojo(string idDojo, string idEscuela, string docAtleta, string nombre, string cantInsriptos)
        {
            dojo.altaDojo(Convert.ToInt32(idDojo), Convert.ToInt32(idEscuela), Convert.ToInt32(docAtleta), nombre, Convert.ToInt32(cantInsriptos));
        }

        public void actualizarDojo(string idDojo, string idEscuela, string docAtleta, string nombre, string cantInsriptos)
        {
            dojo.editarDojo(Convert.ToInt32(idDojo), Convert.ToInt32(idEscuela), Convert.ToInt32(docAtleta), nombre, Convert.ToInt32(cantInsriptos));
        }
        public void eliminarDojo(string idDojo, string idEscuela, string docAtleta, string nombre, string cantInsriptos)
        {
            dojo.eliminarDojo(Convert.ToInt32(idDojo), Convert.ToInt32(idEscuela), Convert.ToInt32(docAtleta), nombre, Convert.ToInt32(cantInsriptos));
        }



    }
}
