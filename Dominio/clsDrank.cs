using Entidad;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class clsDrank
    {
        private clsPrank rank = new clsPrank();

        public List<clsErank> listarRank()
        {
            return rank.listarRank();
        }
    }
}
