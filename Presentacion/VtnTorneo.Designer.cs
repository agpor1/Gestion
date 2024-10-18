namespace Presentacion
{
    partial class VtnTorneo
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
            dtFechaInicio = new DateTimePicker();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            txtAlcance = new TextBox();
            lblAlcance = new Label();
            btnGuardar = new Button();
            lblFechaInicio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtId = new TextBox();
            lblId = new Label();
            btnRellenar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            tblTorneo = new DataGridView();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            dtFechaFin = new DateTimePicker();
            lblFechaFin = new Label();
            cmbPool = new ComboBox();
            lblPool = new Label();
            cmbEscuelas = new ComboBox();
            lblEscuelas = new Label();
            ((System.ComponentModel.ISupportInitialize)tblTorneo).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Location = new Point(134, 171);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(232, 23);
            dtFechaInicio.TabIndex = 172;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(447, 53);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 171;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(495, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 170;
            // 
            // txtAlcance
            // 
            txtAlcance.Location = new Point(134, 139);
            txtAlcance.Name = "txtAlcance";
            txtAlcance.Size = new Size(232, 23);
            txtAlcance.TabIndex = 167;
            // 
            // lblAlcance
            // 
            lblAlcance.AutoSize = true;
            lblAlcance.Location = new Point(9, 142);
            lblAlcance.Name = "lblAlcance";
            lblAlcance.Size = new Size(49, 15);
            lblAlcance.TabIndex = 166;
            lblAlcance.Text = "Alcance";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(11, 378);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 165;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(9, 171);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(86, 15);
            lblFechaInicio.TabIndex = 164;
            lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 163;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 109);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 162;
            lblNombre.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(134, 76);
            txtId.Name = "txtId";
            txtId.Size = new Size(232, 23);
            txtId.TabIndex = 161;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(11, 79);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 160;
            lblId.Text = "Id";
            // 
            // btnRellenar
            // 
            btnRellenar.Location = new Point(173, 378);
            btnRellenar.Name = "btnRellenar";
            btnRellenar.Size = new Size(75, 23);
            btnRellenar.TabIndex = 159;
            btnRellenar.Text = "Rellenar";
            btnRellenar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(92, 378);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 158;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(254, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 157;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tblTorneo
            // 
            tblTorneo.AllowUserToAddRows = false;
            tblTorneo.AllowUserToDeleteRows = false;
            tblTorneo.AllowUserToResizeColumns = false;
            tblTorneo.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tblTorneo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            tblTorneo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblTorneo.Location = new Point(495, 79);
            tblTorneo.Name = "tblTorneo";
            tblTorneo.ReadOnly = true;
            tblTorneo.RightToLeft = RightToLeft.No;
            tblTorneo.Size = new Size(730, 326);
            tblTorneo.TabIndex = 156;
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
            panelBarraTitulo.TabIndex = 155;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Location = new Point(5532, 12);
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
            btnMaximizar.Location = new Point(5498, 12);
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
            btnMinimiza.Location = new Point(5532, 12);
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
            btnCerrar.Location = new Point(5566, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            // 
            // dtFechaFin
            // 
            dtFechaFin.Location = new Point(134, 200);
            dtFechaFin.Name = "dtFechaFin";
            dtFechaFin.Size = new Size(232, 23);
            dtFechaFin.TabIndex = 174;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(9, 200);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(119, 15);
            lblFechaFin.TabIndex = 173;
            lblFechaFin.Text = "Fecha de Finalizacion";
            // 
            // cmbPool
            // 
            cmbPool.FormattingEnabled = true;
            cmbPool.Location = new Point(134, 273);
            cmbPool.Name = "cmbPool";
            cmbPool.Size = new Size(121, 23);
            cmbPool.TabIndex = 178;
            // 
            // lblPool
            // 
            lblPool.AutoSize = true;
            lblPool.Location = new Point(9, 273);
            lblPool.Name = "lblPool";
            lblPool.Size = new Size(31, 15);
            lblPool.TabIndex = 177;
            lblPool.Text = "Pool";
            // 
            // cmbEscuelas
            // 
            cmbEscuelas.FormattingEnabled = true;
            cmbEscuelas.Location = new Point(134, 240);
            cmbEscuelas.Name = "cmbEscuelas";
            cmbEscuelas.Size = new Size(121, 23);
            cmbEscuelas.TabIndex = 176;
            // 
            // lblEscuelas
            // 
            lblEscuelas.AutoSize = true;
            lblEscuelas.Location = new Point(9, 240);
            lblEscuelas.Name = "lblEscuelas";
            lblEscuelas.Size = new Size(51, 15);
            lblEscuelas.TabIndex = 175;
            lblEscuelas.Text = "Escuelas";
            // 
            // VtnTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 611);
            Controls.Add(cmbPool);
            Controls.Add(lblPool);
            Controls.Add(cmbEscuelas);
            Controls.Add(lblEscuelas);
            Controls.Add(dtFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dtFechaInicio);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(txtAlcance);
            Controls.Add(lblAlcance);
            Controls.Add(btnGuardar);
            Controls.Add(lblFechaInicio);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnRellenar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(tblTorneo);
            Controls.Add(panelBarraTitulo);
            Name = "VtnTorneo";
            Text = "VtnTorneo";
            Load += VtnTorneo_Load;
            ((System.ComponentModel.ISupportInitialize)tblTorneo).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtFechaInicio;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private TextBox txtAlcance;
        private Label lblAlcance;
        private Button btnGuardar;
        private Label lblFechaInicio;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
        private Button btnRellenar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView tblTorneo;
        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimiza;
        private PictureBox btnCerrar;
        private DateTimePicker dtFechaFin;
        private Label lblFechaFin;
        private ComboBox cmbPool;
        private Label lblPool;
        private ComboBox cmbEscuelas;
        private Label lblEscuelas;
    }
}