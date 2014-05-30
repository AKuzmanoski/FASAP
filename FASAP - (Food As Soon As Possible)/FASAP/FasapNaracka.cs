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
    public partial class FasapNaracka : Form
    {
        private Restoran Restoran { get; set; }
        public FasapNaracka(Restoran restoran)
        {
            InitializeComponent();
            Restoran = restoran;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Restoran.Ime;
            labelImeRestoran.Text = Restoran.Ime;
            labelLokacija.Text = Restoran.Ulica + ", " + Restoran.Grad;
            labelRabVreme.Text = Restoran.RabotnoVreme;
            foreach (var obj in Restoran.Kontakt)
                lbKontakt.Items.Add(obj);
            if (Restoran.PicturePath == null)
            {
                pictureBoxLogo.Image = Resources.FASAP_LOGO;
            }

        }
    }
}
