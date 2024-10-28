
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using Entidad;
using System.Globalization;

namespace Presentacion
{
    public partial class VtnPrincipal : Form
    {
        public VtnPrincipal()
        {
            InitializeComponent();
            CambiarIdioma(GestorIdiomas.Idioma);

        }


        #region Funcionalidades de la ventana principal
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION 
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cerrar la aplicacion", "",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly; //lx = lugar de x, ly = lugar de y
        int th, ta; //th = tamaño altura, tamaño ancho
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            th = this.Size.Width;
            ta = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnCerrarSesion.Top = this.ClientSize.Height - btnCerrarSesion.Height - 10;
            logo.Location = new Point(617, 200);

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(th, ta);
            this.Location = new Point(lx, ly);

            btnCerrarSesion.Location = new Point(10, this.ClientSize.Height - btnCerrarSesion.Height - 10);
            logo.Location = new Point(444, 167);

        }


        private void VtnPrincipal_Resize(object sender, EventArgs e)
        {
            btnCerrarSesion.Top = this.ClientSize.Height - btnCerrarSesion.Height - 10;

            // Notificar a todos los formularios hijos abiertos
            foreach (Form form in Application.OpenForms)
            {
                if (form is VtnUsuarios)
                {
                    ((VtnUsuarios)form).AjustarTabla();
                }
            }
        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Metodo para arrastrar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cerrar sesion", "",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        #endregion

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirVentana<VtnUsuarios>();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            AbrirVentana<VtnRank>();
        }
        private void btnEscuela_Click(object sender, EventArgs e)
        {
            AbrirVentana<VtnEscuelas>();
        }
        private void btnTorneo_Click(object sender, EventArgs e)
        {
            AbrirVentana<VtnTorneo>();
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirVentana<VtnCategoria>();
        }
        private void btnDojos_Click(object sender, EventArgs e)
        {
            AbrirVentana<VtnDojos>();
        }
        public void AbrirVentana<MiForm>() where MiForm : Form, new()
        {
            Form ventana;
            ventana = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();

            if (ventana == null)
            {
                ventana = new MiForm();
                ventana.TopLevel = false;
                ventana.FormBorderStyle = FormBorderStyle.None;
                ventana.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(ventana);
                panelFormularios.Tag = ventana;
                ventana.Show();
            }
            ventana.BringToFront();
        }

        private void CargarUsuarioDatos()
        {
            lblNombre.Text = LoginUsuarioCache.Nombre + ", " + LoginUsuarioCache.Apellido;
            lblRol.Text = LoginUsuarioCache.Rol;

        }

        private void panelPerfil_Paint(object sender, PaintEventArgs e)
        {
            CargarUsuarioDatos();
            manejarPermisos();
        }
        private void manejarPermisos()
        {
            if (LoginUsuarioCache.Rol == Cargos.Estandar)
            {

            }

            if (LoginUsuarioCache.Rol == Cargos.Administrador)
            {

            }
        }
        private void CambiarIdioma(string idioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            ActualizarIdioma();
        }

        private void ActualizarIdioma()
        {
            btnCerrarSesion.Text = Lenguajes.CerrarSesion;
            lblTitulo.Text = Lenguajes.Cuk;
            btnUsuarios.Text = Lenguajes.Usuarios;
            btnCategorias.Text = Lenguajes.Categorias;
            btnEscuela.Text = Lenguajes.Escuela;
            btnTorneo.Text = Lenguajes.Torneo;

        }

    }
}
