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
    /// Логика взаимодействия для DishesView.xaml
    /// </summary>
    public partial class DishesView : UserControl
    {
        Entities entities = new Entities();
        public static int NumberDish { get; set; }
        public static bool buttonComplex { get; set; } = false;
        public DishesView()
        {
            InitializeComponent();

            NumberDish = RetutnMin();
            changeInfo();
        }

        int RetutnMin()
        {
            return (from i in entities.Dish
                    select i.ID_Dish_RK).Min();
        }

        int RetutnMax()
        {
            return (from i in entities.Dish
                    select i.ID_Dish_RK).Max();
        }

        void changeInfo()
        {
            Grid.SetColumnSpan(txtInscriptionName, 2);
            Grid.SetColumnSpan(txtBlName, 2);
            Grid.SetColumn(txtBlName, 1);
            Grid.SetRow(txtBlName, 1);
            txtBlName.Text = (from i in entities.Dish
                              where i.ID_Dish_RK == NumberDish
                              select i.Name).FirstOrDefault();
            txtBlCost.Text = (from i in entities.Dish
                              where i.ID_Dish_RK == NumberDish
                              select i.Cost).FirstOrDefault().ToString();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NumberDish > RetutnMin())
            {
                if (buttonComplex == false)
                {
                    NumberDish--;
                    changeInfo();
                }
                else
                {
                    MessageBox.Show("Хотите выйти из выбора комплекс. еды?");
                    changeInfo();
                    buttonComplex = false;
                }
            }
            else
            {
                MessageBox.Show("Это первый элемент в данной последовательности");
                changeInfo();
            }
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            if (NumberDish < RetutnMax())
            {
                NumberDish++;
                changeInfo();
            }
            else
            {
                MessageBox.Show("Это последний элемент в данной последовательности");
            }
        }

        public static string[] BasketDishes { get; set; } = { "", "", "", "", "" };
        public static int NumberBasketDishes { get; set; } = 0;

        private void AddDish_Click(object sender, RoutedEventArgs e)
        {
            if (NumberBasketDishes < 5)
            {
                BasketDishes[NumberBasketDishes] = (from j in entities.Dish
                                                    where j.ID_Dish_RK == NumberDish
                                                    select j.Name).FirstOrDefault();
                MessageBox.Show("Товар добавлен в корзину");

                NumberBasketDishes++;
            }
            else
            {
                MessageBox.Show("Совокупное количество продукции не должно превышать 5 шт");
            }
        }

        private void BuyDish_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар успешно приобретён");
        }
    }
}
