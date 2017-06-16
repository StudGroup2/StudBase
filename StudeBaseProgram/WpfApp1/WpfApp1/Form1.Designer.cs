namespace WpfApp1
{
    partial class Form1
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
            this.студентыTableAdapter1 = new WpfApp1.StudBaseDataSetTableAdapters.СтудентыTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studBaseDataSet = new WpfApp1.StudBaseDataSet();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преподавателиTableAdapter1 = new WpfApp1.StudBaseDataSetTableAdapters.ПреподавателиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // студентыTableAdapter1
            // 
            this.студентыTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фИОСDataGridViewTextBoxColumn,
            this.группыDataGridViewTextBoxColumn,
            this.годРожденияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.студентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 139);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studBaseDataSet
            // 
            this.studBaseDataSet.DataSetName = "StudBaseDataSet";
            this.studBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.studBaseDataSet;
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
            // годРожденияDataGridViewTextBoxColumn
            // 
            this.годРожденияDataGridViewTextBoxColumn.DataPropertyName = "Год рождения";
            this.годРожденияDataGridViewTextBoxColumn.HeaderText = "Год рождения";
            this.годРожденияDataGridViewTextBoxColumn.Name = "годРожденияDataGridViewTextBoxColumn";
            // 
            // преподавателиTableAdapter1
            // 
            this.преподавателиTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StudBaseDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private StudBaseDataSet studBaseDataSet;
        private StudBaseDataSetTableAdapters.ПреподавателиTableAdapter преподавателиTableAdapter1;
    }
}