namespace SmetkaZaNaracka
{
    partial class IzvrsuvanjeNaracka
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
            this.components = new System.ComponentModel.Container();
            this.dbLayoutPanel1 = new SmetkaZaNaracka.DBLayoutPanel(this.components);
            this.dbLayoutPanel2 = new SmetkaZaNaracka.DBLayoutPanel(this.components);
            this.SuspendLayout();
            // 
            // dbLayoutPanel1
            // 
            this.dbLayoutPanel1.ColumnCount = 2;
            this.dbLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbLayoutPanel1.Location = new System.Drawing.Point(3, 67);
            this.dbLayoutPanel1.Name = "dbLayoutPanel1";
            this.dbLayoutPanel1.RowCount = 2;
            this.dbLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.dbLayoutPanel1.TabIndex = 1;
            // 
            // dbLayoutPanel2
            // 
            this.dbLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.dbLayoutPanel2.ColumnCount = 1;
            this.dbLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dbLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dbLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.dbLayoutPanel2.Name = "dbLayoutPanel2";
            this.dbLayoutPanel2.RowCount = 1;
            this.dbLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbLayoutPanel2.Size = new System.Drawing.Size(710, 512);
            this.dbLayoutPanel2.TabIndex = 1;
            // 
            // IzvrsuvanjeNaracka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 512);
            this.Controls.Add(this.dbLayoutPanel2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "IzvrsuvanjeNaracka";
            this.Text = "IzvrsuvanjeNaracka";
            this.Controls.SetChildIndex(this.dbLayoutPanel2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DBLayoutPanel dbLayoutPanel1;
        private DBLayoutPanel dbLayoutPanel2;
    }
}