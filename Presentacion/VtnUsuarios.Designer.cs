namespace Presentacion
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            tblPersona = new DataGridView();
            clsUsuariosBindingSource1 = new BindingSource(components);
            label1 = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtContrasena = new TextBox();
            label4 = new Label();
            label5 = new Label();
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
            btnAtras.Location = new Point(1162, 607);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { atletasToolStripMenuItem, senseiToolStripMenuItem, juecesToolStripMenuItem, arbitrosToolStripMenuItem, planillerosToolStripMenuItem });
            menuStrip1.Location = new Point(9, 48);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(306, 24);
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
            // tblPersona
            // 
            tblPersona.AllowUserToAddRows = false;
            tblPersona.AllowUserToDeleteRows = false;
            tblPersona.AllowUserToResizeColumns = false;
            tblPersona.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tblPersona.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 112);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 17;
            label1.Text = "Cedula";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 141);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(219, 167);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 23);
            txtApellido.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 21;
            label3.Text = "Apellido";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(219, 268);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(232, 23);
            txtContrasena.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 271);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 23;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 300);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 25;
            label5.Text = "Cargo";
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
            cmbCargos.Location = new Point(219, 300);
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
            txtNac.Location = new Point(219, 229);
            txtNac.Name = "txtNac";
            txtNac.Size = new Size(232, 23);
            txtNac.TabIndex = 32;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(145, 232);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(77, 15);
            lblNacionalidad.TabIndex = 31;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(219, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(145, 203);
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
            // VtnUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 642);
            Controls.Add(menuStrip1);
            Controls.Add(toolStripContainer1);
            Controls.Add(txtNac);
            Controls.Add(lblNacionalidad);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(cmbCargos);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(txtContrasena);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCedula);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtContrasena;
        private Label label4;
        private Label label5;
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
    }
}