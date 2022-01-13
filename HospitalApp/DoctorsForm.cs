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
