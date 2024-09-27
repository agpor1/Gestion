using Dominio;
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
    public partial class VtnPlanillero : Form
    {
        public VtnPlanillero()
        {
            InitializeComponent();
        }

       private clsDplanillero objetoDplanillero = new clsDplanillero();
        clsPplanillero objetoPplanillero = new clsPplanillero();

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VtnPlanillero_Load(object sender, EventArgs e)
        {
            mostrarPlanillero();
        }

        private void mostrarPlanillero()
        {
            clsPsensei objetoPsensei = new clsPsensei();
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoDplanillero.insertarPlanillero(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se agrego correctamente al nuevo usuario");
                mostrarPlanillero();
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
                objetoDplanillero.actualizarPlanillero(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se actualizo correctamente el usuario");
                mostrarPlanillero();
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
                objetoDplanillero.eliminarPlanillero(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se elimino correctamente el usuario");
                mostrarPlanillero();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el usuario por: " + ex);

            }
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (tblPlanillero.SelectedRows.Count > 0)
            {
                txtCedula.Text = tblPlanillero.CurrentRow.Cells["Cedula"].Value.ToString();
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
            cmbCargos.Items.Clear();
            txtNombre.Clear();
            txtContrasena.Clear();
            cmbCargos.Items.Clear();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Close();
            VtnPrincipal ventana = new VtnPrincipal();
            ventana.AbrirVentana<VtnUsuarios>();
            ventana.Show();
        }
    }
}
