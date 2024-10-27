using Dominio;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VtnRank : Form
    {
        public VtnRank()
        {
            InitializeComponent();
        }

        private void VtnRank_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        public void actualizar()
        {
            clsDrank unDu = new clsDrank();
            tblRank.DataSource = unDu.listarRank();
        }

    }
}
