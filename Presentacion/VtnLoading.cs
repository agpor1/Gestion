using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class VtnLoading : Form
    {
        public VtnLoading()
        {
            InitializeComponent();
        }

        private void VtnLoading_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Interval = 30;
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            progressBar1.Value += 1;
            lblPorcentaje.Text = $"{progressBar1.Value}%";

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;

            if (this.Opacity <= 0)
            {
                timer2.Stop();
                VtnLogin login = new VtnLogin();
                login.Show();
                this.Hide();
            }
        }

        
    }
}
