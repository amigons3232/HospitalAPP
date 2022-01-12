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
    public partial class InfoDoctorsForm : Form
    {
        Form parentForm;
        public InfoDoctorsForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void InfoDoctorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.dbDataSet.Пациенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.dbDataSet.Врачи);

        }

        private void InfoDoctorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
