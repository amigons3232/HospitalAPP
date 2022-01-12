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
    public partial class DoctorsForm : Form
    {
        AbstractEntity factory;
        Form parentForm;
        public DoctorsForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void saveChanges()
        {
            врачиBindingSource.EndEdit();
            врачиTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            врачиTableAdapter.Fill(dbDataSet.Врачи);
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Врачи' table. You can move, or remove it, as needed.
            this.врачиTableAdapter.Fill(this.dbDataSet.Врачи);

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
                    врачиBindingSource.RemoveAt(item.Index);
                }
                saveChanges();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            factory = new DoctorFabric();
            Doctor temp = factory.createDoctor(textBox4.Text, textBox3.Text);
            dbDataSet.Врачи.AddВрачиRow(temp.Fio(), temp.SPec);
            saveChanges();
        }

        private void DoctorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
