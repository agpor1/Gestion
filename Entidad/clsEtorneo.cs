using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class clsEtorneo
    {
        public int idTorneo { get; set; }
        public int idEscuela { get; set; }
        public string nombre { get; set; }
        public string alcance { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }

    }
}
