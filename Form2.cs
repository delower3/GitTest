using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private int count;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                if (MessageBox.Show("Закрыть подчиненное окно?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Hide();
                    Owner.Activate();
                }
            }
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            Owner.Controls["button1"].Text=Visible ? "Закрыть подчиненные окно" : "Открыть подчиненное окно";
            if (Visible) label1.Text = "Окно открыто в " + (++count) + " раз";
        }
    }
}
