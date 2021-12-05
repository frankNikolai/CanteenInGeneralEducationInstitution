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
    /// Логика взаимодействия для BasketView.xaml
    /// </summary>
    public partial class BasketView : UserControl
    {
        public BasketView()
        {
            InitializeComponent();
            if (DishesView.BasketDishes != null)
            {
                for (int i = 0; i < DishesView.BasketDishes.Length; ++i)
                {
                    txtBasket.Text += DishesView.BasketDishes[i] + "\n";
                }
            }
        }

        private void ClearBasket_Click(object sender, RoutedEventArgs e)
        {
            txtBasket.Text = "";
        }

        private void BuyBasket_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Покупка успешно совершена");
            txtBasket.Text = "";
        }
    }
}
