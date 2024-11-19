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
    public partial class VtnCombate : Form
    {
        public VtnCombate()
        {
            InitializeComponent();
            ConfigurarCombates();

        }
        private void ConfigurarCombates()
        {
            btnInsertar.Click += (sender, e) => InsertarJugador();

            // Eventos para ComboBoxes de Octavos lado izquierdo
            cmbOctavos1I.SelectedIndexChanged += (sender, e) => ActualizarSemiFinales();
            cmbOctavos2I.SelectedIndexChanged += (sender, e) => ActualizarSemiFinales();
            cmbOctavos3I.SelectedIndexChanged += (sender, e) => ActualizarSemiFinales();
            cmbOctavos4I.SelectedIndexChanged += (sender, e) => ActualizarSemiFinales();

            // Eventos para ComboBoxes de Octavos lado derecho
            cmbOctavos1D.SelectedIndexChanged += (sender, e) => ActualizarSemiFinales();
            cmbOctavos2D.SelectedIndexChanged += (sender, e) => ActualizarSemiFinales();
            cmbOctavos3D.SelectedIndexChanged += (sender, e) => ActualizarSemiFinales();
            cmbOctavos3D.SelectedIndexChanged += (sender, e) => ActualizarSemiFinales();

            // Eventos para ComboBoxes de semifinales
            cmbSemi1I.SelectedIndexChanged += (sender, e) => ActualizarFinales();
            cmbSemi2I.SelectedIndexChanged += (sender, e) => ActualizarFinales();
            cmbSemi1D.SelectedIndexChanged += (sender, e) => ActualizarFinales();
            cmbSemi2D.SelectedIndexChanged += (sender, e) => ActualizarFinales();

            // Eventos para ComboBoxes de finales
            cmbFinal1.SelectedIndexChanged += (sender, e) =>
            {
                if (cmbFinal1.SelectedItem != null && cmbFinal2.SelectedItem != null)
                {
                    // Aquí podrías determinar el ganador final si lo necesitas
                }
            };

            cmbFinal2.SelectedIndexChanged += (sender, e) =>
            {
                if (cmbFinal1.SelectedItem != null && cmbFinal2.SelectedItem != null)
                {
                    // Aquí podrías determinar el ganador final si lo necesitas
                }
            };
        }

        private void InsertarJugador()
        {
            string nombre = txtNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                // Array con todos los TextBox de la primera ronda
                TextBox[] primeraRonda = { txt1I, txt2I, txt3I, txt4I, txt5I, txt6I, txt7I, txt8I,
                                    txt1D, txt2D, txt3D, txt4D, txt5D, txt6D, txt7D, txt8D };

                // Lista para almacenar los TextBox vacíos
                List<TextBox> vacios = new List<TextBox>();

                // Buscar TextBox vacíos
                foreach (TextBox tf in primeraRonda)
                {
                    if (string.IsNullOrEmpty(tf.Text))
                    {
                        vacios.Add(tf);
                    }
                }

                // Si hay TextBox vacíos, seleccionar uno aleatoriamente
                if (vacios.Count > 0)
                {
                    Random random = new Random();
                    int indiceAleatorio = random.Next(vacios.Count); // Índice aleatorio dentro de la lista de vacíos
                    vacios[indiceAleatorio].Text = nombre;
                    txtNombre.Clear();
                    ActualizarOctavos();
                }
                else
                {
                    MessageBox.Show("No hay espacios disponibles", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                }
            }
        }


        private void ActualizarOctavos()
        {
            // Actualizar semifinales lado izquierdo
            ActualizarComboBoxOctavos(txt1I, txt2I, cmbOctavos1I);
            ActualizarComboBoxOctavos(txt3I, txt4I, cmbOctavos2I);
            ActualizarComboBoxOctavos(txt5I, txt6I, cmbOctavos3I);
            ActualizarComboBoxOctavos(txt7I, txt8I, cmbOctavos4I);

            // Actualizar semifinales lado derecho
            ActualizarComboBoxOctavos(txt1D, txt2D, cmbOctavos1D);
            ActualizarComboBoxOctavos(txt3D, txt4D, cmbOctavos2D);
            ActualizarComboBoxOctavos(txt5D, txt6D, cmbOctavos3D);
            ActualizarComboBoxOctavos(txt7D, txt8D, cmbOctavos4D);
        }

        private void ActualizarComboBoxOctavos(TextBox txt1, TextBox txt2, ComboBox cmb)
        {
            cmb.Items.Clear();
            if (!string.IsNullOrEmpty(txt1.Text))
                cmb.Items.Add(txt1.Text);
            if (!string.IsNullOrEmpty(txt2.Text))
                cmb.Items.Add(txt2.Text);
        }

        private void ActualizarSemiFinales()
        {
            // Actualizar semifinales lado izquierdo
            cmbSemi1I.Items.Clear();
            if (cmbOctavos1I.SelectedItem != null)
                cmbSemi1I.Items.Add(cmbOctavos1I.SelectedItem);
            if (cmbOctavos2I.SelectedItem != null)
                cmbSemi1I.Items.Add(cmbOctavos2I.SelectedItem);

            cmbSemi2I.Items.Clear();
            if (cmbOctavos3I.SelectedItem != null)
                cmbSemi2I.Items.Add(cmbOctavos3I.SelectedItem);
            if (cmbOctavos4I.SelectedItem != null)
                cmbSemi2I.Items.Add(cmbOctavos4I.SelectedItem);

            // Actualizar semifinales lado derecho
            cmbSemi1D.Items.Clear();
            if (cmbOctavos1D.SelectedItem != null)
                cmbSemi1D.Items.Add(cmbOctavos1D.SelectedItem);
            if (cmbOctavos2D.SelectedItem != null)
                cmbSemi1D.Items.Add(cmbOctavos2D.SelectedItem);

            cmbSemi2D.Items.Clear();
            if (cmbOctavos3D.SelectedItem != null)
                cmbSemi2D.Items.Add(cmbOctavos3D.SelectedItem);
            if (cmbOctavos4D.SelectedItem != null)
                cmbSemi2D.Items.Add(cmbOctavos4D.SelectedItem);
        }

        private void ActualizarFinales()
        {
            // Actualizar final lado izquierdo
            cmbFinal1.Items.Clear();
            if (cmbSemi1I.SelectedItem != null)
                cmbFinal1.Items.Add(cmbSemi1I.SelectedItem);
            if (cmbSemi2I.SelectedItem != null)
                cmbFinal1.Items.Add(cmbSemi2I.SelectedItem);

            // Actualizar final lado derecho
            cmbFinal2.Items.Clear();
            if (cmbSemi1D.SelectedItem != null)
                cmbFinal2.Items.Add(cmbSemi1D.SelectedItem);
            if (cmbSemi2D.SelectedItem != null)
                cmbFinal2.Items.Add(cmbSemi2D.SelectedItem);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt1D.Clear();
            txt2D.Clear();
            txt3D.Clear();
            txt4D.Clear();
            txt5D.Clear();
            txt6D.Clear();  
            txt7D.Clear();
            txt8D.Clear();
            txt1I.Clear();
            txt2I.Clear();
            txt3I.Clear();
            txt4I.Clear();
            txt5I.Clear();
            txt6I.Clear();
            txt7I.Clear();
            txt8I.Clear();
            cmbFinal1.Text = "";
            cmbFinal2.Text = "";
            cmbSemi1D.Text = "";
            cmbSemi1I.Text = "";
            cmbSemi2D.Text = "";
            cmbSemi2I.Text = "";
            txtNombre.Clear();
        }
    }
}
