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
    /// Логика взаимодействия для DinningRoomView.xaml
    /// </summary>
    public partial class DinningRoomView : UserControl
    {
        Entities entities = new Entities();
        public DinningRoomView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DGridDinning.ItemsSource = entities.DinningRoom.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.DinningRoomModel roomModel = new Model.DinningRoomModel();
            roomModel.InsertDinningRoom(txtName.Text, txtSupply.Text, txtBuffet.Text);
            DGridDinning.ItemsSource = entities.DinningRoom.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.DinningRoomModel roomModel = new Model.DinningRoomModel();
            roomModel.DeleteDinningRoom(Convert.ToInt32(txtNum.Text));
            DGridDinning.ItemsSource = entities.DinningRoom.ToList();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.DinningRoomModel roomModel = new Model.DinningRoomModel();
            roomModel.UpdateDinningRoom(Convert.ToInt32(txtNum.Text), txtName.Text, txtSupply.Text, txtBuffet.Text);
            DGridDinning.ItemsSource = entities.DinningRoom.ToList();
        }
    }
}
