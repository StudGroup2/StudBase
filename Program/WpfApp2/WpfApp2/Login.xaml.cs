using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            
               SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost;Initial Catalog=StudBase;Integrated Security=True");
                try
                {
                    if (sqlCon.State == System.Data.ConnectionState.Closed)
                        sqlCon.Open();
                    String query = "SELECT COUNT(1) FROM login WHERE Username=@Username AND Password=@Password";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.CommandType = System.Data.CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@Username", TB_Login.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", TB_Password.Text);
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if (count == 1)
                    {
                        MainWindow dashboard = new MainWindow();
                        dashboard.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Вы ввели неверный Логин или Пароль");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            
        }
    }
}
