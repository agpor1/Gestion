namespace Presentacion
{
    partial class VtnPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnPrincipal));
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            panelPrincipal = new Panel();
            panelFormularios = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            btnAtletas = new Button();
            panelPerfil = new Panel();
            pictureBox3 = new PictureBox();
            lblNombre = new Label();
            pictureBox2 = new PictureBox();
            lblRol = new Label();
            btnCerrarSesion = new Button();
            btnRanking = new Button();
            btnPlanilleros = new Button();
            btnUsuarios = new Button();
            btnSensei = new Button();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            txtUsuario = new TextBox();
            btnMaximizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelPrincipal.SuspendLayout();
            panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            SuspendLayout();
            // 
            // btnMinimiza
            // 
            btnMinimiza.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimiza.Cursor = Cursors.Hand;
            btnMinimiza.Image = (Image)resources.GetObject("btnMinimiza.Image");
            btnMinimiza.Location = new Point(1384, 12);
            btnMinimiza.Name = "btnMinimiza";
            btnMinimiza.Size = new Size(28, 18);
            btnMinimiza.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimiza.TabIndex = 11;
            btnMinimiza.TabStop = false;
            btnMinimiza.Click += btnMinimiza_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1418, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.GradientActiveCaption;
            panelPrincipal.Controls.Add(panelFormularios);
            panelPrincipal.Controls.Add(panelMenu);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.RightToLeft = RightToLeft.Yes;
            panelPrincipal.Size = new Size(1453, 650);
            panelPrincipal.TabIndex = 13;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = SystemColors.ButtonFace;
            panelFormularios.Controls.Add(pictureBox1);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(209, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1244, 650);
            panelFormularios.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(444, 167);
            pictureBox1.MinimumSize = new Size(30, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 47, 66);
            panelMenu.Controls.Add(btnAtletas);
            panelMenu.Controls.Add(panelPerfil);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnRanking);
            panelMenu.Controls.Add(btnPlanilleros);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnSensei);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(209, 650);
            panelMenu.TabIndex = 14;
            // 
            // btnAtletas
            // 
            btnAtletas.FlatAppearance.BorderSize = 0;
            btnAtletas.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 50, 70);
            btnAtletas.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnAtletas.FlatStyle = FlatStyle.Flat;
            btnAtletas.Font = new Font("Arial", 9.75F);
            btnAtletas.ForeColor = SystemColors.ButtonHighlight;
            btnAtletas.Image = (Image)resources.GetObject("btnAtletas.Image");
            btnAtletas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtletas.Location = new Point(-12, 400);
            btnAtletas.Name = "btnAtletas";
            btnAtletas.Size = new Size(143, 55);
            btnAtletas.TabIndex = 24;
            btnAtletas.Text = "Atleta";
            btnAtletas.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAtletas.UseVisualStyleBackColor = true;
            btnAtletas.Click += btnAtletas_Click;
            // 
            // panelPerfil
            // 
            panelPerfil.BackColor = Color.Peru;
            panelPerfil.Controls.Add(pictureBox3);
            panelPerfil.Controls.Add(lblNombre);
            panelPerfil.Controls.Add(pictureBox2);
            panelPerfil.Controls.Add(lblRol);
            panelPerfil.Location = new Point(0, 43);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(217, 121);
            panelPerfil.TabIndex = 15;
            panelPerfil.Paint += panelPerfil_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(171, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 29);
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(80, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 18);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = SystemColors.ControlLightLight;
            lblRol.Location = new Point(80, 84);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 18);
            lblRol.TabIndex = 15;
            lblRol.Text = "Rol";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 50, 70);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Arial", 9.75F);
            btnCerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(12, 600);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(151, 38);
            btnCerrarSesion.TabIndex = 23;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnRanking
            // 
            btnRanking.FlatAppearance.BorderSize = 0;
            btnRanking.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 50, 70);
            btnRanking.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnRanking.FlatStyle = FlatStyle.Flat;
            btnRanking.Font = new Font("Arial", 9.75F);
            btnRanking.ForeColor = SystemColors.ButtonHighlight;
            btnRanking.Image = (Image)resources.GetObject("btnRanking.Image");
            btnRanking.ImageAlign = ContentAlignment.MiddleLeft;
            btnRanking.Location = new Point(12, 461);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(112, 52);
            btnRanking.TabIndex = 22;
            btnRanking.Text = "Ranking";
            btnRanking.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRanking.UseVisualStyleBackColor = true;
            btnRanking.Click += btnRank_Click;
            // 
            // btnPlanilleros
            // 
            btnPlanilleros.FlatAppearance.BorderSize = 0;
            btnPlanilleros.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 50, 70);
            btnPlanilleros.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnPlanilleros.FlatStyle = FlatStyle.Flat;
            btnPlanilleros.Font = new Font("Arial", 9.75F);
            btnPlanilleros.ForeColor = SystemColors.ButtonHighlight;
            btnPlanilleros.Image = (Image)resources.GetObject("btnPlanilleros.Image");
            btnPlanilleros.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlanilleros.Location = new Point(3, 323);
            btnPlanilleros.Name = "btnPlanilleros";
            btnPlanilleros.Size = new Size(143, 71);
            btnPlanilleros.TabIndex = 21;
            btnPlanilleros.Text = "Planilleros";
            btnPlanilleros.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPlanilleros.UseVisualStyleBackColor = true;
            btnPlanilleros.Click += btnPlanilleros_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 50, 70);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Arial", 9.75F);
            btnUsuarios.ForeColor = SystemColors.ButtonHighlight;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(3, 170);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(142, 74);
            btnUsuarios.TabIndex = 20;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuario_Click;
            // 
            // btnSensei
            // 
            btnSensei.FlatAppearance.BorderSize = 0;
            btnSensei.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 50, 70);
            btnSensei.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnSensei.FlatStyle = FlatStyle.Flat;
            btnSensei.Font = new Font("Arial", 9.75F);
            btnSensei.ForeColor = SystemColors.ButtonHighlight;
            btnSensei.Image = (Image)resources.GetObject("btnSensei.Image");
            btnSensei.ImageAlign = ContentAlignment.MiddleLeft;
            btnSensei.Location = new Point(3, 250);
            btnSensei.Name = "btnSensei";
            btnSensei.Size = new Size(128, 67);
            btnSensei.TabIndex = 19;
            btnSensei.Text = "Sensei";
            btnSensei.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSensei.UseVisualStyleBackColor = true;
            btnSensei.Click += btnSensei_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.FromArgb(37, 47, 66);
            panelBarraTitulo.Controls.Add(btnRestaurar);
            panelBarraTitulo.Controls.Add(txtUsuario);
            panelBarraTitulo.Controls.Add(btnMaximizar);
            panelBarraTitulo.Controls.Add(btnMinimiza);
            panelBarraTitulo.Controls.Add(btnCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1453, 45);
            panelBarraTitulo.TabIndex = 14;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1384, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(28, 18);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 15;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(37, 47, 66);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Enabled = false;
            txtUsuario.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(20, 11);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(370, 26);
            txtUsuario.TabIndex = 13;
            txtUsuario.Text = "Confederacion Uruguaya de Karate";
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1350, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(28, 18);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 14;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // VtnPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 650);
            Controls.Add(panelBarraTitulo);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(650, 400);
            Name = "VtnPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelPerfil.ResumeLayout(false);
            panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox btnMinimiza;
        private PictureBox btnCerrar;
        private Panel panelPrincipal;
        private Panel panelMenu;
        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private Button btnCerrarSesion;
        private Button btnRanking;
        private Button btnPlanilleros;
        private Button btnUsuarios;
        private Button btnSensei;
        private Label lblNombre;
        private Label lblRol;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panelFormularios;
        private PictureBox pictureBox1;
        private Panel panelPerfil;
        private Button btnAtletas;
        private TextBox txtUsuario;
    }
}