﻿namespace WpfApp2
{
    partial class Оценки
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
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.присутствиеНаЗанятииDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.урокиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studBase = new WpfApp2.StudBase();
            this.урокиTableAdapter = new WpfApp2.StudBaseTableAdapters.УрокиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.урокиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.дисциплинаDataGridViewTextBoxColumn,
            this.группыDataGridViewTextBoxColumn,
            this.оценкиDataGridViewTextBoxColumn,
            this.присутствиеНаЗанятииDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.урокиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // дисциплинаDataGridViewTextBoxColumn
            // 
            this.дисциплинаDataGridViewTextBoxColumn.DataPropertyName = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.HeaderText = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.Name = "дисциплинаDataGridViewTextBoxColumn";
            // 
            // группыDataGridViewTextBoxColumn
            // 
            this.группыDataGridViewTextBoxColumn.DataPropertyName = "№ Группы";
            this.группыDataGridViewTextBoxColumn.HeaderText = "№ Группы";
            this.группыDataGridViewTextBoxColumn.Name = "группыDataGridViewTextBoxColumn";
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
            // урокиBindingSource
            // 
            this.урокиBindingSource.DataMember = "Уроки";
            this.урокиBindingSource.DataSource = this.studBase;
            // 
            // studBase
            // 
            this.studBase.DataSetName = "StudBase";
            this.studBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // урокиTableAdapter
            // 
            this.урокиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Оценки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Оценки";
            this.Text = "Оценки";
            this.Load += new System.EventHandler(this.Оценки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.урокиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudBase studBase;
        private System.Windows.Forms.BindingSource урокиBindingSource;
        private StudBaseTableAdapters.УрокиTableAdapter урокиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дисциплинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn присутствиеНаЗанятииDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}