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
    /// Логика взаимодействия для StudentsView.xaml
    /// </summary>
    public partial class StudentsView : UserControl
    {
        Entities entities = new Entities();
        public StudentsView()
        {
            InitializeComponent();
            cbCategory.ItemsSource = entities.StudentCategory.ToList();
            cbClass.ItemsSource = entities.Class.ToList();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DGridStudents.ItemsSource = entities.Student.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.StudentModel student = new Model.StudentModel();
            student.InsertStudent(txtFName.Text, txtLName.Text, txtMName.Text,
                Convert.ToInt32(cbCategory.SelectedValue), Convert.ToInt32(cbClass.SelectedValue), txtCash.Text);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.StudentModel student = new Model.StudentModel();
            student.DeleteStudent(Convert.ToInt32(txtNum.Text));
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            MVVM.Model.StudentModel student = new Model.StudentModel();
            student.UpdateStudent(Convert.ToInt32(txtNum.Text), txtFName.Text, txtLName.Text, txtMName.Text,
                Convert.ToInt32(cbCategory.SelectedValue), Convert.ToInt32(cbClass.SelectedValue), txtCash.Text);
        }
    }
}
