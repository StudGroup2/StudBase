﻿using System;
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
    public partial class Form3Уроки : Form
    {
        public Form3Уроки()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studBaseDataSet.Уроки". При необходимости она может быть перемещена или удалена.
            this.урокиTableAdapter.Fill(this.studBaseDataSet.Уроки);

        }
    }
}
