using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using LogicHospital;

namespace HospitalApp
{
    public partial class MainForm : Form
    {
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void врачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm(this);
            doctorsForm.Show();
            this.Hide();
        }

        private void палатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm(this);
            roomsForm.Show();
            this.Hide();
        }


        private void saveChanges()
        {
            пациентыBindingSource.EndEdit();
            пациентыTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            пациентыTableAdapter.Fill(dbDataSet.Пациенты);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (Convert.ToInt32(numericUpDown2.Value) != Convert.ToInt32(numericUpDown2.Tag))
                {
                    dbDataSet.ПалатыRow палата = dbDataSet.Палаты.FindByКод_палаты(Convert.ToInt32(numericUpDown2.Value));
                    if (палата == null || палата.Код_палаты < 1)
                    {
                        MessageBox.Show("Такой палаты нет!");
                        return;
                    }

                    OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.dbConnectionString);
                    conn.Open();
                    OleDbCommand checkLogin = conn.CreateCommand();
                    checkLogin.CommandText = "SELECT Count(Код_пациента) FROM Пациенты WHERE Код_палаты = " + Convert.ToInt32(numericUpDown2.Value).ToString();
                    int prodInfo = Convert.ToInt32(checkLogin.ExecuteScalar());
                    conn.Close();
                }

                if (Convert.ToInt32(numericUpDown1.Value) != Convert.ToInt32(numericUpDown1.Tag))
                {
                    dbDataSet.ВрачиRow врач = dbDataSet.Врачи.FindByКод_врача(Convert.ToInt32(numericUpDown4.Value));
                    if (врач == null || врач.Код_врача < 1)
                    {
                        MessageBox.Show("Такой врача нет!");
                        return;
                    }
                }

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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выписать этого пациента?\n", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    if (MessageBox.Show("Распечатать запись об этом пациенте?\n", "Печать", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var dia = new System.Windows.Forms.SaveFileDialog();
                        dia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        dia.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
                        if (dia.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                        {
                            string[] lines = { "------------------------------", 
                                               "Код пациента: "+item.Cells[0].Value.ToString(), 
                                               "ФИО: "+item.Cells[1].Value.ToString(), 
                                               "Код палаты: "+item.Cells[2].Value.ToString(), 
                                               "Код врача: "+item.Cells[3].Value.ToString(), 
                                               "Дата поступления: "+item.Cells[4].Value.ToString(), 
                                               "Диагноз: "+item.Cells[5].Value.ToString(), 
                                               "Дата выписки: "+item.Cells[6].Value.ToString(), 
                                               "------------------------------", 
                                               };
                            File.WriteAllLines(dia.FileName, lines);
                            Process.Start(dia.FileName);
                        }
                    }
                    пациентыBindingSource.RemoveAt(item.Index);
                }
                saveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbDataSet.ПалатыRow палата = dbDataSet.Палаты.FindByКод_палаты(Convert.ToInt32(numericUpDown3.Value));
            if (палата == null || палата.Код_палаты < 1)
            {
                MessageBox.Show("Такой палаты нет!");
                return;
            }

            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.dbConnectionString);
            conn.Open();
            OleDbCommand checkLogin = conn.CreateCommand();
            checkLogin.CommandText = "SELECT Count(Код_пациента) FROM Пациенты WHERE Код_палаты = " + Convert.ToInt32(numericUpDown3.Value).ToString();
            int prodInfo = Convert.ToInt32(checkLogin.ExecuteScalar());
            conn.Close();

            if (prodInfo >= палата.Вместимость)
            {
                MessageBox.Show("В этой палате больше нет мест!");
                return;
            }

            dbDataSet.ВрачиRow врач = dbDataSet.Врачи.FindByКод_врача(Convert.ToInt32(numericUpDown4.Value));
            if (врач == null || врач.Код_врача < 1)
            {
                MessageBox.Show("Такой врача нет!");
                return;
            }
            Patient p = factory.createPatient(textBox4.Text, палата.ToString(), врач.ToString(), dateTimePicker4.Value.Date.ToString(), textBox3.Text, dateTimePicker3.Value.Date.ToString());
            dbDataSet.Пациенты.AddПациентыRow(p.Fio(), палата, врач, dateTimePicker4.Value.Date, p.Diagnoz, dateTimePicker3.Value.Date);
            saveChanges();
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // TODO: This line of code loads data into the 'dbDataSet.Врачи' table. You can move, or remove it, as needed.
                this.врачиTableAdapter.Fill(this.dbDataSet.Врачи);
                // TODO: This line of code loads data into the 'dbDataSet.Палаты' table. You can move, or remove it, as needed.
                this.палатыTableAdapter.Fill(this.dbDataSet.Палаты);
                // TODO: This line of code loads data into the 'dbDataSet.Пациенты' table. You can move, or remove it, as needed.
                this.пациентыTableAdapter.Fill(this.dbDataSet.Пациенты);
            }
        }

        private void настройкиПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
            this.Hide();
        }

        private void пациентыВрачейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoDoctorsForm infoDoctorsForm = new InfoDoctorsForm(this);
            infoDoctorsForm.Show();
            this.Hide();
        }

        private void пациентыПалатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoChamberForm infoChamberForm = new InfoChamberForm(this);
            infoChamberForm.Show();
            this.Hide();
        }

        private bool cmpStr<T>(string s, T c1, T c2) where T : IComparable<T>
        {
            int res = c1.CompareTo(c2);

            switch (s)
            {
                case ">":
                    return res > 0;
                case ">=":
                    return res >= 0;
                case "=":
                    return res == 0;
                case "<=":
                    return res <= 0;
                case "<":
                    return res < 0;
                default:
                    throw new ArgumentException();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void свободныеПалатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoFreeForm infoFreeForm = new InfoFreeForm(this);
            infoFreeForm.Show();
            this.Hide();
        }

        public void exportToExcel(DataGridView dgv)
        {
            var dia = new System.Windows.Forms.SaveFileDialog();
            dia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dia.Filter = "Excel Worksheets (*.xlsx)|*.xlsx|xls file (*.xls)|*.xls|All files (*.*)|*.*";
            if (dia.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                Excel.Application excelapp = new Excel.Application();
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                int currentCol = 0;
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv.Columns[j].Visible)
                    {
                        worksheet.Rows[1].Columns[currentCol + 1] = dgv.Columns[j].HeaderText;
                    }
                    else
                    {
                        currentCol -= 1;
                    }
                    currentCol++;
                }

                int currentRow = 0;
                for (int i = 1; i < dgv.RowCount + 1; i++)
                {
                    currentRow++;
                    currentCol = 0;
                    for (int j = 1; j < dgv.ColumnCount + 1; j++)
                    {
                        currentCol++;
                        if (dgv.Rows[i - 1].Visible)
                        {
                            if (dgv.Columns[j - 1].Visible)
                            {
                                worksheet.Rows[currentRow + 1].Columns[currentCol] = dgv.Rows[i - 1].Cells[j - 1].Value;
                            }
                            else
                            {
                                currentCol -= 1;
                            }
                        }
                        else
                        {
                            currentRow -= 1;
                        }
                    }
                }

                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(dia.FileName);
                excelapp.Quit();
                MessageBox.Show("Экспорт прошёл успешно!");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            exportToExcel(dataGridView1);
        }

        private void справкмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Справка.pdf");
        }
    }
}
