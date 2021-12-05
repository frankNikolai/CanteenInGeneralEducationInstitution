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
    /// Логика взаимодействия для SupplyView.xaml
    /// </summary>
    public partial class SupplyView : UserControl
    {
        Entities entities = new Entities();
        public SupplyView()
        {
            InitializeComponent();
            cbAreaProf.ItemsSource = entities.ProfessionalArea.ToList();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DGridSupply.ItemsSource = entities.Supply.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
