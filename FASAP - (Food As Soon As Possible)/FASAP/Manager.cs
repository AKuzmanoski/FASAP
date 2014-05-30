using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add("4", "Бојан Бојоски", 2, 0, 2);
            this.dataGridView1.Rows.Add("2", "Радослав Стрезоски",0,1,1);
            this.dataGridView1.Rows.Add("3", "Предраг Ќирески", 0, 1, 1);
           
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
