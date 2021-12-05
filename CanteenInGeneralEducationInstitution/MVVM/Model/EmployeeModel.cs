using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenInGeneralEducationInstitution.MVVM.Model
{
    public class EmployeeModel
    {
        Entities entities = new Entities();
        public bool InsertEmployee(string fName, string lName, string mName, int spec, int workShift)
        {
            try
            {
                Employee employee = new Employee();
                employee.FirstName = fName;
                employee.LastName = lName;
                employee.MiddleName = mName;
                if (spec != 0) employee.ID_Competence_FK = spec;
                if (workShift != 0) employee.ID_WorkShift_FK = workShift;
                entities.Employee.Add(employee);
                entities.SaveChanges();
            }
            catch 
            {
                return false;
            }
            return true;
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                var DRow = entities.Employee.Where(w => w.ID_Employee_RK == id).FirstOrDefault();
                entities.Employee.Remove(DRow);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateEmployee(int id, string fName, string lName, string mName, int spec, int workShift)
        {
            try
            {
                var URow = entities.Employee.Where(w => w.ID_Employee_RK == id).FirstOrDefault();
                if (fName != "" && fName != null) URow.FirstName = fName;
                if (lName != "" && lName != null) URow.LastName = lName;
                if (mName != "" && mName != null) URow.MiddleName = mName;
                if (spec != 0) URow.ID_Competence_FK = spec;
                if (workShift != 0) URow.ID_WorkShift_FK = workShift;
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
