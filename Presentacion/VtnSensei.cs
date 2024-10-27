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
        }
        private void VtnSensei_Load(object sender, EventArgs e)
        {
            CambiarIdioma(GestorIdiomas.Idioma);
            actualizar();
            CargarEscuela();
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
            lblEscuela.Text = Lenguajes.Escuela;
            lblBuscar.Text = Lenguajes.Buscar;
            lblNacionalidad.Text = Lenguajes.Nacionalidad;
            btnAtras.Text = Lenguajes.Atras;
        }

        public void actualizar()
        {
            clsDsensei unDu = new clsDsensei();
            tblSensei.DataSource = unDu.listarSensei();
        }

        private void CargarEscuela()
        {
            try
            {
                clsDescuela escuelaDatos = new clsDescuela();

                List<clsEescuela> escuela = escuelaDatos.ObtenerEscuelas();

                if (escuela != null)
                {
                    clsEescuela escuelaVacia = new clsEescuela { idEscuela = 0, nombre = "" };
                    escuela.Insert(0, escuelaVacia);

                    cmbEscuelas.DataSource = escuela;
                    cmbEscuelas.DisplayMember = "nombre";
                    cmbEscuelas.ValueMember = "idEscuela";

                    cmbEscuelas.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron escuelas.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar las escuelas: " + ex.Message);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            VtnPrincipal ventana = new VtnPrincipal();
            ventana.AbrirVentana<VtnUsuarios>();
            ventana.Show();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEscuelaSeleccionada = (int)cmbEscuelas.SelectedValue;
                objetoSensei.insertarSensei(txtCedula.Text, idEscuelaSeleccionada, txtNombre.Text,txtSegundoName.Text, txtApellido.Text,txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbRol.SelectedItem.ToString(), txtContrasena.Text);
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
                int idEscuelaSeleccionada = (int)cmbEscuelas.SelectedValue;
                objetoSensei.actualizarSensei(txtCedula.Text, idEscuelaSeleccionada, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbRol.SelectedItem.ToString(), txtContrasena.Text);
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
                txtNombre.Text = tblSensei.CurrentRow.Cells["nombre"].Value.ToString();
                txtSegundoName.Text = tblSensei.CurrentRow.Cells["segundoNombre"].Value.ToString();
                txtApellido.Text = tblSensei.CurrentRow.Cells["apellido"].Value.ToString();
                txtSegundoApellido.Text = tblSensei.CurrentRow.Cells["segundoApellido"].Value.ToString();
                txtEmail.Text = tblSensei.CurrentRow.Cells["Email"].Value.ToString();
                txtNac.Text = tblSensei.CurrentRow.Cells["nacionalidad"].Value.ToString();
                cmbRol.Text = tblSensei.CurrentRow.Cells["Rol"].Value.ToString();

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
            cmbRol.Text = "";
        }
    }
}
