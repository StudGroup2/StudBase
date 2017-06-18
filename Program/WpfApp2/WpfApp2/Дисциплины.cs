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
            try
            {
                this.Validate();
                this.дисциплиныBindingSource.EndEdit();
                this.дисциплиныTableAdapter.Update(this.studBase);
                MessageBox.Show("Успешно сохраненно");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }
    }
}
