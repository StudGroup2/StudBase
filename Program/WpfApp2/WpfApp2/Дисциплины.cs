﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp2
{
    public partial class Дисциплины : Form
    {
        public Дисциплины()
        {
            InitializeComponent();
        }

        private void Дисциплины_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studBase.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.studBase.Дисциплины);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите сохранить?", "Сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
            {
                this.Validate();
                this.дисциплиныBindingSource.EndEdit();
                this.дисциплиныTableAdapter.Update(this.studBase);
                MessageBox.Show("Успешно сохранено");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("Успешно удалено");
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Ошибка удаления");
                }
        }
    }
}
