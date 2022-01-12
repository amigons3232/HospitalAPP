using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Properties.Settings.Default.Логин && maskedTextBox1.Text == Properties.Settings.Default.Пароль)
            {
                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
