using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp1
{
    public partial class Form4Оценки : Form
    {
        public Form4Оценки()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studBaseDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.studBaseDataSet.Оценки);

        }
    }
}
