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
    /// Логика взаимодействия для DishView.xaml
    /// </summary>
    public partial class BuffetView : UserControl
    {
        Entities entities = new Entities();
        public BuffetView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DGridBuffet.ItemsSource = entities.Buffet.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.BuffetModel buffet = new Model.BuffetModel();
            DGridBuffet.ItemsSource = entities.Buffet.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.BuffetModel buffet = new Model.BuffetModel();
            DGridBuffet.ItemsSource = entities.Buffet.ToList();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.BuffetModel buffet = new Model.BuffetModel();
            DGridBuffet.ItemsSource = entities.Buffet.ToList();
        }
    }
}
