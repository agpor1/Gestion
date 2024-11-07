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

        public void insertarDojo(string idDojo, int idEscuela, string nombre, string cantInscriptos)
        {
            dojo.altaDojo(Convert.ToInt32(idDojo), idEscuela, nombre, Convert.ToInt32(cantInscriptos));
        }

        public void actualizarDojo(string idDojo, int idEscuela, string nombre, string cantInscriptos)
        {
            dojo.editarDojo(Convert.ToInt32(idDojo), idEscuela, nombre, Convert.ToInt32(cantInscriptos));
        }
        public void eliminarDojo(string idDojo, int idEscuela, string nombre, string cantIncsriptos)
        {
            dojo.eliminarDojo(Convert.ToInt32(idDojo), idEscuela, nombre, Convert.ToInt32(cantIncsriptos));
        }



    }
}
