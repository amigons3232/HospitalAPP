namespace HospitalApp
{
    partial class InfoFreeForm
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
            this.палатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.палатыTableAdapter = new HospitalApp.dbDataSetTableAdapters.ПалатыTableAdapter();
            this.пациентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентыTableAdapter = new HospitalApp.dbDataSetTableAdapters.ПациентыTableAdapter();
            this.кодпалатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпалатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Size = new System.Drawing.Size(800, 514);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Validated += new System.EventHandler(this.dataGridView1_Validated);
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
            // пациентыBindingSource
            // 
            this.пациентыBindingSource.DataMember = "Пациенты";
            this.пациентыBindingSource.DataSource = this.dbDataSet;
            // 
            // пациентыTableAdapter
            // 
            this.пациентыTableAdapter.ClearBeforeFill = true;
            // 
            // кодпалатыDataGridViewTextBoxColumn
            // 
            this.кодпалатыDataGridViewTextBoxColumn.DataPropertyName = "Код_палаты";
            this.кодпалатыDataGridViewTextBoxColumn.HeaderText = "Код палаты";
            this.кодпалатыDataGridViewTextBoxColumn.Name = "кодпалатыDataGridViewTextBoxColumn";
            this.кодпалатыDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // отделениеDataGridViewTextBoxColumn
            // 
            this.отделениеDataGridViewTextBoxColumn.DataPropertyName = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.HeaderText = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.Name = "отделениеDataGridViewTextBoxColumn";
            this.отделениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InfoFreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 538);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InfoFreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Свободные палаты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoFreeForm_FormClosing);
            this.Load += new System.EventHandler(this.InfoFreeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource палатыBindingSource;
        private dbDataSetTableAdapters.ПалатыTableAdapter палатыTableAdapter;
        private System.Windows.Forms.BindingSource пациентыBindingSource;
        private dbDataSetTableAdapters.ПациентыTableAdapter пациентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпалатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпалатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделениеDataGridViewTextBoxColumn;

    }
}