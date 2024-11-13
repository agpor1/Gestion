using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Persistencia;
using Entidad;
using System.Globalization;

namespace Presentacion
{
    public partial class VtnUsuarios : Form
    {
        private clsDusuarios objetoUsuario = new clsDusuarios();
        public VtnUsuarios()
        {
            InitializeComponent();
            this.Resize += VtnUsuarios_Resize;
            ConfigurarControles();
           
        }

        private void VtnUsuarios_Load(object sender, EventArgs e)
        {
            actualizar();
            CambiarIdioma(GestorIdiomas.Idioma);

        }

        private void CambiarIdioma(string idioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            ActualizarIdioma();
        }

        private void ActualizarIdioma()
        {
            btnGuardar.Text = Lenguajes.Guardar;
            btnEliminar.Text = Lenguajes.Eliminar;
            btnModificar.Text = Lenguajes.Modificar;
            btnListar.Text = Lenguajes.Rellenar;
            lblCedula.Text = Lenguajes.Cedula;
            lblNombre.Text = Lenguajes.PrimerNombre;
            lblSegundoNombre.Text = Lenguajes.SegundoNombre;
            lblApellido.Text = Lenguajes.PrimerApellido;
            lblEmail.Text = Lenguajes.Email;
            lblContrasena.Text = Lenguajes.Contrasena;
            lblSegundoApellido.Text = Lenguajes.SegundoApellido;
            lblCargo.Text = Lenguajes.Cargo;
            presidenteToolStripMenuItem.Text = Lenguajes.Presidente;
            planillerosToolStripMenuItem.Text = Lenguajes.Planillero;
            atletasToolStripMenuItem.Text = Lenguajes.Atletas;
            juecesToolStripMenuItem.Text = Lenguajes.Jueces;
            arbitrosToolStripMenuItem.Text = Lenguajes.Arbitros;
            senseiToolStripMenuItem.Text = Lenguajes.Sensei;
            lblNacionalidad.Text = Lenguajes.Nacionalidad; 
        }

        public void actualizar()
        {
            tblPersona.DataSource = objetoUsuario.listarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtNac.Text) ||
                cmbCargos.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return; // Sale del método si hay algún campo vacío
            }
            // Verificar si el usuario ya existe usando la capa de dominio
            if (objetoUsuario.verificarExistenciaUsuario(txtCedula.Text))
            {
                MessageBox.Show("Este usuario ya existe.");
                return; // Sale del método si el usuario ya existe
            }
            try
            {
                objetoUsuario.insertarUsuario(txtCedula.Text, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se agregó correctamente al nuevo usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el usuario debido a: " + ex.Message);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||   
                cmbCargos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete el campo de cargos antes de modificar.");
                return; // Sale del método si hay algún campo vacío
            }
            try
            {
                objetoUsuario.actualizarUsuario(txtCedula.Text, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se actualizo correctamente el usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el usuario por: " + ex);

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar que el campo de cedula no este vacio
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Por favor, complete el campo de cedula antes de eliminar. ");
                return; // Sale del método si hay algún campo vacío
            }
            try
            {
                objetoUsuario.eliminarUsuarios(txtCedula.Text, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se elimino correctamente el usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el usuario por: " + ex);

            }
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (tblPersona.SelectedRows.Count > 0)
            {
                txtCedula.Text = tblPersona.CurrentRow.Cells["cedula"].Value.ToString();
                txtNombre.Text = tblPersona.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = tblPersona.CurrentRow.Cells["apellido"].Value.ToString();
                txtEmail.Text = tblPersona.CurrentRow.Cells["email"].Value.ToString();
                txtNac.Text = tblPersona.CurrentRow.Cells["nacionalidad"].Value.ToString();
                cmbCargos.Text = tblPersona.CurrentRow.Cells["rol"].Value.ToString();
            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }
        private void limpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtContrasena.Clear();
            txtEmail.Clear();
            txtNac.Clear();
            cmbCargos.Text = "";

        }


        public void AjustarTabla()
        {
            if (tblPersona.InvokeRequired)
            {
                tblPersona.Invoke(new Action(AjustarTabla));
                return;
            }

            // Calcular el ancho disponible
            int margenIzquierdo = 400; // Espacio para el menú lateral
            int margenDerecho = 350;

            // Ajustar posición y tamaño de la tabla
            tblPersona.Location = new Point(margenIzquierdo, tblPersona.Location.Y);
            tblPersona.Width = this.ClientSize.Width - margenIzquierdo - margenDerecho;

        }
        private void ConfigurarControles()
        {
            // Configurar la tabla
            tblPersona.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            AjustarTabla();
        }
        private void VtnUsuarios_Resize(object sender, EventArgs e)
        {
            AjustarTabla();
        }

        VtnPrincipal ventana = new VtnPrincipal();
        private void atletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana.AbrirVentana<VtnAtletas>();
            ventana.Show();
        }

        private void senseiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana.AbrirVentana<VtnSensei>();
            ventana.Show();
        }

        private void juecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana.AbrirVentana<VtnJuez>();
            ventana.Show();
        }

        private void arbitrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana.AbrirVentana<VtnArbitro>();
            ventana.Show();
        }

        private void planillerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana.AbrirVentana<VtnPlanillero>();
            ventana.Show();
        }

        private void presidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana.AbrirVentana<VtnPresidente>();
            ventana.Show();
        }

    }
}
