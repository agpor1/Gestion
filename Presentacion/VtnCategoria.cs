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
    public partial class VtnCategoria : Form
    {
        private clsDcategoria objetoCategoria = new clsDcategoria();

        public VtnCategoria()
        {
            InitializeComponent();

            cmbFiltro.Items.AddRange(new string[] {
            " ",
            "peso",
            "edad",
            "sexo",
            });
            cmbFiltro.SelectedIndex = 0; // Seleccion vacia por defecto


        }

        private void VtnCategoria_Load(object sender, EventArgs e)
        {
            actualizar();
            ConfigurarControles();
            CambiarIdioma(GestorIdiomas.Idioma);
            this.Resize += VtnCategoria_Resize;
            manejarPermisos();
        }


        public void actualizar()
        {
            clsDcategoria unDu = new clsDcategoria();
            tblCategoria.DataSource = unDu.listarCategoria();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSexo.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return; // Sale del método si hay algún campo vacío
            }
            try
            {
                objetoCategoria.insertarCategoria(txtId.Text, txtNombre.Text, txtSexo.Text, txtEdad.Text, txtPeso.Text);
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
                objetoCategoria.actualizarCategoria(txtId.Text, txtNombre.Text, txtSexo.Text, txtEdad.Text, txtPeso.Text);
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
            if (tblCategoria.SelectedRows.Count > 0)
            {
                txtId.Text = tblCategoria.CurrentRow.Cells["idCategoria"].Value.ToString();
                txtNombre.Text = tblCategoria.CurrentRow.Cells["nombre"].Value.ToString();
                txtSexo.Text = tblCategoria.CurrentRow.Cells["sexo"].Value.ToString();
                txtEdad.Text = tblCategoria.CurrentRow.Cells["edad"].Value.ToString();
                txtPeso.Text = tblCategoria.CurrentRow.Cells["peso"].Value.ToString();

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
                objetoCategoria.eliminarCategoria(txtId.Text, txtNombre.Text, txtSexo.Text, txtEdad.Text, txtPeso.Text);
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
            txtEdad.Clear();
            txtSexo.Clear();
            txtPeso.Clear();
            txtNombre.Clear();
            
        }

        public void AjustarTabla()
        {
            if (tblCategoria.InvokeRequired)
            {
                tblCategoria.Invoke(new Action(AjustarTabla));
                return;
            }
        }
        private void ConfigurarControles()
        {
            // Configurar la tabla
            tblCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            AjustarTabla();
        }
        private void VtnCategoria_Resize(object sender, EventArgs e)
        {
            AjustarTabla();
        }



        private void CambiarIdioma(string idioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            ActualizarIdioma();
        }
        private void ActualizarIdioma()
        {
            lblPeso.Text = Lenguajes.Peso;
            lblEdad.Text = Lenguajes.Edad;
            lblNombre.Text = Lenguajes.Nombre;
            lblSexo.Text = Lenguajes.Sexo;
            btnGuardar.Text = Lenguajes.Guardar;
            btnModificar.Text = Lenguajes.Modificar;
            btnRellenar.Text = Lenguajes.Rellenar;
            btnEliminar.Text = Lenguajes.Eliminar;
            lblBuscar.Text = Lenguajes.Buscar;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cmbFiltro.SelectedIndex = 0;
            tblCategoria.DataSource = objetoCategoria.ListarCategoriaPorFiltro("", "");
            tblCategoria.Refresh();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscar.Text;
            string tipoFiltro = cmbFiltro.SelectedItem?.ToString() ?? "";

            // Validación 
            if (tipoFiltro == "edad" && !string.IsNullOrEmpty(valorBusqueda))
            {
                if (!valorBusqueda.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor ingrese solo números para la edad");
                    return;
                }
            }

            tblCategoria.DataSource = objetoCategoria.ListarCategoriaPorFiltro(valorBusqueda, tipoFiltro);
            tblCategoria.Refresh();
        }
        private void manejarPermisos()
        {
            if (LoginUsuarioCache.Rol == Cargos.Estandar)
            {
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnRellenar.Visible = false;
                txtId.Visible = false;
                txtNombre.Visible = false;
                txtSexo.Visible = false;
                txtEdad.Visible = false;
                txtPeso.Visible = false;
                lblId.Visible = false;
                lblNombre.Visible = false;
                lblSexo.Visible = false;
                lblEdad.Visible = false;
                lblPeso.Visible = false;
            }
        }

    }
}
