namespace Presentacion
{
    partial class VtnArbitro
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
            tblArbitro = new DataGridView();
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
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)tblArbitro).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // tblArbitro
            // 
            tblArbitro.AllowUserToAddRows = false;
            tblArbitro.AllowUserToDeleteRows = false;
            tblArbitro.AllowUserToResizeColumns = false;
            tblArbitro.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tblArbitro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tblArbitro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblArbitro.Location = new Point(461, 80);
            tblArbitro.Name = "tblArbitro";
            tblArbitro.ReadOnly = true;
            tblArbitro.RightToLeft = RightToLeft.Yes;
            tblArbitro.Size = new Size(730, 326);
            tblArbitro.TabIndex = 38;
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
            btnAtras.Location = new Point(6, 607);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 36;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(104, 190);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(232, 23);
            txtSegundoApellido.TabIndex = 60;
            txtSegundoApellido.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(6, 193);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(101, 15);
            lblSegundoApellido.TabIndex = 59;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtSegundoName
            // 
            txtSegundoName.Location = new Point(104, 132);
            txtSegundoName.Name = "txtSegundoName";
            txtSegundoName.Size = new Size(232, 23);
            txtSegundoName.TabIndex = 58;
            txtSegundoName.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Location = new Point(6, 135);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(101, 15);
            lblSegundoNombre.TabIndex = 57;
            lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // txtNac
            // 
            txtNac.Location = new Point(104, 247);
            txtNac.Name = "txtNac";
            txtNac.Size = new Size(232, 23);
            txtNac.TabIndex = 56;
            txtNac.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(6, 250);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(77, 15);
            lblNacionalidad.TabIndex = 55;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 54;
            txtEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 221);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 53;
            lblEmail.Text = "Email";
            // 
            // cmbCargos
            // 
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Items.AddRange(new object[] { "Administrador", "Estandar" });
            cmbCargos.Location = new Point(104, 318);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(121, 23);
            cmbCargos.TabIndex = 52;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(7, 408);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 51;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(11, 318);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 50;
            lblCargo.Text = "Cargo";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(104, 286);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(232, 23);
            txtContrasena.TabIndex = 49;
            txtContrasena.TextAlign = HorizontalAlignment.Right;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(6, 289);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 48;
            lblContrasena.Text = "Contraseña";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(104, 161);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 23);
            txtApellido.TabIndex = 47;
            txtApellido.TextAlign = HorizontalAlignment.Right;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(6, 164);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(89, 15);
            lblApellido.TabIndex = 46;
            lblApellido.Text = "Primer Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 45;
            txtNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 15);
            lblNombre.TabIndex = 44;
            lblNombre.Text = "Primer Nombre";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(104, 69);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(232, 23);
            txtCedula.TabIndex = 43;
            txtCedula.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(8, 72);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 42;
            lblCedula.Text = "Cedula";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(169, 408);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 41;
            btnListar.Text = "Rellenar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(88, 408);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 40;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(250, 408);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(461, 51);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 34;
            txtBuscar.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(411, 54);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 39;
            lblBuscar.Text = "Buscar";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(104, 347);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 98;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(11, 347);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 97;
            lblCategoria.Text = "Categoria";
            // 
            // VtnArbitro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 642);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(lblBuscar);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(txtSegundoName);
            Controls.Add(lblSegundoNombre);
            Controls.Add(txtNac);
            Controls.Add(txtBuscar);
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
            Controls.Add(tblArbitro);
            Controls.Add(panelBarraTitulo);
            Controls.Add(btnAtras);
            Name = "VtnArbitro";
            Text = "VtnArbrito";
            Load += VtnArbitro_Load;
            ((System.ComponentModel.ISupportInitialize)tblArbitro).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView tblArbitro;
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
        private TextBox txtBuscar;
        private Label lblBuscar;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
    }
}