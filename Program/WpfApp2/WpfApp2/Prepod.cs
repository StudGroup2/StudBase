using System;
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
    public partial class Prepod : Form
    {
        private int rowIndex = 0;

        public Prepod()
        {
            InitializeComponent();
        }

        private void Prepod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studBase.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.studBase.Преподаватели);

            for (int i = 1; i < 11; i++)
            {
                this.studBase.Преподаватели.Rows.Add(i, "ФИО П" + i, "Должность" + i, "Дисциплина" + i, "Стаж (лет)" + i);
            }
            dataGridView1.DataSource = this.studBase.Преподаватели;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.преподавателиBindingSource.EndEdit();
                this.преподавателиTableAdapter.Update(this.studBase);
                MessageBox.Show("Успешно сохраненно");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            DataRow dRow = (DataRow)row.DataBoundItem;
            this.studBase.Преподаватели.Rows.Remove(dRow);
            преподавателиTableAdapter.Update(this.studBase.Преподаватели);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
            }
        }
    }
}
