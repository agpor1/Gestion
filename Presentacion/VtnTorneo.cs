using Dominio;
using Entidad;
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
    public partial class VtnTorneo : Form
    {
        private clsDtorneo objetoTorneo = new clsDtorneo();
        clsPatletas objetoPatletas = new clsPatletas();

        public VtnTorneo()
        {
            InitializeComponent();
        }

        private void VtnTorneo_Load(object sender, EventArgs e)
        {
            actualizar();
            CargarEscuela();
            //CargarPool();
        }
        public void actualizar()
        {
            clsDtorneo unDu = new clsDtorneo();
            tblTorneo.DataSource = unDu.listarTorneos();
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
        //private void CargarPool()
        //{
        //    try
        //    {
        //        clsDpool senseiDatos = new clsDpool();
        //        List<clsEpool> pools = senseiDatos.ObtenerPools();

        //        if (pools != null && pools.Count > 0)
        //        {

        //            clsEsensei poolVacio = new clsEsensei { Cedula = 0 };
        //            pools.Insert(0, poolVacio);

        //            cmbPool.DataSource = senseis;

        //            cmbPool.DisplayMember = "Cedula";
        //            cmbPool.ValueMember = "Cedula";

        //            cmbPool.SelectedIndex = 0;
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontraron pools.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar los pools: " + ex.Message);
        //    }
        ////}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoTorneo.insertarTorneo(txtId.Text, cmbPool.SelectedItem.ToString(), cmbEscuelas.SelectedValue.ToString(), txtNombre.Text, txtAlcance.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaFin.Value.ToString("yyyy-MM-dd"));
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
                objetoTorneo.eliminarTorneo(txtId.Text, cmbPool.SelectedItem.ToString(), cmbEscuelas.SelectedItem.ToString(), txtNombre.Text, txtAlcance.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaFin.Value.ToString("yyyy-MM-dd"));
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
                objetoTorneo.actualizarTorneo(txtId.Text, cmbPool.SelectedItem.ToString(), cmbEscuelas.SelectedItem.ToString(), txtNombre.Text, txtAlcance.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaFin.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Se actualizo correctamente el usuario");
                actualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el usuario por: " + ex);

            }
        }


        private void limpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtAlcance.Clear();
            cmbEscuelas.Text = "";
            cmbPool.Text = "";
        }

    }
}
