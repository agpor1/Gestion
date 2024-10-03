﻿namespace Presentacion
{
    partial class VtnUsuarios
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnListar = new Button();
            btnAtras = new Button();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            menuStrip1 = new MenuStrip();
            atletasToolStripMenuItem = new ToolStripMenuItem();
            senseiToolStripMenuItem = new ToolStripMenuItem();
            juecesToolStripMenuItem = new ToolStripMenuItem();
            arbitrosToolStripMenuItem = new ToolStripMenuItem();
            planillerosToolStripMenuItem = new ToolStripMenuItem();
            presidenteToolStripMenuItem = new ToolStripMenuItem();
            tblPersona = new DataGridView();
            clsUsuariosBindingSource1 = new BindingSource(components);
            lblCedula = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            lblCargo = new Label();
            btnGuardar = new Button();
            clsUsuariosBindingSource = new BindingSource(components);
            cargosBindingSource = new BindingSource(components);
            cmbCargos = new ComboBox();
            clsUsuariosBindingSource2 = new BindingSource(components);
            txtNac = new TextBox();
            lblNacionalidad = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toolStripContainer1 = new ToolStripContainer();
            txtBuscar = new TextBox();
            txtSegundoName = new TextBox();
            lblSegundoNombre = new Label();
            txtSegundoApellido = new TextBox();
            lblSegundoApellido = new Label();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblPersona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clsUsuariosBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clsUsuariosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cargosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clsUsuariosBindingSource2).BeginInit();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 142);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 171);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(12, 200);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 3;
            btnListar.Text = "Rellenar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(1150, 607);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 4;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
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
            panelBarraTitulo.TabIndex = 15;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Location = new Point(2421, 12);
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
            btnMaximizar.Location = new Point(2387, 12);
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
            btnMinimiza.Location = new Point(2421, 12);
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
            btnCerrar.Location = new Point(2455, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { atletasToolStripMenuItem, senseiToolStripMenuItem, juecesToolStripMenuItem, arbitrosToolStripMenuItem, planillerosToolStripMenuItem, presidenteToolStripMenuItem });
            menuStrip1.Location = new Point(9, 48);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(380, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // atletasToolStripMenuItem
            // 
            atletasToolStripMenuItem.Name = "atletasToolStripMenuItem";
            atletasToolStripMenuItem.Size = new Size(55, 20);
            atletasToolStripMenuItem.Text = "Atletas";
            atletasToolStripMenuItem.Click += atletasToolStripMenuItem_Click;
            // 
            // senseiToolStripMenuItem
            // 
            senseiToolStripMenuItem.Name = "senseiToolStripMenuItem";
            senseiToolStripMenuItem.Size = new Size(52, 20);
            senseiToolStripMenuItem.Text = "Sensei";
            senseiToolStripMenuItem.Click += senseiToolStripMenuItem_Click;
            // 
            // juecesToolStripMenuItem
            // 
            juecesToolStripMenuItem.Name = "juecesToolStripMenuItem";
            juecesToolStripMenuItem.Size = new Size(53, 20);
            juecesToolStripMenuItem.Text = "Jueces";
            juecesToolStripMenuItem.Click += juecesToolStripMenuItem_Click;
            // 
            // arbitrosToolStripMenuItem
            // 
            arbitrosToolStripMenuItem.Name = "arbitrosToolStripMenuItem";
            arbitrosToolStripMenuItem.Size = new Size(61, 20);
            arbitrosToolStripMenuItem.Text = "Arbitros";
            arbitrosToolStripMenuItem.Click += arbitrosToolStripMenuItem_Click;
            // 
            // planillerosToolStripMenuItem
            // 
            planillerosToolStripMenuItem.Name = "planillerosToolStripMenuItem";
            planillerosToolStripMenuItem.Size = new Size(73, 20);
            planillerosToolStripMenuItem.Text = "Planilleros";
            planillerosToolStripMenuItem.Click += planillerosToolStripMenuItem_Click;
            // 
            // presidenteToolStripMenuItem
            // 
            presidenteToolStripMenuItem.Name = "presidenteToolStripMenuItem";
            presidenteToolStripMenuItem.Size = new Size(74, 20);
            presidenteToolStripMenuItem.Text = "Presidente";
            presidenteToolStripMenuItem.Click += presidenteToolStripMenuItem_Click;
            // 
            // tblPersona
            // 
            tblPersona.AllowUserToAddRows = false;
            tblPersona.AllowUserToDeleteRows = false;
            tblPersona.AllowUserToResizeColumns = false;
            tblPersona.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tblPersona.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            tblPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblPersona.Location = new Point(457, 109);
            tblPersona.Name = "tblPersona";
            tblPersona.ReadOnly = true;
            tblPersona.RightToLeft = RightToLeft.No;
            tblPersona.Size = new Size(768, 326);
            tblPersona.TabIndex = 16;
            // 
            // clsUsuariosBindingSource1
            // 
            clsUsuariosBindingSource1.DataSource = typeof(Dominio.clsDusuarios);
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(166, 112);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 17;
            lblCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(219, 109);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(232, 23);
            txtCedula.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(219, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(121, 142);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 15);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Primer Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(219, 201);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 23);
            txtApellido.TabIndex = 22;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(121, 204);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(89, 15);
            lblApellido.TabIndex = 21;
            lblApellido.Text = "Primer Apellido";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(219, 326);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(232, 23);
            txtContrasena.TabIndex = 24;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(146, 329);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 23;
            lblContrasena.Text = "Contraseña";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(163, 358);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 25;
            lblCargo.Text = "Cargo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 112);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // clsUsuariosBindingSource
            // 
            clsUsuariosBindingSource.DataSource = typeof(Dominio.clsDusuarios);
            // 
            // cargosBindingSource
            // 
            cargosBindingSource.DataSource = typeof(Entidad.Cargos);
            // 
            // cmbCargos
            // 
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Items.AddRange(new object[] { "Administrador", "Estandar" });
            cmbCargos.Location = new Point(219, 358);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(121, 23);
            cmbCargos.TabIndex = 28;
            // 
            // clsUsuariosBindingSource2
            // 
            clsUsuariosBindingSource2.DataSource = typeof(Dominio.clsDusuarios);
            // 
            // txtNac
            // 
            txtNac.Location = new Point(219, 287);
            txtNac.Name = "txtNac";
            txtNac.Size = new Size(232, 23);
            txtNac.TabIndex = 32;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(145, 290);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(77, 15);
            lblNacionalidad.TabIndex = 31;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(219, 258);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(166, 261);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 29;
            lblEmail.Text = "Email";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(1080, 110);
            toolStripContainer1.Location = new Point(1225, 636);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1080, 135);
            toolStripContainer1.TabIndex = 33;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(457, 80);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 34;
            // 
            // txtSegundoName
            // 
            txtSegundoName.Location = new Point(219, 172);
            txtSegundoName.Name = "txtSegundoName";
            txtSegundoName.Size = new Size(232, 23);
            txtSegundoName.TabIndex = 36;
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Location = new Point(121, 175);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(101, 15);
            lblSegundoNombre.TabIndex = 35;
            lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(219, 230);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(232, 23);
            txtSegundoApellido.TabIndex = 38;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(121, 233);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(101, 15);
            lblSegundoApellido.TabIndex = 37;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // VtnUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 642);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(txtSegundoName);
            Controls.Add(lblSegundoNombre);
            Controls.Add(txtBuscar);
            Controls.Add(menuStrip1);
            Controls.Add(toolStripContainer1);
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
            Controls.Add(tblPersona);
            Controls.Add(panelBarraTitulo);
            Controls.Add(btnAtras);
            Controls.Add(btnListar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            MainMenuStrip = menuStrip1;
            Name = "VtnUsuarios";
            Load += VtnUsuarios_Load;
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblPersona).EndInit();
            ((System.ComponentModel.ISupportInitialize)clsUsuariosBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clsUsuariosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cargosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clsUsuariosBindingSource2).EndInit();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnListar;
        private Button btnAtras;
        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimiza;
        private PictureBox btnCerrar;
        private DataGridView tblPersona;
        private Label lblCedula;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private Label lblCargo;
        private Button btnGuardar;
        private BindingSource cargosBindingSource;
        private BindingSource clsUsuariosBindingSource;
        private ComboBox cmbCargos;
        private BindingSource clsUsuariosBindingSource1;
        private BindingSource clsUsuariosBindingSource2;
        private TextBox txtNac;
        private Label lblNacionalidad;
        private TextBox txtEmail;
        private Label lblEmail;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atletasToolStripMenuItem;
        private ToolStripMenuItem senseiToolStripMenuItem;
        private ToolStripMenuItem juecesToolStripMenuItem;
        private ToolStripMenuItem arbitrosToolStripMenuItem;
        private ToolStripMenuItem planillerosToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripContainer toolStripContainer1;
        private TextBox txtBuscar;
        private ToolStripMenuItem presidenteToolStripMenuItem;
        private TextBox txtSegundoName;
        private Label lblSegundoNombre;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
    }
}