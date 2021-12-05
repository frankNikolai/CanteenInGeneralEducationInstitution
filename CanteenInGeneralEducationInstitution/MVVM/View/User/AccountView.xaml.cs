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
    /// Логика взаимодействия для AccountView.xaml
    /// </summary>
    public partial class AccountView : UserControl
    {
        Entities entities = new Entities();
        private static bool FirstOccurancy { get; set; } = true;
        private static int CountBorder { get; set; } = 0;
        public AccountView()
        {
            InitializeComponent();
            ShowInfo(MVVM.View.User.InputSystem.idUser);
        }

        private void ShowInfo(int idStud)
        {
            txtBlockLname.Text = (from i in entities.Student
                                  where i.ID_Student_RK == idStud
                                  select i.LastName).FirstOrDefault();
            txtBlockFname.Text = (from i in entities.Student
                                  where i.ID_Student_RK == idStud
                                  select i.FirstName).FirstOrDefault();
            txtBlockMname.Text = (from i in entities.Student
                                  where i.ID_Student_RK == idStud
                                  select i.MiddleName).FirstOrDefault();
            txtBlockStudCategory.Text = (from i in entities.StudentCategory
                                         where i.ID_StudentCategory_RK == (from j in entities.Student
                                                                           where j.ID_Student_RK == idStud
                                                                           select j.ID_StudentCategory_FK).FirstOrDefault()
                                         select i.Name).FirstOrDefault();
            txtBlockClass.Text = (from i in entities.Class
                                  where i.ID_Class_RK == (from j in entities.Student
                                                          where j.ID_Student_RK == idStud
                                                          select j.ID_Class_FK).FirstOrDefault()
                                  select i.Name).FirstOrDefault();
            txtBlockCash.Text = (from i in entities.Student
                                 where i.ID_Student_RK == idStud
                                 select i.Cash).FirstOrDefault().ToString();
        }
    }
}
