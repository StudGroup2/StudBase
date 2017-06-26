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
    public partial class Оценки : Form
    {
        public Оценки()
        {
            InitializeComponent();
        }

        private void Оценки_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studBase.Уроки". При необходимости она может быть перемещена или удалена.
            this.урокиTableAdapter.Fill(this.studBase.Уроки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите сохранить?", "Сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
            {
                this.Validate();
                this.урокиBindingSource.EndEdit();
                this.урокиTableAdapter.Update(this.studBase);
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
