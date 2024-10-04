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
            logo = new PictureBox();
            panelMenu = new Panel();
            btnPools = new Button();
            panelPerfil = new Panel();
            lblNombre = new Label();
            pictureBox2 = new PictureBox();
            lblRol = new Label();
            btnCerrarSesion = new Button();
            btnRanking = new Button();
            btnUsuarios = new Button();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            lblTitulo = new TextBox();
            btnMaximizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelPrincipal.SuspendLayout();
            panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panelMenu.SuspendLayout();
            panelPerfil.SuspendLayout();
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
            panelFormularios.Controls.Add(logo);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(209, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1244, 650);
            panelFormularios.TabIndex = 15;
            // 
            // logo
            // 
            logo.BackColor = SystemColors.Control;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(444, 167);
            logo.MinimumSize = new Size(30, 30);
            logo.Name = "logo";
            logo.Size = new Size(389, 317);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 14;
            logo.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 47, 66);
            panelMenu.Controls.Add(btnPools);
            panelMenu.Controls.Add(panelPerfil);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnRanking);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(209, 650);
            panelMenu.TabIndex = 14;
            // 
            // btnPools
            // 
            btnPools.FlatAppearance.BorderSize = 0;
            btnPools.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 50, 70);
            btnPools.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnPools.FlatStyle = FlatStyle.Flat;
            btnPools.Font = new Font("Arial", 9.75F);
            btnPools.ForeColor = SystemColors.ButtonHighlight;
            btnPools.Image = (Image)resources.GetObject("btnPools.Image");
            btnPools.ImageAlign = ContentAlignment.MiddleLeft;
            btnPools.Location = new Point(12, 342);
            btnPools.Name = "btnPools";
            btnPools.Size = new Size(112, 52);
            btnPools.TabIndex = 24;
            btnPools.Text = "   Pools";
            btnPools.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPools.UseVisualStyleBackColor = true;
            // 
            // panelPerfil
            // 
            panelPerfil.BackColor = Color.Peru;
            panelPerfil.Controls.Add(lblNombre);
            panelPerfil.Controls.Add(pictureBox2);
            panelPerfil.Controls.Add(lblRol);
            panelPerfil.Location = new Point(0, 43);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(217, 121);
            panelPerfil.TabIndex = 15;
            panelPerfil.Paint += panelPerfil_Paint;
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
            btnRanking.Location = new Point(12, 272);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(112, 52);
            btnRanking.TabIndex = 22;
            btnRanking.Text = "   Ranking";
            btnRanking.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRanking.UseVisualStyleBackColor = true;
            btnRanking.Click += btnRank_Click;
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
            btnUsuarios.Location = new Point(3, 192);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(142, 74);
            btnUsuarios.TabIndex = 20;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuario_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.FromArgb(37, 47, 66);
            panelBarraTitulo.Controls.Add(btnRestaurar);
            panelBarraTitulo.Controls.Add(lblTitulo);
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
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(37, 47, 66);
            lblTitulo.BorderStyle = BorderStyle.None;
            lblTitulo.Enabled = false;
            lblTitulo.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(370, 26);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Confederacion Uruguaya de Karate";
            lblTitulo.TextAlign = HorizontalAlignment.Center;
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
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panelMenu.ResumeLayout(false);
            panelPerfil.ResumeLayout(false);
            panelPerfil.PerformLayout();
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
        private Button btnUsuarios;
        private Label lblNombre;
        private Label lblRol;
        private PictureBox pictureBox2;
        private Panel panelPerfil;
        private TextBox lblTitulo;
        private Button btnPools;
        private Panel panelFormularios;
        private PictureBox logo;
    }
}