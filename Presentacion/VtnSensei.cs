using Dominio;
using Entidad.Cache;
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
    public partial class VtnSensei : Form
    {
        private clsDsensei objetoSensei = new clsDsensei();
        clsPsensei objetoPsensei = new clsPsensei();
        public VtnSensei()
        {
            InitializeComponent();
        }
        private void VtnSensei_Load(object sender, EventArgs e)
        {
            //mostrarSensei();
            actualizar();
        }
        public void actualizar()
        {
            clsDsensei unDu = new clsDsensei();
            tblSensei.DataSource = unDu.listarUsuarios();
        }
        //private void mostrarSensei()
        //{
        //    clsPsensei objetoPsensei = new clsPsensei();
        //    DataTable tabla = objetoPsensei.Mostrar();

        //    if (tabla != null && tabla.Rows.Count > 0)
        //    {
        //        tblSensei.DataSource = tabla;
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se encontraron datos o ocurrió un error al cargar los datos.");
        //    }
        //}
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoSensei.insertarSensei(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se agrego correctamente al nuevo usuario");
                //mostrarSensei();
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
                objetoSensei.actualizarSensei(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se actualizo correctamente el usuario");
                //mostrarSensei();
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
                objetoSensei.eliminarSensei(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se elimino correctamente el usuario");
                //mostrarSensei();
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
            cmbCargos.Items.Clear();
            txtNombre.Clear();
            txtContrasena.Clear();
            cmbCargos.Items.Clear();
        }
    }
}
