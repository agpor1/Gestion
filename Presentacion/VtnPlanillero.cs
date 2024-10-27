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
    public partial class VtnPlanillero : Form
    {
        private clsDplanillero objetoDplanillero = new clsDplanillero();
        clsPplanillero objetoPplanillero = new clsPplanillero();
        public VtnPlanillero()
        {
            InitializeComponent();
        }

        private void VtnPlanillero_Load(object sender, EventArgs e)
        {
            actualizar();
            CambiarIdioma(GestorIdiomas.Idioma);
        }

        public void actualizar()
        {
            clsDplanillero unDu = new clsDplanillero();
            tblPlanillero.DataSource = unDu.listarPlanillero();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoDplanillero.insertarPlanillero(txtCedula.Text, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se agrego correctamente al nuevo planillero");
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
                objetoDplanillero.actualizarPlanillero(txtCedula.Text, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, cmbCargos.SelectedItem.ToString(), txtContrasena.Text);
                MessageBox.Show("Se actualizo correctamente al planillero");
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
                objetoDplanillero.eliminarPlanillero(txtCedula.Text, txtNombre.Text, txtSegundoName.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, txtNac.Text, txtContrasena.Text);
                MessageBox.Show("Se elimino correctamente el planillero");
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
            if (tblPlanillero.SelectedRows.Count > 0)
            {
                txtCedula.Text = tblPlanillero.CurrentRow.Cells["cedula"].Value.ToString();
                txtNombre.Text = tblPlanillero.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = tblPlanillero.CurrentRow.Cells["apellido"].Value.ToString();
                txtEmail.Text = tblPlanillero.CurrentRow.Cells["email"].Value.ToString();
                txtNac.Text = tblPlanillero.CurrentRow.Cells["nacionalidad"].Value.ToString();
                cmbCargos.Text = tblPlanillero.CurrentRow.Cells["rol"].Value.ToString();

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
            cmbCargos.Text = "";
            txtNombre.Clear();
            txtContrasena.Clear();
            txtSegundoApellido.Clear();
            txtSegundoName.Clear();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            VtnPrincipal ventana = new VtnPrincipal();
            ventana.AbrirVentana<VtnUsuarios>();
            ventana.Show();
        }
    }
}
