using Dominio;
using Entidad;
using Persistencia;
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

namespace Presentacion
{
    public partial class VtnPresidente : Form
    {
        private clsDpresidente objetoPresidente = new clsDpresidente();
        clsPpresidente objetoPpresidente = new clsPpresidente();
        public VtnPresidente()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            VtnPrincipal ventana = new VtnPrincipal();
            ventana.AbrirVentana<VtnUsuarios>();
            ventana.Show();
        }


        private void VtnPresidente_Load(object sender, EventArgs e)
        {
            CambiarIdioma(GestorIdiomas.Idioma);
            actualizar();
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
            lblBuscar.Text = Lenguajes.Buscar;
            lblNacionalidad.Text = Lenguajes.Nacionalidad;
            btnAtras.Text = Lenguajes.Atras;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoName.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtNac.Text) ||
                cmbCargos.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return; // Sale del método si hay algún campo vacío
            }
            // Verificar si el usuario ya existe usando la capa de dominio
            if (objetoPresidente.verificarExistenciaUsuario(txtCedula.Text))
            {
                MessageBox.Show("Este usuario ya existe.");
                return; // Sale del método si el usuario ya existe
            }
            try
            {
                objetoPresidente.insertarPresidente(txtCedula.Text, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se agrego correctamente al nuevo usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el usuario por: " + ex);

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
                objetoPresidente.actualizarPresidente(txtCedula.Text, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
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
                objetoPresidente.eliminarPresidente(txtCedula.Text, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
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
            if (tblPresidente.SelectedRows.Count > 0)
            {
                txtCedula.Text = tblPresidente.CurrentRow.Cells["cedula"].Value.ToString();
                txtNombre.Text = tblPresidente.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = tblPresidente.CurrentRow.Cells["apellido"].Value.ToString();
                txtEmail.Text = tblPresidente.CurrentRow.Cells["email"].Value.ToString();
                txtNac.Text = tblPresidente.CurrentRow.Cells["nacionalidad"].Value.ToString();
                cmbCargos.Text = tblPresidente.CurrentRow.Cells["rol"].Value.ToString();
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
            if (tblPresidente.InvokeRequired)
            {
                tblPresidente.Invoke(new Action(AjustarTabla));
                return;
            }

            // Calcular el ancho disponible
            int margenIzquierdo = 400; // Espacio para el menú lateral
            int margenDerecho = 350;

            // Ajustar posición y tamaño de la tabla
            tblPresidente.Location = new Point(margenIzquierdo, tblPresidente.Location.Y);
            tblPresidente.Width = this.ClientSize.Width - margenIzquierdo - margenDerecho;

        }
        private void ConfigurarControles()
        {
            // Configurar la tabla
            tblPresidente.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            AjustarTabla();
        }
        private void VtnPresidente_Resize(object sender, EventArgs e)
        {
            AjustarTabla();
        }

        public void actualizar()
        {
            clsDpresidente unDu = new clsDpresidente();
            tblPresidente.DataSource = unDu.listarPresidentes();
        }
    }
}
