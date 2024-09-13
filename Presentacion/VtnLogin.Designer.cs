namespace Presentacion
{
    partial class VtnLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnLogin));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            btbIniciar = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            lblMensajeError = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 330);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 300);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.InactiveCaptionText;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.WindowFrame;
            txtUsuario.Location = new Point(366, 78);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(339, 20);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.InactiveCaptionText;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = SystemColors.WindowFrame;
            txtContraseña.Location = new Point(366, 153);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(339, 20);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(488, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 34);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // btbIniciar
            // 
            btbIniciar.BackColor = SystemColors.ControlDark;
            btbIniciar.FlatAppearance.BorderSize = 0;
            btbIniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btbIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btbIniciar.FlatStyle = FlatStyle.Flat;
            btbIniciar.ForeColor = SystemColors.Menu;
            btbIniciar.Location = new Point(366, 242);
            btbIniciar.Name = "btbIniciar";
            btbIniciar.Size = new Size(339, 40);
            btbIniciar.TabIndex = 3;
            btbIniciar.Text = "INICIAR";
            btbIniciar.UseVisualStyleBackColor = false;
            btbIniciar.Click += btbIniciar_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaptionText;
            textBox3.Enabled = false;
            textBox3.Font = new Font("Constantia", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(366, 179);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(339, 10);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.InactiveCaptionText;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Constantia", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.WindowFrame;
            textBox4.Location = new Point(366, 104);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(339, 10);
            textBox4.TabIndex = 6;
            textBox4.TabStop = false;
            textBox4.WordWrap = false;
            // 
            // btnMinimiza
            // 
            btnMinimiza.Image = (Image)resources.GetObject("btnMinimiza.Image");
            btnMinimiza.Location = new Point(722, 9);
            btnMinimiza.Name = "btnMinimiza";
            btnMinimiza.Size = new Size(27, 17);
            btnMinimiza.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimiza.TabIndex = 10;
            btnMinimiza.TabStop = false;
            btnMinimiza.Click += btnMinimiza_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.InitialImage = (Image)resources.GetObject("btnCerrar.InitialImage");
            btnCerrar.Location = new Point(755, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(22, 17);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 9;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensajeError.ForeColor = SystemColors.WindowFrame;
            lblMensajeError.Location = new Point(366, 203);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(48, 18);
            lblMensajeError.TabIndex = 12;
            lblMensajeError.Text = "Error";
            lblMensajeError.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HighlightText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(674, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VtnLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(780, 330);
            Controls.Add(pictureBox1);
            Controls.Add(lblMensajeError);
            Controls.Add(btnMinimiza);
            Controls.Add(btnCerrar);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(btbIniciar);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VtnLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "9";
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Button btbIniciar;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox btnMinimiza;
        private PictureBox pictureBox2;
        private PictureBox btnCerrar;
        private Label lblMensajeError;
        private PictureBox pictureBox1;
    }
}
