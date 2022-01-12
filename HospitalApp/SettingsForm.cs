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
    public partial class SettingsForm : Form
    {
        Form parentForm;
        public SettingsForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Логин;
            textBox2.Text = Properties.Settings.Default.Пароль;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Логин = textBox1.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Логин успешно изменён!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Пароль = textBox2.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Пароль успешно изменён!");
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
