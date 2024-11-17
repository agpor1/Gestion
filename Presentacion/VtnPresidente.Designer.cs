namespace Presentacion
{
    partial class VtnPresidente
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
            tblPresidente = new DataGridView();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            btnAtras = new Button();
            txtSegundoApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtSegundoName = new TextBox();
            lblSegundoNombre = new Label();
            txtNac = new TextBox();
            lblNacionalidad = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            cmbCargos = new ComboBox();
            btnGuardar = new Button();
            lblCargo = new Label();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCedula = new TextBox();
            lblCedula = new Label();
            btnListar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tblPresidente).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // tblPresidente
            // 
            tblPresidente.AllowUserToAddRows = false;
            tblPresidente.AllowUserToDeleteRows = false;
            tblPresidente.AllowUserToResizeColumns = false;
            tblPresidente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tblPresidente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tblPresidente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblPresidente.Location = new Point(495, 101);
            tblPresidente.Name = "tblPresidente";
            tblPresidente.ReadOnly = true;
            tblPresidente.RightToLeft = RightToLeft.Yes;
            tblPresidente.Size = new Size(730, 326);
            tblPresidente.TabIndex = 38;
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
            panelBarraTitulo.TabIndex = 37;
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
            btnAtras.Location = new Point(5, 607);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 36;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(103, 222);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(232, 23);
            txtSegundoApellido.TabIndex = 104;
            txtSegundoApellido.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(5, 225);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(101, 15);
            lblSegundoApellido.TabIndex = 103;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtSegundoName
            // 
            txtSegundoName.Location = new Point(103, 164);
            txtSegundoName.Name = "txtSegundoName";
            txtSegundoName.Size = new Size(232, 23);
            txtSegundoName.TabIndex = 102;
            txtSegundoName.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Location = new Point(5, 167);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(101, 15);
            lblSegundoNombre.TabIndex = 101;
            lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // txtNac
            // 
            txtNac.Location = new Point(103, 279);
            txtNac.Name = "txtNac";
            txtNac.Size = new Size(232, 23);
            txtNac.TabIndex = 100;
            txtNac.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(5, 282);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(77, 15);
            lblNacionalidad.TabIndex = 99;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 98;
            txtEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(5, 253);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 97;
            lblEmail.Text = "Email";
            // 
            // cmbCargos
            // 
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Items.AddRange(new object[] { "Administrador", "Estandar" });
            cmbCargos.Location = new Point(103, 350);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(121, 23);
            cmbCargos.TabIndex = 96;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(5, 385);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 95;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(10, 350);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 94;
            lblCargo.Text = "Cargo";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(103, 318);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(232, 23);
            txtContrasena.TabIndex = 93;
            txtContrasena.TextAlign = HorizontalAlignment.Right;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(5, 321);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 92;
            lblContrasena.Text = "Contraseña";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(103, 193);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 23);
            txtApellido.TabIndex = 91;
            txtApellido.TextAlign = HorizontalAlignment.Right;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(5, 196);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(89, 15);
            lblApellido.TabIndex = 90;
            lblApellido.Text = "Primer Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 89;
            txtNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(5, 134);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 15);
            lblNombre.TabIndex = 88;
            lblNombre.Text = "Primer Nombre";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(103, 101);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(232, 23);
            txtCedula.TabIndex = 87;
            txtCedula.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(7, 104);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 86;
            lblCedula.Text = "Cedula";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(167, 385);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 85;
            btnListar.Text = "Rellenar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(86, 385);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 84;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(248, 385);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 83;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(445, 75);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 106;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(495, 72);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 105;
            // 
            // VtnPresidente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 642);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(txtSegundoName);
            Controls.Add(lblSegundoNombre);
            Controls.Add(txtNac);
            Controls.Add(lblNacionalidad);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(cmbCargos);
            Controls.Add(btnGuardar);
            Controls.Add(lblCargo);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
            Controls.Add(btnListar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(tblPresidente);
            Controls.Add(panelBarraTitulo);
            Controls.Add(btnAtras);
            Name = "VtnPresidente";
            Text = "VtnPresidente";
            Load += VtnPresidente_Load;
            ((System.ComponentModel.ISupportInitialize)tblPresidente).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView tblPresidente;
        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimiza;
        private PictureBox btnCerrar;
        private Button btnAtras;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
        private TextBox txtSegundoName;
        private Label lblSegundoNombre;
        private TextBox txtNac;
        private Label lblNacionalidad;
        private TextBox txtEmail;
        private Label lblEmail;
        private ComboBox cmbCargos;
        private Button btnGuardar;
        private Label lblCargo;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCedula;
        private Label lblCedula;
        private Button btnListar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblBuscar;
        private TextBox txtBuscar;
    }
}