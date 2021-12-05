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

namespace CanteenInGeneralEducationInstitution
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            MVVM.View.Admin.InputSystem inputSystem = new MVVM.View.Admin.InputSystem();
            inputSystem.Show();
            this.Close();
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            MVVM.View.User.InputSystem inputSystem = new MVVM.View.User.InputSystem();
            inputSystem.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
