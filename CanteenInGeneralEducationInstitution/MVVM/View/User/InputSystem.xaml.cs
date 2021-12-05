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

namespace CanteenInGeneralEducationInstitution.MVVM.View.User
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class InputSystem : Window
    {
        public static int idUser { get; set; }
        public InputSystem()
        {
            InitializeComponent();
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Entities entities = new Entities();
                if (txtCode.Text == "")
                {
                    MessageBox.Show("Заполните пустое поля");
                }
                if (txtCode.Text == (from i in entities.Users select i.Code).FirstOrDefault())
                {
                    idUser = (from i in entities.Users 
                              where i.Code == txtCode.Text select 
                              i.ID_Users_RK).FirstOrDefault();
                    MessageBox.Show("Авторизация прошла успешно");
                    MVVM.View.User.UserInterface userInterface = new MVVM.View.User.UserInterface();
                    userInterface.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный код идентификации");
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
