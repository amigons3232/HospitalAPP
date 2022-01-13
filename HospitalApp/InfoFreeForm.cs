using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HospitalApp
{
    public partial class InfoFreeForm : Form
    {
        Form parentForm;
        public InfoFreeForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.dbDataSet.Пациенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Палаты". При необходимости она может быть перемещена или удалена.
            this.палатыTableAdapter.Fill(this.dbDataSet.Палаты);
        }

        private void InfoFreeForm_Load(object sender, EventArgs e)
        {
            палатыBindingSource.SuspendBinding();
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.dbConnectionString);
            conn.Open();
            OleDbCommand checkLogin = conn.CreateCommand();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                checkLogin.CommandText = "SELECT Count(Код_пациента) FROM Пациенты WHERE Код_палаты = " + dataGridView1[0, i].Value.ToString();
                var prodInfo = Convert.ToInt32(checkLogin.ExecuteScalar());
                if (prodInfo >= Convert.ToInt32(dataGridView1[2, i].Value))
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
            conn.Close();
            палатыBindingSource.ResumeBinding();
            
        }

        private void InfoFreeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }

        private void dataGridView1_Validated(object sender, EventArgs e)
        {

        }
    }
}
