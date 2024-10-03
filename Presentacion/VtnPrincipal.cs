
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
        //DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelPrincipal.Region = region;
            this.Invalidate();
        }
        //COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
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
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(th, ta);
            this.Location = new Point(lx, ly);
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

        }

        public void AbrirVentana<MiForm>() where MiForm : Form, new()
        {
            Form ventana;
            ventana = panelPrincipal.Controls.OfType<MiForm>().FirstOrDefault();

            if (ventana == null)
            {
                ventana = new MiForm();
                ventana.TopLevel = false;
                ventana.FormBorderStyle = FormBorderStyle.None;
                ventana.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(ventana);
                panelPrincipal.Tag = ventana;
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
        }

    }
}
