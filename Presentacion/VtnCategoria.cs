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
            this.Resize += VtnCategoria_Resize;
            ConfigurarControles();
            CambiarIdioma(GestorIdiomas.Idioma);
        }

        private void VtnCategoria_Load(object sender, EventArgs e)
        {
            actualizar();
        }


        public void actualizar()
        {
            clsDcategoria unDu = new clsDcategoria();
            tblCategoria.DataSource = unDu.listarCategoria();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
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

            // Calcular el ancho disponible
            int margenIzquierdo = 400; // Espacio para el menú lateral
            int margenDerecho = 285;

            // Ajustar posición y tamaño de la tabla
            tblCategoria.Location = new Point(margenIzquierdo, tblCategoria.Location.Y);
            tblCategoria.Width = this.ClientSize.Width - margenIzquierdo - margenDerecho;

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
            btnAtras.Text = Lenguajes.Atras;
            lblNombre.Text = Lenguajes.Nombre;
            lblSexo.Text = Lenguajes.Sexo;
            btnGuardar.Text = Lenguajes.Guardar;
            btnModificar.Text = Lenguajes.Modificar;
            btnRellenar.Text = Lenguajes.Rellenar;
            btnEliminar.Text = Lenguajes.Eliminar;
            lblBuscar.Text = Lenguajes.Buscar;
        }


    }
}
