namespace Presentacion
{
    partial class VtnAtletas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            btnGuardar = new Button();
            txtPeso = new TextBox();
            lblPeso = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCedula = new TextBox();
            label1 = new Label();
            tblAtletas = new DataGridView();
            btnListar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAtras = new Button();
            txtCarnetF = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            llblCorreo = new Label();
            txtPais = new TextBox();
            lblPais = new Label();
            txtSexo = new TextBox();
            label8 = new Label();
            txtFechanac = new TextBox();
            label12 = new Label();
            cmbCategorias = new ComboBox();
            label4 = new Label();
            cmbSensei = new ComboBox();
            label6 = new Label();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblAtletas).BeginInit();
            SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.FromArgb(37, 47, 66);
            panelBarraTitulo.Controls.Add(btnRestaurar);
            panelBarraTitulo.Controls.Add(btnMaximizar);
            panelBarraTitulo.Controls.Add(btnMinimiza);
            panelBarraTitulo.Controls.Add(btnCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1237, 45);
            panelBarraTitulo.TabIndex = 16;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Location = new Point(3458, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(28, 18);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 15;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Location = new Point(3424, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(28, 18);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 14;
            btnMaximizar.TabStop = false;
            // 
            // btnMinimiza
            // 
            btnMinimiza.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimiza.Cursor = Cursors.Hand;
            btnMinimiza.Location = new Point(3458, 12);
            btnMinimiza.Name = "btnMinimiza";
            btnMinimiza.Size = new Size(28, 18);
            btnMinimiza.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimiza.TabIndex = 11;
            btnMinimiza.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(3492, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 66);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(385, 150);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(232, 23);
            txtPeso.TabIndex = 40;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(321, 153);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 39;
            lblPeso.Text = "Peso";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(385, 121);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 23);
            txtApellido.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 124);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 37;
            label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(385, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 35;
            label2.Text = "Nombre";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(385, 63);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(232, 23);
            txtCedula.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 66);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 33;
            label1.Text = "Cedula";
            // 
            // tblAtletas
            // 
            tblAtletas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAtletas.Location = new Point(649, 63);
            tblAtletas.Name = "tblAtletas";
            tblAtletas.Size = new Size(576, 326);
            tblAtletas.TabIndex = 32;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(12, 154);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 31;
            btnListar.Text = "Rellenar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 125);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 96);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(1150, 607);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 43;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtCarnetF
            // 
            txtCarnetF.Location = new Point(385, 266);
            txtCarnetF.Name = "txtCarnetF";
            txtCarnetF.Size = new Size(232, 23);
            txtCarnetF.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 269);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 50;
            label5.Text = "Carnet Federado";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(385, 237);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(232, 23);
            txtCorreo.TabIndex = 49;
            // 
            // llblCorreo
            // 
            llblCorreo.AutoSize = true;
            llblCorreo.Location = new Point(321, 240);
            llblCorreo.Name = "llblCorreo";
            llblCorreo.Size = new Size(43, 15);
            llblCorreo.TabIndex = 48;
            llblCorreo.Text = "Correo";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(385, 208);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(232, 23);
            txtPais.TabIndex = 47;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(321, 211);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 46;
            lblPais.Text = "Pais";
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(385, 179);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(232, 23);
            txtSexo.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(321, 182);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 44;
            label8.Text = "Sexo";
            // 
            // txtFechanac
            // 
            txtFechanac.Location = new Point(385, 295);
            txtFechanac.Name = "txtFechanac";
            txtFechanac.Size = new Size(232, 23);
            txtFechanac.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(285, 298);
            label12.Name = "label12";
            label12.Size = new Size(103, 15);
            label12.TabIndex = 52;
            label12.Text = "Fecha Nacimiento";
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(385, 333);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(121, 23);
            cmbCategorias.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 333);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 54;
            label4.Text = "Categoria";
            // 
            // cmbSensei
            // 
            cmbSensei.FormattingEnabled = true;
            cmbSensei.Location = new Point(385, 366);
            cmbSensei.Name = "cmbSensei";
            cmbSensei.Size = new Size(121, 23);
            cmbSensei.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 366);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 56;
            label6.Text = "Sensei";
            // 
            // VtnAtletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 642);
            Controls.Add(cmbSensei);
            Controls.Add(label6);
            Controls.Add(cmbCategorias);
            Controls.Add(label4);
            Controls.Add(txtFechanac);
            Controls.Add(label12);
            Controls.Add(txtCarnetF);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(llblCorreo);
            Controls.Add(txtPais);
            Controls.Add(lblPais);
            Controls.Add(txtSexo);
            Controls.Add(label8);
            Controls.Add(btnAtras);
            Controls.Add(btnGuardar);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCedula);
            Controls.Add(label1);
            Controls.Add(tblAtletas);
            Controls.Add(btnListar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(panelBarraTitulo);
            Name = "VtnAtletas";
            Load += VtnAtletas_Load;
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblAtletas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimiza;
        private PictureBox btnCerrar;
        private Button btnGuardar;
        private TextBox txtPeso;
        private Label lblPeso;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtCedula;
        private Label label1;
        private DataGridView tblAtletas;
        private Button btnListar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAtras;
        private TextBox txtCarnetF;
        private Label label5;
        private TextBox txtCorreo;
        private Label llblCorreo;
        private TextBox txtPais;
        private Label lblPais;
        private TextBox txtSexo;
        private Label label8;
        private TextBox txtFechanac;
        private Label label12;
        private ComboBox cmbCategorias;
        private Label label4;
        private ComboBox cmbSensei;
        private Label label6;
    }
}