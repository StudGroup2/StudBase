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
            try
            {
                this.Validate();
                this.урокиBindingSource.EndEdit();
                this.урокиTableAdapter.Update(this.studBase);
                MessageBox.Show("Успешно сохраненно");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }
    }
}
