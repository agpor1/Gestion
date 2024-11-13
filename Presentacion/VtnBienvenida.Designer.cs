namespace Presentacion
{
    partial class VtnBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnBienvenida));
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            lblTitulo = new TextBox();
            btnMaximizar = new PictureBox();
            btnMinimiza = new PictureBox();
            btnCerrar = new PictureBox();
            pictureBox2 = new PictureBox();
            lblBienvenida = new Label();
            lblNombre = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            lblPorcentaje = new Label();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panelBarraTitulo.Size = new Size(781, 45);
            panelBarraTitulo.TabIndex = 16;
            panelBarraTitulo.Paint += panelBarraTitulo_Paint;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Location = new Point(3002, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(28, 18);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 15;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(37, 47, 66);
            lblTitulo.BorderStyle = BorderStyle.None;
            lblTitulo.Enabled = false;
            lblTitulo.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.MenuHighlight;
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(370, 26);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Confederacion Uruguaya de Karate";
            lblTitulo.TextAlign = HorizontalAlignment.Center;
            lblTitulo.TextChanged += lblTitulo_TextChanged;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Location = new Point(2968, 12);
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
            btnMinimiza.Location = new Point(3002, 12);
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
            btnCerrar.Location = new Point(3036, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(368, 453);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.White;
            lblBienvenida.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = SystemColors.MenuHighlight;
            lblBienvenida.Location = new Point(271, 193);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(282, 56);
            lblBienvenida.TabIndex = 25;
            lblBienvenida.Text = "Bienvenido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.White;
            lblNombre.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.MenuHighlight;
            lblNombre.Location = new Point(318, 279);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 24);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(637, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(214, 415);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(412, 23);
            progressBar1.TabIndex = 28;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.BackColor = Color.White;
            lblPorcentaje.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentaje.ForeColor = SystemColors.MenuHighlight;
            lblPorcentaje.Location = new Point(587, 388);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(39, 24);
            lblPorcentaje.TabIndex = 42;
            lblPorcentaje.Text = "0%";
            // 
            // VtnBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(781, 500);
            Controls.Add(lblPorcentaje);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(lblNombre);
            Controls.Add(lblBienvenida);
            Controls.Add(pictureBox2);
            Controls.Add(panelBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VtnBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VtnBienvenida";
            Load += VtnBienvenida_Load;
            panelBarraTitulo.ResumeLayout(false);
            panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimiza).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimiza;
        private PictureBox btnCerrar;
        private PictureBox pictureBox2;
        private Label lblBienvenida;
        private TextBox lblTitulo;
        private Label lblNombre;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ProgressBar progressBar1;
        private Label lblPorcentaje;
    }
}