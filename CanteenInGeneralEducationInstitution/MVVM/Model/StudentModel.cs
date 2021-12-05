using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenInGeneralEducationInstitution.MVVM.Model
{
    public class StudentModel
    {
        Entities entities = new Entities();
        public bool InsertStudent(string fName, string lName, string mName, int category, int class_, string cash)
        {
            try
            {
                Student student = new Student();
                if(fName != "" && fName != null) student.FirstName = fName;
                if (lName != "" && lName != null) student.LastName = lName;
                if (mName != "" && mName != null) student.MiddleName = mName;
                if (category != 0) student.ID_StudentCategory_FK = category;
                if (class_ != 0) student.ID_Class_FK = class_;
                if (cash != "" && cash != null) student.Cash = Convert.ToDecimal(cash);
                entities.Student.Add(student);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteStudent(int id)
        {
            try
            {
                var DRow = entities.Student.Where(w => w.ID_Student_RK == id).FirstOrDefault();
                entities.Student.Remove(DRow);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateStudent(int id, string fName, string lName, string mName, int category, int class_, string cash)
        {
            try
            {
                var DRow = entities.Student.Where(w => w.ID_Student_RK == id).FirstOrDefault();
                if (fName != "" && fName != null) DRow.FirstName = fName;
                if (lName != "" && lName != null) DRow.LastName = lName;
                if (mName != "" && mName != null) DRow.MiddleName = mName;
                if (category != 0) DRow.ID_StudentCategory_FK = category;
                if (class_ != 0) DRow.ID_Class_FK = class_;
                if (cash != "" && cash != null) DRow.Cash = Convert.ToDecimal(cash);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
