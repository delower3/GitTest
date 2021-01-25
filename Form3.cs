using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        internal void button2_Click(object sender, EventArgs e)
        {
            Owner.Text = textBox1.Text;
            Owner.OwnedForms[0].Text = textBox2.Text;
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible) ActiveControl = textBox1;
        }
    }
}
