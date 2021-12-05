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
    /// Логика взаимодействия для SaleView.xaml
    /// </summary>
    public partial class SaleView : UserControl
    {
        Entities entities = new Entities();
        public SaleView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
            DGridSale.ItemsSource = entities.Sale.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.SaleModel sale = new Model.SaleModel();
            sale.InsertSale(txtLName.Text, txtPrice.Text);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.SaleModel sale = new Model.SaleModel();
            sale.DeleteSale(Convert.ToInt32(txtNum.Text));
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.SaleModel sale = new Model.SaleModel();
            sale.UpdateSale(Convert.ToInt32(txtNum.Text), txtLName.Text, txtPrice.Text);
        }
    }
}
