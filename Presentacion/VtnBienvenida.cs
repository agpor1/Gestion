using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Presentacion.Properties;

namespace Presentacion
{
    public partial class VtnBienvenida : Form
    {
        public VtnBienvenida()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void VtnBienvenida_Load(object sender, EventArgs e)
        {
            CambiarIdioma(GestorIdiomas.Idioma);
            lblNombre.Text = LoginUsuarioCache.Nombre + ",  " + LoginUsuarioCache.Apellido;
            this.Opacity = 0.0;
            timer1.Start();
        }

        private void CambiarIdioma(string idioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            ActualizarIdioma();
        }

        private void ActualizarIdioma()
        {
            lblBienvenida.Text = Lenguajes.Bienvenido;
            lblTitulo.Text = Lenguajes.Cuk;
        }

        private void lblTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
