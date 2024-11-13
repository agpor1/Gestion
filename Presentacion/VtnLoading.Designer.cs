namespace Presentacion
{
    partial class VtnLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnLoading));
            lblPorcentaje = new Label();
            progressBar1 = new ProgressBar();
            lblCargando = new Label();
            lblBienvenida = new Label();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.BackColor = Color.White;
            lblPorcentaje.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentaje.ForeColor = SystemColors.MenuHighlight;
            lblPorcentaje.Location = new Point(681, 327);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(39, 24);
            lblPorcentaje.TabIndex = 41;
            lblPorcentaje.Text = "0%";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(398, 354);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(322, 23);
            progressBar1.TabIndex = 40;
            // 
            // lblCargando
            // 
            lblCargando.AutoSize = true;
            lblCargando.BackColor = Color.White;
            lblCargando.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargando.ForeColor = SystemColors.MenuHighlight;
            lblCargando.Location = new Point(398, 327);
            lblCargando.Name = "lblCargando";
            lblCargando.Size = new Size(109, 24);
            lblCargando.TabIndex = 39;
            lblCargando.Text = "Cargando";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.White;
            lblBienvenida.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = SystemColors.MenuHighlight;
            lblBienvenida.Location = new Point(420, 113);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(282, 56);
            lblBienvenida.TabIndex = 38;
            lblBienvenida.Text = "Bienvenido";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(366, 422);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick_1;
            // 
            // timer2
            // 
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(651, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // VtnLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(749, 422);
            Controls.Add(pictureBox1);
            Controls.Add(lblPorcentaje);
            Controls.Add(progressBar1);
            Controls.Add(lblCargando);
            Controls.Add(lblBienvenida);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VtnLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VtnLoading";
            TopMost = true;
            Load += VtnLoading_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPorcentaje;
        private ProgressBar progressBar1;
        private Label lblCargando;
        private Label lblBienvenida;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox1;
    }
}