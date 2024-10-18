using Dominio;
using Entidad;
using Persistencia;
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
    public partial class VtnAtletas : Form
    {
        private clsDatletas objetoAtletas = new clsDatletas();
        clsPatletas objetoPatletas = new clsPatletas();
        public VtnAtletas()
        {
            InitializeComponent();
        }
        private void VtnAtletas_Load(object sender, EventArgs e)
        {
            actualizar();
            CargarCategorias();
        }

        public void actualizar()
        {
            clsDatletas unDu = new clsDatletas();
            tblAtletas.DataSource = unDu.listarAtletas();
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

                    cmbCategorias.DataSource = categorias;
                    cmbCategorias.DisplayMember = "nombre";
                    cmbCategorias.ValueMember = "IdCategoria";

                    cmbCategorias.SelectedIndex = 0;
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
                objetoAtletas.insertarAtletas(txtCedula.Text, cmbCategorias.SelectedItem.ToString(), txtNombre.Text, txtPais.Text, txtApellido.Text, txtPeso.Text, txtSexo.Text, txtCarnetF.Text, dtFecha.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Se agrego correctamente al nuevo usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el usuario por: " + ex);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoAtletas.eliminarAtletas(txtCedula.Text, cmbCategorias.SelectedItem.ToString(), txtNombre.Text, txtPais.Text, txtApellido.Text, txtPeso.Text, txtSexo.Text, txtCarnetF.Text, dtFecha.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Se elimino correctamente el usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el usuario por: " + ex);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoAtletas.actualizarAtletas(txtCedula.Text, cmbCategorias.SelectedItem.ToString(), txtNombre.Text, txtPais.Text, txtApellido.Text, txtPeso.Text, txtSexo.Text, txtCarnetF.Text, dtFecha.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Se actualizo correctamente el usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el usuario por: " + ex);

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (tblAtletas.SelectedRows.Count > 0)
            {
                txtCedula.Text = tblAtletas.CurrentRow.Cells["Cedula"].Value.ToString();
                txtNombre.Text = tblAtletas.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = tblAtletas.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCarnetF.Text = tblAtletas.CurrentRow.Cells["CarnetFederado"].Value.ToString();
                txtPais.Text = tblAtletas.CurrentRow.Cells["Nacionalidad"].Value.ToString();
                txtPeso.Text = tblAtletas.CurrentRow.Cells["Peso"].Value.ToString();
                txtSexo.Text = tblAtletas.CurrentRow.Cells["Sexo"].Value.ToString();
                dtFecha.Text = tblAtletas.CurrentRow.Cells["FechaNac"].Value.ToString();
                cmbCategorias.Text = tblAtletas.CurrentRow.Cells["idCategoria"].Value.ToString();

            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }

        private void limpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtPeso.Clear();
            txtSexo.Clear();
            txtCarnetF.Clear();
            txtPais.Clear();
            txtPeso.Clear();
            cmbCategorias.Text = "";
        }

       
    }
}
