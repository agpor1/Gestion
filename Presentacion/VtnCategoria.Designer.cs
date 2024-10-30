namespace Presentacion
{
    partial class VtnCategoria
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtPeso = new TextBox();
            lblPeso = new Label();
            txtSexo = new TextBox();
            lblSexo = new Label();
            btnGuardar = new Button();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtId = new TextBox();
            lblId = new Label();
            btnRellenar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            tblCategoria = new DataGridView();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            btnAtras = new Button();
            lblFiltrar = new Label();
            cmbFiltro = new ComboBox();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)tblCategoria).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(107, 210);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(232, 23);
            txtPeso.TabIndex = 133;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(9, 213);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 132;
            lblPeso.Text = "Peso";
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(107, 152);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(232, 23);
            txtSexo.TabIndex = 131;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(9, 155);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 130;
            lblSexo.Text = "Sexo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(11, 391);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 124;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(107, 181);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(232, 23);
            txtEdad.TabIndex = 120;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(9, 184);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 119;
            lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 118;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 122);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 117;
            lblNombre.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 89);
            txtId.Name = "txtId";
            txtId.Size = new Size(232, 23);
            txtId.TabIndex = 116;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(11, 92);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 115;
            lblId.Text = "Id";
            // 
            // btnRellenar
            // 
            btnRellenar.Location = new Point(173, 391);
            btnRellenar.Name = "btnRellenar";
            btnRellenar.Size = new Size(75, 23);
            btnRellenar.TabIndex = 114;
            btnRellenar.Text = "Rellenar";
            btnRellenar.UseVisualStyleBackColor = true;
            btnRellenar.Click += btnRellenar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(92, 391);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 113;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(254, 391);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 112;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tblCategoria
            // 
            tblCategoria.AllowUserToAddRows = false;
            tblCategoria.AllowUserToDeleteRows = false;
            tblCategoria.AllowUserToResizeColumns = false;
            tblCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tblCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            tblCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblCategoria.Location = new Point(495, 92);
            tblCategoria.Name = "tblCategoria";
            tblCategoria.ReadOnly = true;
            tblCategoria.RightToLeft = RightToLeft.No;
            tblCategoria.Size = new Size(730, 326);
            tblCategoria.TabIndex = 111;
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
            panelBarraTitulo.TabIndex = 110;
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
            // btnAtras
            // 
            btnAtras.Location = new Point(9, 582);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 109;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Location = new Point(491, 66);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(58, 15);
            lblFiltrar.TabIndex = 184;
            lblFiltrar.Text = "Filtrar por";
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(555, 63);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(117, 23);
            cmbFiltro.TabIndex = 183;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(1066, 66);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 182;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(1114, 63);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(110, 23);
            txtBuscar.TabIndex = 181;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(495, 424);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 23);
            btnLimpiar.TabIndex = 185;
            btnLimpiar.Text = "Limpiar Filtro";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // VtnCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 611);
            Controls.Add(btnLimpiar);
            Controls.Add(lblFiltrar);
            Controls.Add(cmbFiltro);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtSexo);
            Controls.Add(lblSexo);
            Controls.Add(btnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnRellenar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(tblCategoria);
            Controls.Add(panelBarraTitulo);
            Controls.Add(btnAtras);
            Name = "VtnCategoria";
            Text = "VtnCategoria";
            Load += VtnCategoria_Load;
            Resize += VtnCategoria_Resize;
            ((System.ComponentModel.ISupportInitialize)tblCategoria).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPeso;
        private Label lblPeso;
        private TextBox txtSexo;
        private Label lblSexo;
        private Button btnGuardar;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
        private Button btnRellenar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView tblCategoria;
        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimiza;
        private PictureBox btnCerrar;
        private Button btnAtras;
        private Label lblFiltrar;
        private ComboBox cmbFiltro;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnLimpiar;
    }
}