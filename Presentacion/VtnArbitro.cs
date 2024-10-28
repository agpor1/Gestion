using Dominio;
using Entidad;
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
    public partial class VtnArbitro : Form
    {
        private clsDarbitro objetoArbitro = new clsDarbitro();
        public VtnArbitro()
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
        private void VtnArbitro_Load(object sender, EventArgs e)
        {
            CambiarIdioma(GestorIdiomas.Idioma);
            actualizar();
            CargarCategorias();
        }
        private void CargarCategorias()
        {
            try
            {
                clsDcategoria categoriaDatos = new clsDcategoria();

                List<clsEcategoria> categorias = categoriaDatos.ObtenerCategorias();

                if (categorias != null)
                {
                    clsEcategoria categoriaVacia = new clsEcategoria { IdCategoria = 0, Nombre = "" };
                    categorias.Insert(0, categoriaVacia);

                    cmbCategoria.DataSource = categorias;
                    cmbCategoria.DisplayMember = "nombre";
                    cmbCategoria.ValueMember = "IdCategoria";

                    cmbCategoria.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron categorías.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
        }
        public void actualizar()
        {
            tblArbitro.DataSource = objetoArbitro.listarArbitro();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoriaSeleccionada = (int)cmbCategoria.SelectedValue;
                objetoArbitro.insertarArbitro(txtCedula.Text, idCategoriaSeleccionada, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
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
                int idCategoriaSeleccionada = (int)cmbCategoria.SelectedValue;
                objetoArbitro.actualizarArbitro(txtCedula.Text, idCategoriaSeleccionada, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
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
                objetoArbitro.eliminarArbitro(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, txtContrasena.Text);
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
            if (tblArbitro.SelectedRows.Count > 0)
            {
                txtCedula.Text = tblArbitro.CurrentRow.Cells["Cedula"].Value.ToString();
                txtNombre.Text = tblArbitro.CurrentRow.Cells["nombre"].Value.ToString();
                txtSegundoName.Text = tblArbitro.CurrentRow.Cells["segundoNombre"].Value.ToString();
                txtApellido.Text = tblArbitro.CurrentRow.Cells["apellido"].Value.ToString();
                txtSegundoApellido.Text = tblArbitro.CurrentRow.Cells["segundoApellido"].Value.ToString();
                txtEmail.Text = tblArbitro.CurrentRow.Cells["Email"].Value.ToString();
                txtNac.Text = tblArbitro.CurrentRow.Cells["nacionalidad"].Value.ToString();
                cmbCargos.Text = tblArbitro.CurrentRow.Cells["Rol"].Value.ToString();

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
            cmbCargos.Text = "";
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

      
    }
}
