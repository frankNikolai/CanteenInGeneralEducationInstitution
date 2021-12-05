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
using System.Windows.Shapes;

namespace CanteenInGeneralEducationInstitution.MVVM.View.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminInterface.xaml
    /// </summary>
    public partial class AdminInterface : Window
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", 
                                                       "Выход", MessageBoxButton.YesNo,
                                                       MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }

        }
    }
}
