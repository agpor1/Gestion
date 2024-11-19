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
    public partial class VtnAtletas : Form
    {
        private clsDatletas objetoAtletas = new clsDatletas();
        clsPatletas objetoPatletas = new clsPatletas();
        public VtnAtletas()
        {
            InitializeComponent();
            this.Resize += VtnAtletas_Resize;
            ConfigurarControles();
            cmbFiltro.Items.AddRange(new string[] {
            " ",
            "pais",
            "cedula",
            "sexo",
            });
            cmbFiltro.SelectedIndex = 0; // Queda vacio por defecto
        }
        private void VtnAtletas_Load(object sender, EventArgs e)
        {
            actualizar();
            CargarCategorias();
            CambiarIdioma(GestorIdiomas.Idioma);
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
            this.Dispose();
            VtnPrincipal ventana = new VtnPrincipal();
            ventana.AbrirVentana<VtnUsuarios>();
            ventana.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                cmbCategorias.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCarnetF.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text) ||
                string.IsNullOrWhiteSpace(txtPais.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSexo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return; // Sale del método si hay algún campo vacío
            }
            // Verificar si el usuario ya existe
            if (objetoAtletas.verificarExistenciaUsuario(txtCedula.Text))
            {
                MessageBox.Show("Este usuario ya existe.");
                return; // Sale del método si el usuario ya existe
            }
            try
            {
                int idCategoriaSeleccionada = (int)cmbCategorias.SelectedValue;
                objetoAtletas.insertarAtletas(txtCedula.Text, idCategoriaSeleccionada, txtCarnetF.Text, dtFecha.Value.ToString("yyyy-MM-dd"), txtPeso.Text, txtSexo.Text, txtPais.Text, txtNombre.Text, txtApellido.Text);
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
            // Verifica que el campo de cedula no este vacío
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Por favor, complete el campo de cedula antes de eliminar.");
                return; // Sale del método si hay algún campo vacío
            }
            try
            {
                objetoAtletas.eliminarAtletas(txtCedula.Text, txtCarnetF.Text, dtFecha.Value.ToString("yyyy-MM-dd"), txtPeso.Text, txtSexo.Text, txtPais.Text, txtNombre.Text, txtApellido.Text);
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
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                cmbCategorias.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete el campo de categoria antes de modificar.");
                return; // Sale del método si hay algún campo vacío
            }
            try
            {
                int idCategoriaSeleccionada = (int)cmbCategorias.SelectedValue;
                objetoAtletas.actualizarAtletas(txtCedula.Text, idCategoriaSeleccionada, txtCarnetF.Text, dtFecha.Value.ToString("yyyy-MM-dd"), txtPeso.Text, txtSexo.Text, txtPais.Text, txtNombre.Text, txtApellido.Text);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscar.Text;
            string tipoFiltro = cmbFiltro.SelectedItem?.ToString() ?? "";

            // Validación 
            if (tipoFiltro == "cedula" && !string.IsNullOrEmpty(valorBusqueda))
            {
                if (!valorBusqueda.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor ingrese solo números para el documento");
                    return;
                }
            }

            tblAtletas.DataSource = objetoAtletas.ListarAtletasPorFiltro(valorBusqueda, tipoFiltro);
            tblAtletas.Refresh();
        }
        public void AjustarTabla()
        {
            if (tblAtletas.InvokeRequired)
            {
                tblAtletas.Invoke(new Action(AjustarTabla));
                return;
            }
        }
        private void ConfigurarControles()
        {
            // Configurar la tabla
            tblAtletas.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            AjustarTabla();
        }
        private void VtnAtletas_Resize(object sender, EventArgs e)
        {
            AjustarTabla();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cmbFiltro.SelectedIndex = 0;
            tblAtletas.DataSource = objetoAtletas.ListarAtletasPorFiltro("", "");
            tblAtletas.Refresh();
        }

        private void CambiarIdioma(string idioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            ActualizarIdioma();
        }

        private void ActualizarIdioma()
        {
            btnGuardar.Text = Lenguajes.Guardar;
            btnModificar.Text = Lenguajes.Modificar;
            btnListar.Text = Lenguajes.Rellenar;
            btnEliminar.Text = Lenguajes.Eliminar;
            btnAtras.Text = Lenguajes.Atras;
            lblBuscar.Text = Lenguajes.Buscar;
            lblCedula.Text = Lenguajes.Cedula;
            lblNombre.Text = Lenguajes.Nombre;
            lblApellido.Text = Lenguajes.Apellido;
            lblPeso.Text = Lenguajes.Peso;
            lblSexo.Text = Lenguajes.Sexo;
            lblPais.Text = Lenguajes.Pais;
            lblCarnetF.Text = Lenguajes.CarneF;
            lblFechaNac.Text = Lenguajes.FechaNac;
            lblCategoria.Text = Lenguajes.Categorias;
            lblFiltrar.Text = Lenguajes.Filtrar;
        }


    }
}
