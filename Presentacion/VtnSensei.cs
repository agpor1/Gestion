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
    public partial class VtnSensei : Form
    {
        private clsDsensei objetoSensei = new clsDsensei();
        public VtnSensei()
        {
            InitializeComponent();
            actualizar();
        }
        private void VtnSensei_Load(object sender, EventArgs e)
        {
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
            btnAtras.Text = Lenguajes.Atras;
            btnListar.Text = Lenguajes.Rellenar;
            lblCedula.Text = Lenguajes.Cedula;
            lblNombre.Text = Lenguajes.Nombre;
            lblApellido.Text = Lenguajes.Apellido;
            lblEmail.Text = Lenguajes.Email;
            lblContrasena.Text = Lenguajes.Contrasena;
        }

        public void actualizar()
        {
            clsDsensei unDu = new clsDsensei();
            tblSensei.DataSource = unDu.listarSensei();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            VtnPrincipal ventana = new VtnPrincipal();
            ventana.AbrirVentana<VtnUsuarios>();
            ventana.Show();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoSensei.insertarSensei(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, txtContrasena.Text);
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
            try
            {
                objetoSensei.actualizarSensei(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text,txtContrasena.Text);
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
            try
            {
                objetoSensei.eliminarSensei(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text,txtContrasena.Text);
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
            if (tblSensei.SelectedRows.Count > 0)
            {
                txtCedula.Text = tblSensei.CurrentRow.Cells["Cedula"].Value.ToString();
            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }
        private void limpiarCampos()
        {
            txtCedula.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtNac.Clear();
            txtNombre.Clear();
            txtContrasena.Clear();
           
        }
    }
}
