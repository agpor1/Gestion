using Dominio;
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
    public partial class VtnEscuelas : Form
    {

        private clsDescuela objetoEscuela = new clsDescuela();

        public VtnEscuelas()
        {
            InitializeComponent();
            cmbFiltro.Items.AddRange(new string[] {
            " ",
            "nombre",
            "ranking",
            "año creado",
            });
            cmbFiltro.SelectedIndex = 0; // Seleccion vacia por defecto

        }


        private void VtnEscuelas_Load(object sender, EventArgs e)
        {
            actualizar();
        }


        public void actualizar()
        {
            clsDescuela unDu = new clsDescuela();
            tblEscuela.DataSource = unDu.listarEscuela();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtMedallero.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return; // Sale del método si hay algún campo vacío
            }
            try
            {
                objetoEscuela.insertarEscuela(txtId.Text, txtNombre.Text, txtMedallero.Text, dtFecha.Value.ToString("yyyy-MM-dd"), txtDireccion.Text);
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
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, complete el campo de id antes de modificar.");
                return; // Sale del método si hay algún campo vacío
            }
            try
            {
                objetoEscuela.actualizarEscuela(txtId.Text, txtNombre.Text, txtMedallero.Text, dtFecha.Value.ToString("yyyy-MM-dd"), txtDireccion.Text);
                MessageBox.Show("Se actualizo correctamente el usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el usuario por: " + ex);

            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            if (tblEscuela.SelectedRows.Count > 0)
            {
                txtId.Text = tblEscuela.CurrentRow.Cells["idEscuela"].Value.ToString();
                txtNombre.Text = tblEscuela.CurrentRow.Cells["nombre"].Value.ToString();
                txtMedallero.Text = tblEscuela.CurrentRow.Cells["medallero"].Value.ToString();
                txtDireccion.Text = tblEscuela.CurrentRow.Cells["direccion"].Value.ToString();

            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica que el campo de id no este vacío
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, complete el campo de id antes de eliminar.");
                return; // Sale del método si hay algún campo vacío
            }
            try
            {
                objetoEscuela.eliminarEscuela(txtId.Text, txtNombre.Text, txtMedallero.Text, dtFecha.Value.ToString("yyyy-MM-dd"), txtDireccion.Text);
                MessageBox.Show("Se elimino correctamente el usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el usuario por: " + ex);

            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            VtnPrincipal ventana = new VtnPrincipal();
            ventana.AbrirVentana<VtnUsuarios>();
            ventana.Show();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cmbFiltro.SelectedIndex = 0;
            tblEscuela.DataSource = objetoEscuela.ListarEscuelaPorFiltro("", "");
            tblEscuela.Refresh();
        }
        private void limpiarCampos()
        {
            txtId.Clear();
            txtDireccion.Clear();
            txtMedallero.Clear();
            txtNombre.Clear();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscar.Text;
            string tipoFiltro = cmbFiltro.SelectedItem?.ToString() ?? "";

            // Validación 
            if (tipoFiltro == "fecha" && !string.IsNullOrEmpty(valorBusqueda))
            {
                if (!valorBusqueda.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor ingrese solo números para la fecha");
                    return;
                }
            }

            tblEscuela.DataSource = objetoEscuela.ListarEscuelaPorFiltro(valorBusqueda, tipoFiltro);
            tblEscuela.Refresh();
        }
    }
}
