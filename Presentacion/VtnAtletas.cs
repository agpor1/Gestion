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
            CargarSenseis();
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
        private void CargarSenseis()
        {
            try
            { 
                clsDsensei senseiDatos = new clsDsensei();
  
                List<clsEsensei> sensei = senseiDatos.ObtenerSenseis();

                if (sensei != null && sensei.Count > 0)
                {
                    clsEsensei senseiVacio = new clsEsensei { IdSensei = 0, Cedula = 0 }; 
                    sensei.Insert(0, senseiVacio);

                    cmbSensei.DataSource = sensei;
                    cmbSensei.DisplayMember = "Cedula";  
                    cmbSensei.ValueMember = "IdSensei"; 

                    cmbSensei.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron senseis.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los senseis: " + ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            VtnPrincipal ventana = new VtnPrincipal();
            ventana.AbrirVentana<VtnUsuarios>();
            ventana.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Si el formulario se está cerrando, asegurarse de limpiarlo correctamente
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Dispose();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoAtletas.insertarAtletas(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtPeso.Text, txtSexo.Text, txtPais.Text, txtCorreo.Text, txtCarnetF.Text, txtFechanac.Text);
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
                objetoAtletas.eliminarAtletas(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtPeso.Text, txtSexo.Text, txtPais.Text, txtCorreo.Text, txtCarnetF.Text, txtFechanac.Text);
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
                objetoAtletas.actualizarAtletas(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtPeso.Text, txtSexo.Text, txtPais.Text, txtCorreo.Text, txtCarnetF.Text, txtFechanac.Text);
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
                txtCedula.Text = tblAtletas.CurrentRow.Cells["cedula"].Value.ToString();
                txtNombre.Text = tblAtletas.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = tblAtletas.CurrentRow.Cells["apellido"].Value.ToString();
                txtCorreo.Text = tblAtletas.CurrentRow.Cells["correo"].Value.ToString();
                txtPais.Text = tblAtletas.CurrentRow.Cells["pais"].Value.ToString();
                txtPeso.Text = tblAtletas.CurrentRow.Cells["peso"].Value.ToString();
            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }

        private void limpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtPeso.Clear();
            txtSexo.Clear();
            txtCarnetF.Clear();
            txtPais.Clear();
            txtPeso.Clear();
            txtFechanac.Clear();
            cmbCategorias.Text = "";
            cmbSensei.Text = "";
        }

    }
}
