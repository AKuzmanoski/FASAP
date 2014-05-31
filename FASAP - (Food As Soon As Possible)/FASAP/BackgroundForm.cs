using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmetkaZaNaracka.Properties;

namespace SmetkaZaNaracka
{
    public partial class BackgroundForm : Form
    {
        public BackgroundForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //this.BackgroundImage = Resources.FasapBackground12;
            this.pictureBox1.Image = Resources.MinimizeDarkLeft;
            this.pictureBox2.Image = Resources.ExitDark;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.MinimizeLightLeft;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Resources.ExitLight;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.MinimizeDarkLeft;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Resources.ExitDark;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*
        private void label1_Resize(object sender, EventArgs e)
        {
            Font f = new Font("Calibri", (float)tableLayoutPanel1.Height / 4);
            //this.label1.Font = new Font("Calibri", (float)label1.Font.Size * 1.5f); ;
            this.label1.Font = new Font("Calibri", (float)label1.Height * 0.2f);
        }*/
    }
}
