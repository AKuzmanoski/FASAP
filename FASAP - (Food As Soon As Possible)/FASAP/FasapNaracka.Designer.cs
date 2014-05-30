namespace SmetkaZaNaracka
{
    partial class FasapNaracka
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Појадок");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Предјадења");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Салати");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Тапас");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Тортиљи");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Десерти");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Амигос специјалитети");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Алкохолни пијалоци");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Безалкохолни пијалоци");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Мени Амигос", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeViewMenija = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLokacija = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRabVreme = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelImeRestoran = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxStavki = new System.Windows.Forms.ListBox();
            this.numericUpDownKolicina = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDodajVoNaracka = new System.Windows.Forms.Button();
            this.listBoxNaracano = new System.Windows.Forms.ListBox();
            this.buttonOtstraniOdNaracka = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNaracaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCena = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.lbKontakt = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewMenija
            // 
            this.treeViewMenija.Indent = 12;
            this.treeViewMenija.Location = new System.Drawing.Point(15, 183);
            this.treeViewMenija.Name = "treeViewMenija";
            treeNode1.Name = "Node3";
            treeNode1.NodeFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode1.Text = "Појадок";
            treeNode2.Name = "Node4";
            treeNode2.NodeFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode2.Text = "Предјадења";
            treeNode3.Name = "Node5";
            treeNode3.NodeFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode3.Text = "Салати";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Тапас";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Тортиљи";
            treeNode6.Name = "Node8";
            treeNode6.Text = "Десерти";
            treeNode7.Name = "Node9";
            treeNode7.Text = "Амигос специјалитети";
            treeNode8.Name = "Node10";
            treeNode8.Text = "Алкохолни пијалоци";
            treeNode9.Name = "Node11";
            treeNode9.Text = "Безалкохолни пијалоци";
            treeNode10.Name = "Node0";
            treeNode10.NodeFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode10.Text = "Мени Амигос";
            this.treeViewMenija.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeViewMenija.Size = new System.Drawing.Size(166, 160);
            this.treeViewMenija.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbKontakt);
            this.groupBox1.Controls.Add(this.pictureBoxLogo);
            this.groupBox1.Controls.Add(this.labelLokacija);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelRabVreme);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelImeRestoran);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxStavki);
            this.groupBox1.Controls.Add(this.treeViewMenija);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Понуда";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.Image = global::SmetkaZaNaracka.Properties.Resources.restoran_amigos_skopje_logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(16, 51);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(75, 47);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelLokacija
            // 
            this.labelLokacija.Location = new System.Drawing.Point(13, 123);
            this.labelLokacija.Name = "labelLokacija";
            this.labelLokacija.Size = new System.Drawing.Size(168, 40);
            this.labelLokacija.TabIndex = 10;
            this.labelLokacija.Text = "ул. Македонија 11, Скопје";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Локација:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(190, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Контакт:";
            // 
            // labelRabVreme
            // 
            this.labelRabVreme.Location = new System.Drawing.Point(190, 34);
            this.labelRabVreme.Name = "labelRabVreme";
            this.labelRabVreme.Size = new System.Drawing.Size(146, 17);
            this.labelRabVreme.TabIndex = 6;
            this.labelRabVreme.Text = "09:00-24:00/01:00";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(190, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Работно време:";
            // 
            // labelImeRestoran
            // 
            this.labelImeRestoran.AutoSize = true;
            this.labelImeRestoran.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelImeRestoran.Location = new System.Drawing.Point(12, 26);
            this.labelImeRestoran.Name = "labelImeRestoran";
            this.labelImeRestoran.Size = new System.Drawing.Size(71, 22);
            this.labelImeRestoran.TabIndex = 4;
            this.labelImeRestoran.Text = "АМИГОС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Избор ставка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Избор мени:";
            // 
            // listBoxStavki
            // 
            this.listBoxStavki.FormattingEnabled = true;
            this.listBoxStavki.ItemHeight = 18;
            this.listBoxStavki.Items.AddRange(new object[] {
            "Burritos",
            "Enchiladas",
            "Nachos enchiladas",
            "Tacos",
            "Tacquitos",
            "Fajitas",
            "Tacquitos fritos",
            "Chimichangas",
            "Tortilla de verduras y carne",
            "Baked enchiladas"});
            this.listBoxStavki.Location = new System.Drawing.Point(193, 141);
            this.listBoxStavki.Name = "listBoxStavki";
            this.listBoxStavki.ScrollAlwaysVisible = true;
            this.listBoxStavki.Size = new System.Drawing.Size(143, 202);
            this.listBoxStavki.TabIndex = 1;
            // 
            // numericUpDownKolicina
            // 
            this.numericUpDownKolicina.Location = new System.Drawing.Point(15, 56);
            this.numericUpDownKolicina.Name = "numericUpDownKolicina";
            this.numericUpDownKolicina.Size = new System.Drawing.Size(96, 21);
            this.numericUpDownKolicina.TabIndex = 2;
            this.numericUpDownKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количина";
            // 
            // buttonDodajVoNaracka
            // 
            this.buttonDodajVoNaracka.Location = new System.Drawing.Point(35, 96);
            this.buttonDodajVoNaracka.Name = "buttonDodajVoNaracka";
            this.buttonDodajVoNaracka.Size = new System.Drawing.Size(56, 39);
            this.buttonDodajVoNaracka.TabIndex = 4;
            this.buttonDodajVoNaracka.Text = ">>";
            this.buttonDodajVoNaracka.UseVisualStyleBackColor = true;
            // 
            // listBoxNaracano
            // 
            this.listBoxNaracano.FormattingEnabled = true;
            this.listBoxNaracano.ItemHeight = 18;
            this.listBoxNaracano.Items.AddRange(new object[] {
            "Caesar Shrimp 1 x 390 ... 390 ден.",
            "Quesadilla 2 x 90 ... 180 ден.",
            "Mai Tai 2 x 230 ... 460 ден."});
            this.listBoxNaracano.Location = new System.Drawing.Point(131, 46);
            this.listBoxNaracano.Name = "listBoxNaracano";
            this.listBoxNaracano.Size = new System.Drawing.Size(199, 94);
            this.listBoxNaracano.TabIndex = 5;
            // 
            // buttonOtstraniOdNaracka
            // 
            this.buttonOtstraniOdNaracka.Location = new System.Drawing.Point(35, 141);
            this.buttonOtstraniOdNaracka.Name = "buttonOtstraniOdNaracka";
            this.buttonOtstraniOdNaracka.Size = new System.Drawing.Size(56, 39);
            this.buttonOtstraniOdNaracka.TabIndex = 6;
            this.buttonOtstraniOdNaracka.Text = "<<";
            this.buttonOtstraniOdNaracka.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBoxNaracano);
            this.groupBox2.Controls.Add(this.buttonOtstraniOdNaracka);
            this.groupBox2.Controls.Add(this.numericUpDownKolicina);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonDodajVoNaracka);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(383, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 197);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Нарачка";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(126, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вкупно:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(218, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "1030";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonNaracaj
            // 
            this.buttonNaracaj.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNaracaj.Location = new System.Drawing.Point(464, 334);
            this.buttonNaracaj.Name = "buttonNaracaj";
            this.buttonNaracaj.Size = new System.Drawing.Size(121, 34);
            this.buttonNaracaj.TabIndex = 8;
            this.buttonNaracaj.Text = "Потврди нарачка";
            this.buttonNaracaj.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(592, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Откажи нарачка";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelCena);
            this.groupBox3.Controls.Add(this.labelOpis);
            this.groupBox3.Controls.Add(this.labelIme);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(383, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 99);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Детали за ставката";
            // 
            // labelCena
            // 
            this.labelCena.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCena.Location = new System.Drawing.Point(202, 25);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(128, 23);
            this.labelCena.TabIndex = 2;
            this.labelCena.Text = "620 ден.";
            this.labelCena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOpis
            // 
            this.labelOpis.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpis.Location = new System.Drawing.Point(15, 49);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(315, 37);
            this.labelOpis.TabIndex = 1;
            this.labelOpis.Text = "Месо по ваш избор, печено на скара, со мешан зеленчук, ориз, три соса, салата и ч" +
                "етири тортиљи (за двајца)";
            this.labelOpis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIme.Location = new System.Drawing.Point(15, 25);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(49, 18);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Fajitas";
            // 
            // lbKontakt
            // 
            this.lbKontakt.BackColor = System.Drawing.SystemColors.Control;
            this.lbKontakt.FormattingEnabled = true;
            this.lbKontakt.ItemHeight = 18;
            this.lbKontakt.Location = new System.Drawing.Point(193, 77);
            this.lbKontakt.Name = "lbKontakt";
            this.lbKontakt.Size = new System.Drawing.Size(143, 40);
            this.lbKontakt.TabIndex = 12;
            // 
            // FasapNaracka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 379);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNaracaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FasapNaracka";
            this.Text = "FASAP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMenija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxStavki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodajVoNaracka;
        private System.Windows.Forms.ListBox listBoxNaracano;
        private System.Windows.Forms.Button buttonOtstraniOdNaracka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNaracaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelImeRestoran;
        private System.Windows.Forms.Label labelRabVreme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelLokacija;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListBox lbKontakt;

    }
}

