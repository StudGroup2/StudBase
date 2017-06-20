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
    public partial class Должности : Form
    {
        public Должности()
        {
            InitializeComponent();
        }

        private void Должности_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studBase.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.studBase.Должность);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.должностьBindingSource.EndEdit();
                this.должностьTableAdapter.Update(this.studBase);
                MessageBox.Show("Успешно сохраненно");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }
    }
}
