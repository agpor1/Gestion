using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDtorneo
    {
        private clsPtorneo objetoTorneo = new clsPtorneo();

        public List<clsEtorneo> listarTorneos()
        {
            clsPtorneo unPu = new clsPtorneo();
            return unPu.listarTorneo();
        }

        public void insertarTorneo(string idTorneo, string idPool, string idEscuela, string nombre, string alcance, string fechaInicio, string fechaFin)
        {
            objetoTorneo.altaTorneo(Convert.ToInt32(idTorneo), Convert.ToInt32(idPool), Convert.ToInt32(idEscuela), nombre, alcance, Convert.ToDateTime(fechaInicio),Convert.ToDateTime(fechaFin));
        }

        public void actualizarTorneo(string idTorneo, string idPool, string idEscuela, string nombre, string alcance, string fechaInicio, string fechaFin)
        {
            objetoTorneo.editarTorneo(Convert.ToInt32(idTorneo), Convert.ToInt32(idPool), Convert.ToInt32(idEscuela), nombre, alcance, Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFin));
        }
        public void eliminarTorneo(string idTorneo, string idPool, string idEscuela, string nombre, string alcance, string fechaInicio, string fechaFin)
        {
            objetoTorneo.eliminarTorneo(Convert.ToInt32(idTorneo), Convert.ToInt32(idPool), Convert.ToInt32(idEscuela), nombre, alcance, Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFin));
        }

    }
}
