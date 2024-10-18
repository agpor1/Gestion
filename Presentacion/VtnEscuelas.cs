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
                //txtFechaCrea.Text = tblEscuela.CurrentRow.Cells["fechaCreacion"].Value.ToString();
                txtDireccion.Text = tblEscuela.CurrentRow.Cells["direccion"].Value.ToString();

            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
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

        private void limpiarCampos()
        {
            txtId.Clear();
            txtDireccion.Clear();
            txtMedallero.Clear();
            txtNombre.Clear();

        }
    }
}
