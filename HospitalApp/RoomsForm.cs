using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicHospital;

namespace HospitalApp
{
    public partial class RoomsForm : Form
    {
        AbstractEntity factory;
        Form parentForm;
        public RoomsForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            factory = new PalataFabric();
        }

        private void saveChanges()
        {
            палатыBindingSource.EndEdit();
            палатыTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            палатыTableAdapter.Fill(dbDataSet.Палаты);
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Палаты". При необходимости она может быть перемещена или удалена.
            this.палатыTableAdapter.Fill(this.dbDataSet.Палаты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (Control c in editPanel.Controls)
                {
                    foreach (Binding b in c.DataBindings)
                    {
                        b.WriteValue();
                    }
                }
                saveChanges();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить это?\nЭто действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    палатыBindingSource.RemoveAt(item.Index);
                }
                saveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Palata p = factory.createPalata(textBox2.Text, numericUpDown2.Value.ToString(), comboBox2.Text);
            dbDataSet.Палаты.AddПалатыRow(p.Num, Convert.ToInt32(p.Size), p.Otdel);
            saveChanges();
        }

        private void RoomsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
