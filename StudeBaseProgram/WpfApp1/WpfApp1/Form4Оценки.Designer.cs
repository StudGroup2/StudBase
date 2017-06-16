namespace WpfApp1
{
    partial class Form4Оценки
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
            this.studBaseDataSet = new WpfApp1.StudBaseDataSet();
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оценкиTableAdapter = new WpfApp1.StudBaseDataSetTableAdapters.ОценкиTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фИОСDataGridViewTextBoxColumn,
            this.группыDataGridViewTextBoxColumn,
            this.фИОПDataGridViewTextBoxColumn,
            this.дисциплинаDataGridViewTextBoxColumn,
            this.оценкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.оценкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(231, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // studBaseDataSet
            // 
            this.studBaseDataSet.DataSetName = "StudBaseDataSet";
            this.studBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "Оценки";
            this.оценкиBindingSource.DataSource = this.studBaseDataSet;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фИОСDataGridViewTextBoxColumn
            // 
            this.фИОСDataGridViewTextBoxColumn.DataPropertyName = "ФИО С";
            this.фИОСDataGridViewTextBoxColumn.HeaderText = "ФИО С";
            this.фИОСDataGridViewTextBoxColumn.Name = "фИОСDataGridViewTextBoxColumn";
            // 
            // группыDataGridViewTextBoxColumn
            // 
            this.группыDataGridViewTextBoxColumn.DataPropertyName = "№ Группы";
            this.группыDataGridViewTextBoxColumn.HeaderText = "№ Группы";
            this.группыDataGridViewTextBoxColumn.Name = "группыDataGridViewTextBoxColumn";
            // 
            // фИОПDataGridViewTextBoxColumn
            // 
            this.фИОПDataGridViewTextBoxColumn.DataPropertyName = "ФИО П";
            this.фИОПDataGridViewTextBoxColumn.HeaderText = "ФИО П";
            this.фИОПDataGridViewTextBoxColumn.Name = "фИОПDataGridViewTextBoxColumn";
            // 
            // дисциплинаDataGridViewTextBoxColumn
            // 
            this.дисциплинаDataGridViewTextBoxColumn.DataPropertyName = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.HeaderText = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.Name = "дисциплинаDataGridViewTextBoxColumn";
            // 
            // оценкиDataGridViewTextBoxColumn
            // 
            this.оценкиDataGridViewTextBoxColumn.DataPropertyName = "Оценки";
            this.оценкиDataGridViewTextBoxColumn.HeaderText = "Оценки";
            this.оценкиDataGridViewTextBoxColumn.Name = "оценкиDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudBaseDataSet studBaseDataSet;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private StudBaseDataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дисциплинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкиDataGridViewTextBoxColumn;
    }
}