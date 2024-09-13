using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Persistencia;
using Entidad.Cache;

namespace Presentacion
{
    public partial class VtnUsuarios : Form
    {
        private clsDusuarios objetoUsuario = new clsDusuarios();
        clsPusuarios objetoPusuario = new clsPusuarios();

        public VtnUsuarios()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VtnUsuarios_Load(object sender, EventArgs e)
        {
            actualizar();
        }

       
        public void actualizar()
        {
            clsDusuarios unDu = new clsDusuarios();
            tblPersona.DataSource = unDu.listarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoUsuario.insertarUsuario(txtCedula.Text, txtNombre.Text, txtApellido.Text,txtEmail.Text,txtNac.Text,cmbCargos.SelectedItem.ToString(),txtContrasena.Text);
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
                objetoUsuario.actualizarUsuario(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
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
                objetoUsuario.eliminarUsuarios(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
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
            if (tblPersona.SelectedRows.Count > 0)
            {
                txtCedula.Text = tblPersona.CurrentRow.Cells["cedula"].Value.ToString();
                txtNombre.Text = tblPersona.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = tblPersona.CurrentRow.Cells["apellido"].Value.ToString();
                txtEmail.Text = tblPersona.CurrentRow.Cells["email"].Value.ToString();
                txtNac.Text = tblPersona.CurrentRow.Cells["nacionalidad"].Value.ToString();
                cmbCargos.Text = tblPersona.CurrentRow.Cells["rol"].Value.ToString();
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

        
    }
}
