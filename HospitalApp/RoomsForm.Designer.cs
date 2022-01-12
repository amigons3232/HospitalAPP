namespace HospitalApp
{
    partial class RoomsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editPanel = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодпалатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпалатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.палатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new HospitalApp.dbDataSet();
            this.палатыTableAdapter = new HospitalApp.dbDataSetTableAdapters.ПалатыTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.editPanel);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 370);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 180);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 154);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(6, 58);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(698, 20);
            this.numericUpDown2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Вместимость";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Амбулаторные отделения",
            "Лечебно-диагностические отделения",
            "Отделение анестезиологии и реанимации №1",
            "Отделение анестезиологии и реанимации №2",
            "Офтальмология",
            "Терапевтические и реабилитационные отделения",
            "Хирургические отделения"});
            this.comboBox2.Location = new System.Drawing.Point(6, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(698, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Отделение";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(6, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(698, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Добавить палату!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(698, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Номер палаты";
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.numericUpDown1);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.comboBox1);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.linkLabel1);
            this.editPanel.Controls.Add(this.button1);
            this.editPanel.Controls.Add(this.textBox1);
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Location = new System.Drawing.Point(4, 22);
            this.editPanel.Name = "editPanel";
            this.editPanel.Padding = new System.Windows.Forms.Padding(3);
            this.editPanel.Size = new System.Drawing.Size(710, 154);
            this.editPanel.TabIndex = 0;
            this.editPanel.Text = "Изменение";
            this.editPanel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 58);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(698, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Вместимость";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Амбулаторные отделения",
            "Лечебно-диагностические отделения",
            "Отделение анестезиологии и реанимации №1",
            "Отделение анестезиологии и реанимации №2",
            "Офтальмология",
            "Терапевтические и реабилитационные отделения",
            "Хирургические отделения"});
            this.comboBox1.Location = new System.Drawing.Point(6, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(698, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Отделение";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(654, 129);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Удалить";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(642, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Изменить палату!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(698, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер палаты";
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
            this.dataGridView1.Size = new System.Drawing.Size(718, 352);
            this.dataGridView1.TabIndex = 5;
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
            // палатыBindingSource
            // 
            this.палатыBindingSource.DataMember = "Палаты";
            this.палатыBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // палатыTableAdapter
            // 
            this.палатыTableAdapter.ClearBeforeFill = true;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Палаты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomsForm_FormClosing);
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.палатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage editPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource палатыBindingSource;
        private dbDataSetTableAdapters.ПалатыTableAdapter палатыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодотделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпалатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпалатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделениеDataGridViewTextBoxColumn;
    }
}