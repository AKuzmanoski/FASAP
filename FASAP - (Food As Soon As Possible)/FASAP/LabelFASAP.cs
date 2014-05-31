using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SmetkaZaNaracka
{
    public partial class LabelFASAP : Label
    {
        public Object LblObject { get; set; }

        public LabelFASAP()
        {
            InitializeComponent();
            this.Init();
        }

        public LabelFASAP(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.Init();
        }

        public void Init()
        {
            this.BackColor = Color.Transparent;
            this.Text = "";
            this.Font = new Font("Trebuchet MS", 16, FontStyle.Bold);
            this.ForeColor = Color.White;
        }

        /// <summary>
        /// Updates the value of the object instance
        /// and sets the text of the label
        /// </summary>
        /// <param name="obj"></param>
        public void UpdateObject(Object obj)
        {
            this.LblObject = obj;
            if (this.LblObject != null)
                this.Text = this.LblObject.ToString();
            else
                this.Text = "";
        }
    }
}
