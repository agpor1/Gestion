﻿using Dominio;
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
            CambiarIdioma(GestorIdiomas.Idioma);

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
      

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEscuelaSeleccionada = (int)cmbEscuelas.SelectedValue;
                objetoTorneo.insertarTorneo(txtId.Text, idEscuelaSeleccionada, txtNombre.Text, txtAlcance.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaFin.Value.ToString("yyyy-MM-dd"));
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
                objetoTorneo.eliminarTorneo(txtId.Text, idEscuelaSeleccionada, txtNombre.Text, txtAlcance.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaFin.Value.ToString("yyyy-MM-dd"));
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
                objetoTorneo.actualizarTorneo(txtId.Text, idEscuelaSeleccionada, txtNombre.Text, txtAlcance.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaFin.Value.ToString("yyyy-MM-dd"));
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
            lblAlcance.Text = Lenguajes.Alcance;
            lblFechaInicio.Text = Lenguajes.FechaInicio;
            lblFechaFin.Text = Lenguajes.FechaFin;
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            if (tblTorneo.SelectedRows.Count > 0)
            {
                txtId.Text = tblTorneo.CurrentRow.Cells["idTorneo"].Value.ToString();
                txtNombre.Text = tblTorneo.CurrentRow.Cells["Nombre"].Value.ToString();
                txtAlcance.Text = tblTorneo.CurrentRow.Cells["alcance"].Value.ToString();
                cmbEscuelas.Text = tblTorneo.CurrentRow.Cells["idEscuela"].Value.ToString();
            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }
        private void limpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtAlcance.Clear();
            cmbEscuelas.Text = "";
        }

    }
}
