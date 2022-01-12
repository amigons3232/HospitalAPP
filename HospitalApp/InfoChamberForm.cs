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
    public partial class InfoChamberForm : Form
    {
        Form parentForm;

        public InfoChamberForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void InfoChamberForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.dbDataSet.Пациенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Палаты". При необходимости она может быть перемещена или удалена.
            this.палатыTableAdapter.Fill(this.dbDataSet.Палаты);

        }

        private void InfoChamberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
