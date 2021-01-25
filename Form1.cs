using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();

        public Form1()
        {
            InitializeComponent();
            AddOwnedForm(form2);
            AddOwnedForm(form3);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            form2.Location = new Point(Right - 10, Bottom - 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form2.Visible) form2.Close(); else form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form3.ShowDialog() == DialogResult.OK)
            {
                form3.button2_Click(this, EventArgs.Empty);
            }
        }
    }
}
