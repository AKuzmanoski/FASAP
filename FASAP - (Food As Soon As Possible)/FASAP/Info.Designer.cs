namespace SmetkaZaNaracka
{
    partial class Info
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
            this.najavaButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // najavaButton
            // 
            this.najavaButton.Location = new System.Drawing.Point(12, 284);
            this.najavaButton.Name = "najavaButton";
            this.najavaButton.Size = new System.Drawing.Size(77, 26);
            this.najavaButton.TabIndex = 0;
            this.najavaButton.Text = "Најави се";
            this.najavaButton.UseVisualStyleBackColor = true;
            this.najavaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(160, 261);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(200, 49);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Регистрирај нов ресторан";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 322);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.najavaButton);
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button najavaButton;
        private System.Windows.Forms.Button registerButton;
    }
}