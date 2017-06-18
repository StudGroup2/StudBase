namespace WpfApp2
{
    partial class Prepod
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
            this.studBase = new WpfApp2.StudBase();
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавателиTableAdapter = new WpfApp2.StudBaseTableAdapters.ПреподавателиTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажлетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фИОПDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.дисциплинаDataGridViewTextBoxColumn,
            this.стажлетDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.преподавателиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studBase
            // 
            this.studBase.DataSetName = "StudBase";
            this.studBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // преподавателиBindingSource
            // 
            this.преподавателиBindingSource.DataMember = "Преподаватели";
            this.преподавателиBindingSource.DataSource = this.studBase;
            // 
            // преподавателиTableAdapter
            // 
            this.преподавателиTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // фИОПDataGridViewTextBoxColumn
            // 
            this.фИОПDataGridViewTextBoxColumn.DataPropertyName = "ФИО П";
            this.фИОПDataGridViewTextBoxColumn.HeaderText = "ФИО П";
            this.фИОПDataGridViewTextBoxColumn.Name = "фИОПDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // дисциплинаDataGridViewTextBoxColumn
            // 
            this.дисциплинаDataGridViewTextBoxColumn.DataPropertyName = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.HeaderText = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.Name = "дисциплинаDataGridViewTextBoxColumn";
            // 
            // стажлетDataGridViewTextBoxColumn
            // 
            this.стажлетDataGridViewTextBoxColumn.DataPropertyName = "Стаж (лет)";
            this.стажлетDataGridViewTextBoxColumn.HeaderText = "Стаж (лет)";
            this.стажлетDataGridViewTextBoxColumn.Name = "стажлетDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prepod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prepod";
            this.Text = "Prepod";
            this.Load += new System.EventHandler(this.Prepod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudBase studBase;
        private System.Windows.Forms.BindingSource преподавателиBindingSource;
        private StudBaseTableAdapters.ПреподавателиTableAdapter преподавателиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дисциплинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажлетDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}