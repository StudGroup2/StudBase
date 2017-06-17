using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfApp1.Properties;

namespace WpfApp1
{
    public partial class Form1Студенты : Form
    {
        public Form1Студенты()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.студентыBindingSource.EndEdit();
                this.студентыTableAdapter1.Update(this.studBaseDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private static void Update(StudBaseDataSet.СтудентыDataTable студенты)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
