using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CanteenInGeneralEducationInstitution.MVVM.View.Admin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class InputSystem : Window
    {
        public InputSystem()
        {
            InitializeComponent();
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Entities entities = new Entities();
                if (txtLogin.Text == "" || txtPassword.Password == "")
                {
                    MessageBox.Show("Заполните пустые поля");
                }
                if (txtLogin.Text == (from i in entities.Administration select i.Login).FirstOrDefault() &&
                    txtPassword.Password == (from i in entities.Administration select i.Password).FirstOrDefault())
                {
                    MessageBox.Show("Авторизация прошла успешно");
                    MVVM.View.Admin.AdminInterface adminInterface = new AdminInterface();
                    adminInterface.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            catch
            {
                MessageBox.Show("Соединение с БД не установлено");
            }
        }

        private void BackPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
