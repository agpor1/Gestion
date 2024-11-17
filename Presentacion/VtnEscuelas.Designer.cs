namespace Presentacion
{
    partial class VtnEscuelas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtMedallero = new TextBox();
            lblMedallero = new Label();
            btnGuardar = new Button();
            lblFechaCreacion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtId = new TextBox();
            lblId = new Label();
            btnRellenar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            tblEscuela = new DataGridView();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            dtFecha = new DateTimePicker();
            lblFiltrar = new Label();
            cmbFiltro = new ComboBox();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)tblEscuela).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(122, 201);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(232, 23);
            txtDireccion.TabIndex = 151;
            txtDireccion.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(9, 204);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 150;
            lblDireccion.Text = "Direccion";
            // 
            // txtMedallero
            // 
            txtMedallero.Location = new Point(122, 143);
            txtMedallero.Name = "txtMedallero";
            txtMedallero.Size = new Size(232, 23);
            txtMedallero.TabIndex = 149;
            txtMedallero.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMedallero
            // 
            lblMedallero.AutoSize = true;
            lblMedallero.Location = new Point(9, 146);
            lblMedallero.Name = "lblMedallero";
            lblMedallero.Size = new Size(60, 15);
            lblMedallero.TabIndex = 148;
            lblMedallero.Text = "Medallero";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(11, 382);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 147;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblFechaCreacion
            // 
            lblFechaCreacion.AutoSize = true;
            lblFechaCreacion.Location = new Point(9, 175);
            lblFechaCreacion.Name = "lblFechaCreacion";
            lblFechaCreacion.Size = new Size(104, 15);
            lblFechaCreacion.TabIndex = 145;
            lblFechaCreacion.Text = "Fecha de Creacion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 144;
            txtNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 113);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 143;
            lblNombre.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(122, 80);
            txtId.Name = "txtId";
            txtId.Size = new Size(232, 23);
            txtId.TabIndex = 142;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(11, 83);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 141;
            lblId.Text = "Id";
            // 
            // btnRellenar
            // 
            btnRellenar.Location = new Point(173, 382);
            btnRellenar.Name = "btnRellenar";
            btnRellenar.Size = new Size(75, 23);
            btnRellenar.TabIndex = 140;
            btnRellenar.Text = "Rellenar";
            btnRellenar.UseVisualStyleBackColor = true;
            btnRellenar.Click += btnRellenar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(92, 382);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 139;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(254, 382);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 138;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tblEscuela
            // 
            tblEscuela.AllowUserToAddRows = false;
            tblEscuela.AllowUserToDeleteRows = false;
            tblEscuela.AllowUserToResizeColumns = false;
            tblEscuela.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tblEscuela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tblEscuela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblEscuela.Location = new Point(495, 83);
            tblEscuela.Name = "tblEscuela";
            tblEscuela.ReadOnly = true;
            tblEscuela.RightToLeft = RightToLeft.Yes;
            tblEscuela.Size = new Size(526, 326);
            tblEscuela.TabIndex = 137;
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
            panelBarraTitulo.TabIndex = 136;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Location = new Point(4495, 12);
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
            btnMaximizar.Location = new Point(4461, 12);
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
            btnMinimiza.Location = new Point(4495, 12);
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
            btnCerrar.Location = new Point(4529, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(122, 175);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(232, 23);
            dtFecha.TabIndex = 154;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Location = new Point(493, 57);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(58, 15);
            lblFiltrar.TabIndex = 161;
            lblFiltrar.Text = "Filtrar por";
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(557, 54);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(108, 23);
            cmbFiltro.TabIndex = 160;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(863, 57);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 159;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(911, 54);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(110, 23);
            txtBuscar.TabIndex = 158;
            txtBuscar.TextAlign = HorizontalAlignment.Right;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(495, 415);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 23);
            btnLimpiar.TabIndex = 162;
            btnLimpiar.Text = "Limpiar Filtro";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // VtnEscuelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 611);
            Controls.Add(btnLimpiar);
            Controls.Add(lblFiltrar);
            Controls.Add(cmbFiltro);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dtFecha);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtMedallero);
            Controls.Add(lblMedallero);
            Controls.Add(btnGuardar);
            Controls.Add(lblFechaCreacion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnRellenar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(tblEscuela);
            Controls.Add(panelBarraTitulo);
            Name = "VtnEscuelas";
            Text = "VtnEscuelas";
            Load += VtnEscuelas_Load;
            ((System.ComponentModel.ISupportInitialize)tblEscuela).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtMedallero;
        private Label lblMedallero;
        private Button btnGuardar;
        private Label lblFechaCreacion;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
        private Button btnRellenar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView tblEscuela;
        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimiza;
        private PictureBox btnCerrar;
        private DateTimePicker dtFecha;
        private Label lblFiltrar;
        private ComboBox cmbFiltro;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnLimpiar;
    }
}