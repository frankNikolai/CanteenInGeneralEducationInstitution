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
    /// Логика взаимодействия для EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        Entities entities = new Entities();
        MVVM.Model.EmployeeModel employee = new Model.EmployeeModel();
        public EmployeeView()
        {
            InitializeComponent();
            cbSpec.ItemsSource = entities.Competence.ToList();
            cbWorkShift.ItemsSource = entities.WorkShift.ToList();
        }

        public void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DGridEmployee.ItemsSource = entities.Employee.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int s = Convert.ToInt32(cbSpec.SelectedValue);
            int w = Convert.ToInt32(cbWorkShift.SelectedValue);
            employee.InsertEmployee(Convert.ToString(txtFName.Text), Convert.ToString(txtLName.Text),
                Convert.ToString(txtMName.Text), s, w);
            DGridEmployee.ItemsSource = entities.Employee.ToList();
            MessageBox.Show("Данные добавлены");
            txtNum.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtMName.Clear();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            employee.DeleteEmployee(Convert.ToInt32(txtNum.Text));
            DGridEmployee.ItemsSource = entities.Employee.ToList();
            MessageBox.Show("Данные удалены");
            txtNum.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtMName.Clear();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            int s = Convert.ToInt32(cbSpec.SelectedValue);
            int w = Convert.ToInt32(cbWorkShift.SelectedValue);
            employee.UpdateEmployee(Convert.ToInt32(txtNum.Text), Convert.ToString(txtFName.Text), Convert.ToString(txtLName.Text), 
                Convert.ToString(txtMName.Text), s, w);     
            DGridEmployee.ItemsSource = entities.Employee.ToList();
            MessageBox.Show("Данные обновлены");
            txtNum.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtMName.Clear();
        }
    }
}
