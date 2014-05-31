using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmetkaZaNaracka.Properties;
using Oracle.DataAccess.Client;

namespace SmetkaZaNaracka
{
    public partial class SearchFilter : Form
    {
        public OracleConnection Conn { get; set; }
        Font fnt;
        List<PictureBox> lista;
        private List<Restoran> Restorani { get; set; }
        public SearchFilter(List<Restoran> restorani, OracleConnection conn)
        {
            InitializeComponent();
            Conn = conn;
            Restorani = restorani;
        }

        private void SearchFilter_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width - 8, pictureBox1.Size.Width - 8);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 4, pictureBox1.Location.Y + 4);
            fnt = textBox1.Font;

            lista = new List<PictureBox>();
            lista.Add(pictureBox2);
            lista.Add(pictureBox3);
            lista.Add(pictureBox4);
            lista.Add(pictureBox5);
            lista.Add(pictureBox6);


            foreach (var obj in Restorani)
                lbRestorani.Items.Add(obj);
            /*Restoran restoran = new Restoran();
            restoran.RestoranID = 1;
            restoran.Ime = "Гостилница Лира";
            restoran.Ulica = "Никола Теслa бр.11";
            restoran.Grad = "Скопје";
            restoran.RabotnoVreme = "09:00 - 24:00 / 01:00";
            restoran.SlobodniMasi = 15;
            restoran.CenaZaDostava = 180;
            restoran.PragZaDostava = 800;
            restoran.DatumNaOtvoranje = new DateTime(1996, 5, 25);
            restoran.Kategorija = "Гостилница";
            restoran.BrojMasi = 30;
            restoran.Kapacitet = 150;
            restoran.Rejting = 7.8;
            restoran.Kontakt.Add(new Telefon("02/3061-726"));
            lbRestorani.Items.Add(restoran);
            restoran = new Restoran();
            restoran.RestoranID = 2;
            restoran.Ime = "Ресторан Бигор - Вруток";
            restoran.Ulica = "Извор - Вруток";
            restoran.Grad = "Гостивар";
            restoran.RabotnoVreme = "Пон - Пет: 11:00 - 24:00";
            restoran.SlobodniMasi = 5;
            restoran.CenaZaDostava = 220;
            restoran.PragZaDostava = 850;
            restoran.DatumNaOtvoranje = new DateTime(1996, 3, 1);
            restoran.Kategorija = "Рибен";
            restoran.BrojMasi = 20;
            restoran.Kapacitet = 150;
            restoran.Rejting = 9.9;
            restoran.Kontakt.Add(new Telefon("075/304-993"));
            restoran.Kontakt.Add(new Telefon("042/215-005"));
            lbRestorani.Items.Add(restoran);
            restoran = new Restoran();
            restoran.RestoranID = 3;
            restoran.Ime = "Ресторан Амигос";
            restoran.Ulica = "ул. Македонија";
            restoran.Grad = "Скопје";
            restoran.RabotnoVreme = "09:00 - 24:00 / 01:00";
            restoran.SlobodniMasi = 10;
            restoran.CenaZaDostava = 160;
            restoran.PragZaDostava = 650;
            restoran.DatumNaOtvoranje = new DateTime(2006, 5, 25);
            restoran.Kategorija = "Мексикански";
            restoran.BrojMasi = 25;
            restoran.Kapacitet = 100;
            restoran.Rejting = 7.3;
            lbRestorani.Items.Add(restoran);*/
            postaviRejting(0);
        }

        private void postaviRejting(double rejting)
        {
            int i = 0;
            foreach (PictureBox pb in lista)
            {
                i += 2;
                if (i <= rejting || System.Math.Abs((i - rejting)) <= 0.5)
                    pb.Image = Resources.Polna_zvezda;
                else if (System.Math.Abs((i - rejting)) <= 1.5)
                    pb.Image = Resources.Pola_zvezda;
                else pb.Image = Resources.Prazna_zvezda;

            }
                
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!textBox1.Focused && textBox1.Font.Italic)
            {
                textBox1.BackColor = SystemColors.GradientInactiveCaption;
                textBox1.ForeColor = SystemColors.ControlDark;
                pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox1.Font.Italic)
            {
                textBox1.Text = "";
                textBox1.BackColor = SystemColors.Window;
                textBox1.Font = Control.DefaultFont;
                textBox1.ForeColor = SystemColors.ControlText;
                pictureBox1.BackColor = SystemColors.Window;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Пребарај FASAP - Ресторани";
                textBox1.BackColor = SystemColors.GradientInactiveCaption;
                textBox1.ForeColor = SystemColors.ControlDark;
                pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
                textBox1.Font = fnt;
            }
        }

        private void lbRestorani_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbKontakt.Items.Clear();
            Object obj = lbRestorani.SelectedItem;
            if (obj != null)
            {
                Restoran restoran = obj as Restoran;
                postaviRejting(restoran.Rejting);
                tbGrad.Text = restoran.Grad;
                tbKategorija.Text = restoran.Kategorija;
                tbSlobodni.Text = restoran.SlobodniMasi.ToString();
                tbUlica.Text = restoran.Ulica;
                tbVreme.Text = restoran.RabotnoVreme;
                foreach (Telefon t in restoran.Kontakt)
                    lbKontakt.Items.Add(t);
            }
            else
            {
                tbGrad.Text = "";
                tbKategorija.Text = "";
                tbSlobodni.Text = "";
                tbUlica.Text = "";
                tbVreme.Text = "";
                postaviRejting(0);
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Font.Italic)
            {
                textBox1.BackColor = SystemColors.InactiveBorder;
                textBox1.ForeColor = SystemColors.InactiveCaption;
                pictureBox1.BackColor = SystemColors.InactiveBorder;
            }
        }

        private void lbRestorani_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var obj = (Restoran)lbRestorani.SelectedItem;
            FasapNaracka fasapNaracka = new FasapNaracka(obj, Conn);
            fasapNaracka.Show();
        }
    }
}
