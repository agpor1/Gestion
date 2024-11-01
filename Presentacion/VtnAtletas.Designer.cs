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
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCedula = new TextBox();
            lblCedula = new Label();
            tblAtletas = new DataGridView();
            btnListar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAtras = new Button();
            txtCarnetF = new TextBox();
            lblCarnetF = new Label();
            txtPais = new TextBox();
            lblPais = new Label();
            txtSexo = new TextBox();
            lblSexo = new Label();
            lblFechaNac = new Label();
            cmbCategorias = new ComboBox();
            lblCategoria = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dtFecha = new DateTimePicker();
            cmbFiltro = new ComboBox();
            lblFiltrar = new Label();
            btnLimpiar = new Button();
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
            btnGuardar.Location = new Point(12, 417);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(112, 167);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(232, 23);
            txtPeso.TabIndex = 40;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(12, 170);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 39;
            lblPeso.Text = "Peso";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(112, 138);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 23);
            txtApellido.TabIndex = 38;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 141);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 37;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 36;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 112);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 35;
            lblNombre.Text = "Nombre";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(112, 80);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(232, 23);
            txtCedula.TabIndex = 34;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(12, 83);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 33;
            lblCedula.Text = "Cedula";
            // 
            // tblAtletas
            // 
            tblAtletas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAtletas.Location = new Point(562, 83);
            tblAtletas.Name = "tblAtletas";
            tblAtletas.RightToLeft = RightToLeft.Yes;
            tblAtletas.Size = new Size(576, 326);
            tblAtletas.TabIndex = 32;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(174, 417);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 31;
            btnListar.Text = "Rellenar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(93, 417);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(255, 417);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(12, 607);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 43;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtCarnetF
            // 
            txtCarnetF.Location = new Point(112, 254);
            txtCarnetF.Name = "txtCarnetF";
            txtCarnetF.Size = new Size(232, 23);
            txtCarnetF.TabIndex = 51;
            // 
            // lblCarnetF
            // 
            lblCarnetF.AutoSize = true;
            lblCarnetF.Location = new Point(12, 257);
            lblCarnetF.Name = "lblCarnetF";
            lblCarnetF.Size = new Size(94, 15);
            lblCarnetF.TabIndex = 50;
            lblCarnetF.Text = "Carnet Federado";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(112, 225);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(232, 23);
            txtPais.TabIndex = 47;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(12, 228);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 46;
            lblPais.Text = "Pais";
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(112, 196);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(232, 23);
            txtSexo.TabIndex = 45;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(12, 199);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 44;
            lblSexo.Text = "Sexo";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(12, 286);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(103, 15);
            lblFechaNac.TabIndex = 52;
            lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(112, 321);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(121, 23);
            cmbCategorias.TabIndex = 55;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(48, 321);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 54;
            lblCategoria.Text = "Categoria";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(980, 57);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 108;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(1028, 54);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(110, 23);
            txtBuscar.TabIndex = 107;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dtFecha
            // 
            dtFecha.CustomFormat = "yyyy-MM-dd";
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(112, 283);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(121, 23);
            dtFecha.TabIndex = 155;
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(626, 54);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(58, 23);
            cmbFiltro.TabIndex = 156;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Location = new Point(562, 57);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(58, 15);
            lblFiltrar.TabIndex = 157;
            lblFiltrar.Text = "Filtrar por";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(562, 417);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 23);
            btnLimpiar.TabIndex = 158;
            btnLimpiar.Text = "Limpiar Filtro";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // VtnAtletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 642);
            Controls.Add(btnLimpiar);
            Controls.Add(lblFiltrar);
            Controls.Add(cmbFiltro);
            Controls.Add(dtFecha);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(cmbCategorias);
            Controls.Add(lblCategoria);
            Controls.Add(lblFechaNac);
            Controls.Add(txtCarnetF);
            Controls.Add(lblCarnetF);
            Controls.Add(txtPais);
            Controls.Add(lblPais);
            Controls.Add(txtSexo);
            Controls.Add(lblSexo);
            Controls.Add(btnAtras);
            Controls.Add(btnGuardar);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
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
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCedula;
        private Label lblCedula;
        private DataGridView tblAtletas;
        private Button btnListar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAtras;
        private TextBox txtCarnetF;
        private Label lblCarnetF;
        private TextBox txtPais;
        private Label lblPais;
        private TextBox txtSexo;
        private Label lblSexo;
        private Label lblFechaNac;
        private ComboBox cmbCategorias;
        private Label lblCategoria;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DateTimePicker dtFecha;
        private ComboBox cmbFiltro;
        private Label lblFiltrar;
        private Button btnLimpiar;
    }
}