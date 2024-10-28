namespace Presentacion
{
    partial class VtnDojos
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
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnGuardar = new Button();
            txtIncriptos = new TextBox();
            lblInscriptos = new Label();
            txtId = new TextBox();
            lblId = new Label();
            btnRellenar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            tblDojos = new DataGridView();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            cmbEscuelas = new ComboBox();
            lblEscuelas = new Label();
            cmbDocAtleta = new ComboBox();
            lblDocAtleta = new Label();
            ((System.ComponentModel.ISupportInitialize)tblDojos).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(447, 69);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 154;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(495, 66);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 153;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 184);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 150;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 187);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 149;
            lblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(11, 394);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 148;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtIncriptos
            // 
            txtIncriptos.Location = new Point(107, 213);
            txtIncriptos.Name = "txtIncriptos";
            txtIncriptos.Size = new Size(232, 23);
            txtIncriptos.TabIndex = 147;
            // 
            // lblInscriptos
            // 
            lblInscriptos.AutoSize = true;
            lblInscriptos.Location = new Point(11, 216);
            lblInscriptos.Name = "lblInscriptos";
            lblInscriptos.Size = new Size(86, 15);
            lblInscriptos.TabIndex = 146;
            lblInscriptos.Text = "Cant Inscriptos";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 92);
            txtId.Name = "txtId";
            txtId.Size = new Size(232, 23);
            txtId.TabIndex = 143;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(11, 95);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 142;
            lblId.Text = "Id";
            // 
            // btnRellenar
            // 
            btnRellenar.Location = new Point(173, 394);
            btnRellenar.Name = "btnRellenar";
            btnRellenar.Size = new Size(75, 23);
            btnRellenar.TabIndex = 141;
            btnRellenar.Text = "Rellenar";
            btnRellenar.UseVisualStyleBackColor = true;
            btnRellenar.Click += btnRellenar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(92, 394);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 140;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(254, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 139;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tblDojos
            // 
            tblDojos.AllowUserToAddRows = false;
            tblDojos.AllowUserToDeleteRows = false;
            tblDojos.AllowUserToResizeColumns = false;
            tblDojos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tblDojos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tblDojos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblDojos.Location = new Point(495, 95);
            tblDojos.Name = "tblDojos";
            tblDojos.ReadOnly = true;
            tblDojos.RightToLeft = RightToLeft.No;
            tblDojos.Size = new Size(730, 326);
            tblDojos.TabIndex = 138;
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
            panelBarraTitulo.TabIndex = 137;
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
            // cmbEscuelas
            // 
            cmbEscuelas.FormattingEnabled = true;
            cmbEscuelas.Location = new Point(107, 121);
            cmbEscuelas.Name = "cmbEscuelas";
            cmbEscuelas.Size = new Size(121, 23);
            cmbEscuelas.TabIndex = 178;
            // 
            // lblEscuelas
            // 
            lblEscuelas.AutoSize = true;
            lblEscuelas.Location = new Point(9, 121);
            lblEscuelas.Name = "lblEscuelas";
            lblEscuelas.Size = new Size(51, 15);
            lblEscuelas.TabIndex = 177;
            lblEscuelas.Text = "Escuelas";
            // 
            // cmbDocAtleta
            // 
            cmbDocAtleta.FormattingEnabled = true;
            cmbDocAtleta.Location = new Point(107, 155);
            cmbDocAtleta.Name = "cmbDocAtleta";
            cmbDocAtleta.Size = new Size(121, 23);
            cmbDocAtleta.TabIndex = 180;
            // 
            // lblDocAtleta
            // 
            lblDocAtleta.AutoSize = true;
            lblDocAtleta.Location = new Point(9, 155);
            lblDocAtleta.Name = "lblDocAtleta";
            lblDocAtleta.Size = new Size(59, 15);
            lblDocAtleta.TabIndex = 179;
            lblDocAtleta.Text = "DocAtleta";
            // 
            // VtnDojos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 611);
            Controls.Add(cmbDocAtleta);
            Controls.Add(lblDocAtleta);
            Controls.Add(cmbEscuelas);
            Controls.Add(lblEscuelas);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardar);
            Controls.Add(txtIncriptos);
            Controls.Add(lblInscriptos);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnRellenar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(tblDojos);
            Controls.Add(panelBarraTitulo);
            Name = "VtnDojos";
            Text = "VtnDojos";
            Load += VtnDojos_Load;
            ((System.ComponentModel.ISupportInitialize)tblDojos).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar;
        private TextBox txtBuscar;
        private TextBox txtPeso;
        private Label lblPeso;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnGuardar;
        private TextBox txtIncriptos;
        private Label lblInscriptos;
        private TextBox txtId;
        private Label lblId;
        private Button btnRellenar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView tblDojos;
        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimiza;
        private PictureBox btnCerrar;
        private ComboBox cmbEscuelas;
        private Label lblEscuelas;
        private ComboBox cmbDocAtleta;
        private Label lblDocAtleta;
    }
}