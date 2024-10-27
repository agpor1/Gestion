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
    public partial class VtnDojos : Form
    {
        private clsDdojo objetoTorneo = new clsDdojo();
        clsPdojo objetoPtorneo = new clsPdojo();
        public VtnDojos()
        {
            InitializeComponent();
        }
        private void VtnDojos_Load(object sender, EventArgs e)
        {
            actualizar();
            CargarEscuela();
            CargarAtleta();
            CambiarIdioma(GestorIdiomas.Idioma);

        }
        public void actualizar()
        {
            clsDdojo unDu = new clsDdojo();
            tblDojos.DataSource = unDu.listarDojo();
        }

        private void CargarEscuela()
        {
            try
            {
                clsDescuela escuelasDatos = new clsDescuela();

                List<clsEescuela> escuelas = escuelasDatos.ObtenerEscuelas();

                if (escuelas != null)
                {
                    clsEescuela escuelaVacia = new clsEescuela { idEscuela = 0, nombre = "" };
                    escuelas.Insert(0, escuelaVacia);

                    cmbEscuelas.DataSource = escuelas;
                    cmbEscuelas.DisplayMember = "nombre";
                    cmbEscuelas.ValueMember = "idEscuela";

                    cmbEscuelas.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron escuelas.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar las escuelas: " + ex.Message);
            }
        }
        private void CargarAtleta()
        {
            try
            {
                clsDatletas atletasDatos = new clsDatletas();

                List<clsEatletas> atletas = atletasDatos.ObtenerAtletas();

                if (atletas != null)
                {
                    clsEatletas atletasVacio = new clsEatletas { Cedula = 0 };
                    atletas.Insert(0, atletasVacio);

                    cmbDocAtleta.DataSource = atletas;
                    cmbDocAtleta.DisplayMember = "Cedula";
                    cmbDocAtleta.ValueMember = "Cedula";

                    cmbDocAtleta.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron altetas.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los altetas: " + ex.Message);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEscuelaSeleccionada = (int)cmbEscuelas.SelectedValue;
                int docAtleta = (int)cmbDocAtleta.SelectedValue;
                objetoTorneo.insertarDojo(txtId.Text, idEscuelaSeleccionada, docAtleta, txtNombre.Text, txtIncriptos.Text);
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
                int idEscuelaSeleccionada = (int)cmbEscuelas.SelectedValue;
                int docAtleta = (int)cmbDocAtleta.SelectedValue;
                objetoTorneo.eliminarDojo(txtId.Text, idEscuelaSeleccionada, docAtleta, txtNombre.Text, txtIncriptos.Text);
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
                int idEscuelaSeleccionada = (int)cmbEscuelas.SelectedValue;
                int docAtleta = (int)cmbDocAtleta.SelectedValue;
                objetoTorneo.actualizarDojo(txtId.Text, idEscuelaSeleccionada, docAtleta, txtNombre.Text, txtIncriptos.Text);
                MessageBox.Show("Se actualizo correctamente el usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el usuario por: " + ex);

            }
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
            btnRellenar.Text = Lenguajes.Rellenar;
            btnEliminar.Text = Lenguajes.Eliminar;
            lblNombre.Text = Lenguajes.Nombre;
            //lbl.Text = Lenguajes.Alcance;
            //lblFechaInicio.Text = Lenguajes.FechaInicio;
            //lblFechaFin.Text = Lenguajes.FechaFin;
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            if (tblDojos.SelectedRows.Count > 0)
            {
                txtId.Text = tblDojos.CurrentRow.Cells["idDojo"].Value.ToString();
                cmbEscuelas.Text = tblDojos.CurrentRow.Cells["idEscuela"].Value.ToString();
                cmbDocAtleta.Text = tblDojos.CurrentRow.Cells["docAtleta"].Value.ToString();
                txtNombre.Text = tblDojos.CurrentRow.Cells["nombre"].Value.ToString();
                txtIncriptos.Text = tblDojos.CurrentRow.Cells["cantInscriptos"].Value.ToString();
            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }
        private void limpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtIncriptos.Clear();
            cmbEscuelas.Text = "";
            cmbDocAtleta.Text = "";
        }

     
    }
}
