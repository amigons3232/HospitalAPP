namespace HospitalApp
{
    partial class InfoChamberForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDataSet = new HospitalApp.dbDataSet();
            this.палатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.палатыTableAdapter = new HospitalApp.dbDataSetTableAdapters.ПалатыTableAdapter();
            this.палатыПациентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентыTableAdapter = new HospitalApp.dbDataSetTableAdapters.ПациентыTableAdapter();
            this.кодпалатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпалатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпалатыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодврачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.диагнозDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыпискиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатыПациентыBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.фИОDataGridViewTextBoxColumn,
            this.кодпалатыDataGridViewTextBoxColumn1,
            this.кодврачаDataGridViewTextBoxColumn,
            this.датапоступленияDataGridViewTextBoxColumn,
            this.диагнозDataGridViewTextBoxColumn,
            this.датавыпискиDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.палатыПациентыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(225, 12);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(535, 501);
            this.dataGridView2.TabIndex = 5;
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
            this.кодпалатыDataGridViewTextBoxColumn,
            this.номерпалатыDataGridViewTextBoxColumn,
            this.вместимостьDataGridViewTextBoxColumn,
            this.отделениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.палатыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(207, 501);
            this.dataGridView1.TabIndex = 4;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // палатыBindingSource
            // 
            this.палатыBindingSource.DataMember = "Палаты";
            this.палатыBindingSource.DataSource = this.dbDataSet;
            // 
            // палатыTableAdapter
            // 
            this.палатыTableAdapter.ClearBeforeFill = true;
            // 
            // палатыПациентыBindingSource
            // 
            this.палатыПациентыBindingSource.DataMember = "ПалатыПациенты";
            this.палатыПациентыBindingSource.DataSource = this.палатыBindingSource;
            // 
            // пациентыTableAdapter
            // 
            this.пациентыTableAdapter.ClearBeforeFill = true;
            // 
            // кодпалатыDataGridViewTextBoxColumn
            // 
            this.кодпалатыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.кодпалатыDataGridViewTextBoxColumn.DataPropertyName = "Код_палаты";
            this.кодпалатыDataGridViewTextBoxColumn.HeaderText = "Код палаты";
            this.кодпалатыDataGridViewTextBoxColumn.Name = "кодпалатыDataGridViewTextBoxColumn";
            this.кодпалатыDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодпалатыDataGridViewTextBoxColumn.Width = 91;
            // 
            // номерпалатыDataGridViewTextBoxColumn
            // 
            this.номерпалатыDataGridViewTextBoxColumn.DataPropertyName = "Номер_палаты";
            this.номерпалатыDataGridViewTextBoxColumn.HeaderText = "Номер палаты";
            this.номерпалатыDataGridViewTextBoxColumn.Name = "номерпалатыDataGridViewTextBoxColumn";
            this.номерпалатыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вместимостьDataGridViewTextBoxColumn
            // 
            this.вместимостьDataGridViewTextBoxColumn.DataPropertyName = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.HeaderText = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.Name = "вместимостьDataGridViewTextBoxColumn";
            this.вместимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.вместимостьDataGridViewTextBoxColumn.Visible = false;
            // 
            // отделениеDataGridViewTextBoxColumn
            // 
            this.отделениеDataGridViewTextBoxColumn.DataPropertyName = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.HeaderText = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.Name = "отделениеDataGridViewTextBoxColumn";
            this.отделениеDataGridViewTextBoxColumn.ReadOnly = true;
            this.отделениеDataGridViewTextBoxColumn.Visible = false;
            // 
            // кодпациентаDataGridViewTextBoxColumn
            // 
            this.кодпациентаDataGridViewTextBoxColumn.DataPropertyName = "Код_пациента";
            this.кодпациентаDataGridViewTextBoxColumn.HeaderText = "Код пациента";
            this.кодпациентаDataGridViewTextBoxColumn.Name = "кодпациентаDataGridViewTextBoxColumn";
            this.кодпациентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодпалатыDataGridViewTextBoxColumn1
            // 
            this.кодпалатыDataGridViewTextBoxColumn1.DataPropertyName = "Код_палаты";
            this.кодпалатыDataGridViewTextBoxColumn1.HeaderText = "Код палаты";
            this.кодпалатыDataGridViewTextBoxColumn1.Name = "кодпалатыDataGridViewTextBoxColumn1";
            this.кодпалатыDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодпалатыDataGridViewTextBoxColumn1.Visible = false;
            // 
            // кодврачаDataGridViewTextBoxColumn
            // 
            this.кодврачаDataGridViewTextBoxColumn.DataPropertyName = "Код_врача";
            this.кодврачаDataGridViewTextBoxColumn.HeaderText = "Код врача";
            this.кодврачаDataGridViewTextBoxColumn.Name = "кодврачаDataGridViewTextBoxColumn";
            this.кодврачаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // InfoChamberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 525);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InfoChamberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациенты палат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoChamberForm_FormClosing);
            this.Load += new System.EventHandler(this.InfoChamberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатыПациентыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource палатыBindingSource;
        private dbDataSetTableAdapters.ПалатыTableAdapter палатыTableAdapter;
        private System.Windows.Forms.BindingSource палатыПациентыBindingSource;
        private dbDataSetTableAdapters.ПациентыTableAdapter пациентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпалатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпалатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпалатыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодврачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапоступленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn диагнозDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыпискиDataGridViewTextBoxColumn;
    }
}