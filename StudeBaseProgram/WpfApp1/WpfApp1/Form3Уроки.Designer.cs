namespace WpfApp1
{
    partial class Form3Уроки
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
            this.урокиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.урокиTableAdapter = new WpfApp1.StudBaseDataSetTableAdapters.УрокиTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеДисциплиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаУрокаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.присутствиеНаЗанятииDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.урокиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеДисциплиныDataGridViewTextBoxColumn,
            this.датаУрокаDataGridViewTextBoxColumn,
            this.фИОПDataGridViewTextBoxColumn,
            this.фИОСDataGridViewTextBoxColumn,
            this.оценкиDataGridViewTextBoxColumn,
            this.присутствиеНаЗанятииDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.урокиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // studBaseDataSet
            // 
            this.studBaseDataSet.DataSetName = "StudBaseDataSet";
            this.studBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // урокиBindingSource
            // 
            this.урокиBindingSource.DataMember = "Уроки";
            this.урокиBindingSource.DataSource = this.studBaseDataSet;
            // 
            // урокиTableAdapter
            // 
            this.урокиTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // названиеДисциплиныDataGridViewTextBoxColumn
            // 
            this.названиеДисциплиныDataGridViewTextBoxColumn.DataPropertyName = "Название дисциплины";
            this.названиеДисциплиныDataGridViewTextBoxColumn.HeaderText = "Название дисциплины";
            this.названиеДисциплиныDataGridViewTextBoxColumn.Name = "названиеДисциплиныDataGridViewTextBoxColumn";
            // 
            // датаУрокаDataGridViewTextBoxColumn
            // 
            this.датаУрокаDataGridViewTextBoxColumn.DataPropertyName = "Дата урока";
            this.датаУрокаDataGridViewTextBoxColumn.HeaderText = "Дата урока";
            this.датаУрокаDataGridViewTextBoxColumn.Name = "датаУрокаDataGridViewTextBoxColumn";
            // 
            // фИОПDataGridViewTextBoxColumn
            // 
            this.фИОПDataGridViewTextBoxColumn.DataPropertyName = "ФИО П";
            this.фИОПDataGridViewTextBoxColumn.HeaderText = "ФИО П";
            this.фИОПDataGridViewTextBoxColumn.Name = "фИОПDataGridViewTextBoxColumn";
            // 
            // фИОСDataGridViewTextBoxColumn
            // 
            this.фИОСDataGridViewTextBoxColumn.DataPropertyName = "ФИО С";
            this.фИОСDataGridViewTextBoxColumn.HeaderText = "ФИО С";
            this.фИОСDataGridViewTextBoxColumn.Name = "фИОСDataGridViewTextBoxColumn";
            // 
            // оценкиDataGridViewTextBoxColumn
            // 
            this.оценкиDataGridViewTextBoxColumn.DataPropertyName = "Оценки";
            this.оценкиDataGridViewTextBoxColumn.HeaderText = "Оценки";
            this.оценкиDataGridViewTextBoxColumn.Name = "оценкиDataGridViewTextBoxColumn";
            // 
            // присутствиеНаЗанятииDataGridViewCheckBoxColumn
            // 
            this.присутствиеНаЗанятииDataGridViewCheckBoxColumn.DataPropertyName = "Присутствие на занятии";
            this.присутствиеНаЗанятииDataGridViewCheckBoxColumn.HeaderText = "Присутствие на занятии";
            this.присутствиеНаЗанятииDataGridViewCheckBoxColumn.Name = "присутствиеНаЗанятииDataGridViewCheckBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.урокиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudBaseDataSet studBaseDataSet;
        private System.Windows.Forms.BindingSource урокиBindingSource;
        private StudBaseDataSetTableAdapters.УрокиTableAdapter урокиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеДисциплиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаУрокаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn присутствиеНаЗанятииDataGridViewCheckBoxColumn;
    }
}