using Persistencia;
using Dominio;
using Entidad;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using Presentacion.Properties;

namespace Presentacion
{
    public partial class VtnLogin : Form
    {
        public VtnLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "CONTRASE�A")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.LightGray;
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }
        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "CONTRASE�A";
                txtContrase�a.ForeColor = Color.DimGray;
                txtContrase�a.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cerrar la aplicacion", "",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();

        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btbIniciar_Click(object sender, EventArgs e)
        {
            // Validar la entrada del usuario
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text.Length <= 2)
            {
                msgError("Por favor ingrese un usuario v�lido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrase�a.Text))
            {
                msgError("Por favor ingrese su contrase�a.");
                return;
            }

            // Realizar la verificaci�n de login
            VerificacionLogin usuario = new VerificacionLogin();
            bool validarLogin = usuario.Login(txtUsuario.Text.Trim(), txtContrase�a.Text);

            if (validarLogin)
            {
                this.Hide();
                VtnBienvenida bienvenida = new VtnBienvenida();
                bienvenida.ShowDialog();
                VtnPrincipal menuPrincipal = new VtnPrincipal();
                menuPrincipal.Show();
                menuPrincipal.FormClosed += Logout;

            }
            else
            {
                msgError("Contrase�a o Usuario incorrecto. \nIntente de nuevo.");
                txtContrase�a.Clear();
                txtContrase�a.UseSystemPasswordChar = false;
                txtUsuario.Focus();
            }

        }
        private void msgError(string msg)
        {
            lblMensajeError.Text = "" + msg;
            lblMensajeError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContrase�a.Text = "CONTRASE�A";
            txtContrase�a.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensajeError.Visible = false;
            this.Show();
        }

        private bool contrasenaVisible = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contrasenaVisible = !contrasenaVisible;
            txtContrase�a.UseSystemPasswordChar = !contrasenaVisible;
            txtContrase�a.ForeColor = contrasenaVisible ? Color.LightGray : Color.LightGray;
        }


        private void VtnLogin_Load(object sender, EventArgs e)
        {
            espa�olToolStripMenuItem.Click += (s, ev) => CambiarIdioma("es");
            inglesToolStripMenuItem.Click += (s, ev) => CambiarIdioma("en");

            // Idioma por defecto
            CambiarIdioma(GestorIdiomas.Idioma);
        }

        private void CambiarIdioma(string idioma)
        {
            GestorIdiomas.Idioma = idioma; // Guardar la elecci�n globalmente

            ActualizarIdioma();
        }

        private void ActualizarIdioma()
        {
            txtUsuario.Text = Lenguajes.Usuarios;
            txtContrase�a.Text = Lenguajes.Contrasena;
            btbIniciar.Text = Lenguajes.Iniciar;
        }
    }
}
