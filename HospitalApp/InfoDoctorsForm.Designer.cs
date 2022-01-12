namespace HospitalApp
{
    partial class InfoDoctorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDataSet = new HospitalApp.dbDataSet();
            this.врачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.врачиTableAdapter = new HospitalApp.dbDataSetTableAdapters.ВрачиTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.пациентыTableAdapter = new HospitalApp.dbDataSetTableAdapters.ПациентыTableAdapter();
            this.кодврачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специализацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпалатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодврачаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.диагнозDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыпискиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.врачиПациентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиПациентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодврачаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.специализацияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.врачиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(207, 564);
            this.dataGridView1.TabIndex = 2;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // врачиBindingSource
            // 
            this.врачиBindingSource.DataMember = "Врачи";
            this.врачиBindingSource.DataSource = this.dbDataSet;
            // 
            // врачиTableAdapter
            // 
            this.врачиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпациентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn1,
            this.кодпалатыDataGridViewTextBoxColumn,
            this.кодврачаDataGridViewTextBoxColumn1,
            this.датапоступленияDataGridViewTextBoxColumn,
            this.диагнозDataGridViewTextBoxColumn,
            this.датавыпискиDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.врачиПациентыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(225, 12);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(775, 564);
            this.dataGridView2.TabIndex = 3;
            // 
            // пациентыTableAdapter
            // 
            this.пациентыTableAdapter.ClearBeforeFill = true;
            // 
            // кодврачаDataGridViewTextBoxColumn
            // 
            this.кодврачаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.кодврачаDataGridViewTextBoxColumn.DataPropertyName = "Код_врача";
            this.кодврачаDataGridViewTextBoxColumn.HeaderText = "Код врача";
            this.кодврачаDataGridViewTextBoxColumn.Name = "кодврачаDataGridViewTextBoxColumn";
            this.кодврачаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодврачаDataGridViewTextBoxColumn.Width = 83;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // специализацияDataGridViewTextBoxColumn
            // 
            this.специализацияDataGridViewTextBoxColumn.DataPropertyName = "Специализация";
            this.специализацияDataGridViewTextBoxColumn.HeaderText = "Специализация";
            this.специализацияDataGridViewTextBoxColumn.Name = "специализацияDataGridViewTextBoxColumn";
            this.специализацияDataGridViewTextBoxColumn.ReadOnly = true;
            this.специализацияDataGridViewTextBoxColumn.Visible = false;
            // 
            // кодпациентаDataGridViewTextBoxColumn
            // 
            this.кодпациентаDataGridViewTextBoxColumn.DataPropertyName = "Код_пациента";
            this.кодпациентаDataGridViewTextBoxColumn.HeaderText = "Код пациента";
            this.кодпациентаDataGridViewTextBoxColumn.Name = "кодпациентаDataGridViewTextBoxColumn";
            this.кодпациентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // кодпалатыDataGridViewTextBoxColumn
            // 
            this.кодпалатыDataGridViewTextBoxColumn.DataPropertyName = "Код_палаты";
            this.кодпалатыDataGridViewTextBoxColumn.HeaderText = "Код палаты";
            this.кодпалатыDataGridViewTextBoxColumn.Name = "кодпалатыDataGridViewTextBoxColumn";
            this.кодпалатыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодврачаDataGridViewTextBoxColumn1
            // 
            this.кодврачаDataGridViewTextBoxColumn1.DataPropertyName = "Код_врача";
            this.кодврачаDataGridViewTextBoxColumn1.HeaderText = "Код врача";
            this.кодврачаDataGridViewTextBoxColumn1.Name = "кодврачаDataGridViewTextBoxColumn1";
            this.кодврачаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодврачаDataGridViewTextBoxColumn1.Visible = false;
            // 
            // датапоступленияDataGridViewTextBoxColumn
            // 
            this.датапоступленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_поступления";
            this.датапоступленияDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.датапоступленияDataGridViewTextBoxColumn.Name = "датапоступленияDataGridViewTextBoxColumn";
            this.датапоступленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // диагнозDataGridViewTextBoxColumn
            // 
            this.диагнозDataGridViewTextBoxColumn.DataPropertyName = "Диагноз";
            this.диагнозDataGridViewTextBoxColumn.HeaderText = "Диагноз";
            this.диагнозDataGridViewTextBoxColumn.Name = "диагнозDataGridViewTextBoxColumn";
            this.диагнозDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датавыпискиDataGridViewTextBoxColumn
            // 
            this.датавыпискиDataGridViewTextBoxColumn.DataPropertyName = "Дата_выписки";
            this.датавыпискиDataGridViewTextBoxColumn.HeaderText = "Дата выписки";
            this.датавыпискиDataGridViewTextBoxColumn.Name = "датавыпискиDataGridViewTextBoxColumn";
            this.датавыпискиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // врачиПациентыBindingSource
            // 
            this.врачиПациентыBindingSource.DataMember = "ВрачиПациенты";
            this.врачиПациентыBindingSource.DataSource = this.врачиBindingSource;
            // 
            // InfoDoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 588);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InfoDoctorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациенты врачей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoDoctorsForm_FormClosing);
            this.Load += new System.EventHandler(this.InfoDoctorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиПациентыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource врачиBindingSource;
        private dbDataSetTableAdapters.ВрачиTableAdapter врачиTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource врачиПациентыBindingSource;
        private dbDataSetTableAdapters.ПациентыTableAdapter пациентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпалатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодврачаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапоступленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn диагнозDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыпискиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодврачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специализацияDataGridViewTextBoxColumn;

    }
}