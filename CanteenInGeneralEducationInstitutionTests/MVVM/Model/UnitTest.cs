using Microsoft.VisualStudio.TestTools.UnitTesting;
using CanteenInGeneralEducationInstitution.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenInGeneralEducationInstitution.MVVM.Model.Tests
{
    [TestClass()]
    public class BuffetModelTestst
    {
        MVVM.Model.BuffetModel buffetModel = new BuffetModel();
        // INSERT
        [TestMethod()]
        public void InsertBuffetTestCorrectData()
        {
            //Arange
            bool actual = true, expected = true;
            string name = "буфет";
            //Act
            actual = buffetModel.InsertBuffet(name);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InsertBuffetTestIncorrectData()
        {
            //Arange
            bool actual = false, expected = false;
            string name = "!@#$%^&*()_+";
            //Act
            actual = buffetModel.InsertBuffet(name);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InsertBuffetTestBorederData()
        {
            //Arange
            bool actual = false, expected = false;
            string name = "буфет;";
            //Act
            actual = buffetModel.InsertBuffet(name);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //DELETE
        [TestMethod()]
        public void DeleteBuffetTestCorrectData()
        {
            //Arange
            bool actual = true, expected = true;
            int id = 1;
            //Act
            actual = buffetModel.DeleteBuffet(id);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DeleteBuffetTestIncorrectData()
        {
            //Arange
            bool actual = false, expected = false;
            string id = "$";
            //Act
            try { actual = buffetModel.DeleteBuffet(Convert.ToInt32(id)); } catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DeleteBuffetTestBorderData()
        {
            //Arange
            bool actual = false, expected = false;
            ulong id = 90000000000000000;
            //Act
            try { actual = buffetModel.DeleteBuffet(Convert.ToInt32(id)); } catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //UPDATE
        [TestMethod()]
        public void UpdateBuffetTestCorrectData()
        {
            //Arange
            bool actual = true, expected = true;
            int id = 1;
            string name = "буфет";
            //Act
            actual = buffetModel.UpdateBuffet(id, name);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void UpdateBuffetTestIncorrectData()
        {
            //Arange
            bool actual = false, expected = false;
            int id = -1;
            string name = "буфет:";
            //Act
            try { actual = buffetModel.UpdateBuffet(id, name); } catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void UpdateBuffetTestBorderData()
        {
            //Arange
            bool actual = false, expected = false;
            int id = 1;
            string name = "буфет$";
            //Act
            actual = buffetModel.UpdateBuffet(id, name);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    /*


    ПРОБЕЛ


    */
    [TestClass()]
    public class DinningRoomModelTests
    {
        MVVM.Model.DinningRoomModel dinningRoomModel = new DinningRoomModel();
        //INSERT
        [TestMethod()]
        public void InsertDinningRoomTestCorrectData()
        {
            //Arange
            bool actual = true, expected = true;
            string name = "столовая № 1",
                   sname = "ООО \"Сибкаб\"",
                   bname = "Буфет";
            //Act
            actual = dinningRoomModel.InsertDinningRoom(name, sname, bname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void InsertDinningRoomTestIncorrectData()
        {
            //Arange
            bool actual = false, expected = false;
            object name = "&&||",
                   sname = 3,
                   bname = '@';
            //Act
            try { actual = dinningRoomModel.InsertDinningRoom(Convert.ToString(name),
                Convert.ToString(sname), Convert.ToString(bname)); } catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void InsertDinningRoomTestBorderData()
        {
            //Arange
            bool actual = false, expected = false;
            string name = "столовая № 1";
            string sname = "#";
            char bname = '@';
            //Act
            try { actual = dinningRoomModel.InsertDinningRoom(Convert.ToString(name),
                Convert.ToString(sname), Convert.ToString(bname)); } catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //DELETE
        [TestMethod()]
        public void DeleteDinningRoomTestCorrectData()
        {
            //Arange
            bool actual = true, expected = true;
            int id = 120;
            //Act
            actual = dinningRoomModel.DeleteDinningRoom(id);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DeleteDinningRoomTestIncorrectData()
        {
            //Arange
            bool actual = false, expected = false;
            object id = "haha";
            //Act
            try { actual = dinningRoomModel.DeleteDinningRoom(Convert.ToInt32(id)); } catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DeleteDinningRoomTestBorderData()
        {
            //Arange
            bool actual = false, expected = false;
            object id = "120#";
            //Act
            try { actual = dinningRoomModel.DeleteDinningRoom(Convert.ToInt32(id)); } catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //UPDATE
        [TestMethod()]
        public void UpdateDinningRoomTestCorrectData()
        {
            //Arange
            bool actual = true, expected = true;
            int id = 120;
            string name = "столовая № 1",
                   sname = "ООО \"Сибкаб\"",
                   bname = "Буфет";
            //Act
            actual = dinningRoomModel.UpdateDinningRoom(id, name, sname, bname); 
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void UpdateDinningRoomTestIncorrectData()
        {
            //Arange
            bool actual = false, expected = false;
            object id = "&&",
                   name = 3,
                   sname = 3.000000000000000000000012,
                   bname = '^';
            //Act
            try
            {
                actual = dinningRoomModel.UpdateDinningRoom(Convert.ToInt32(id), Convert.ToString(name),
               Convert.ToString(sname), Convert.ToString(bname));
            }
            catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void UpdateDinningRoomTestBorderData()
        {
            //Arange
            bool actual = false, expected = false;
            //Act
            object id = "120",
                   name = "пел",
                   sname = 3.000000000000000000000012,
                   bname = 'к';
            //Assert
            actual = dinningRoomModel.UpdateDinningRoom(Convert.ToInt32(id), Convert.ToString(name),
                Convert.ToString(sname), Convert.ToString(bname));
            Assert.AreEqual(expected, actual);
        }
    }
    /*


    ПРОБЕЛ


    */
    [TestClass()]
    public class EmployeeModelTests
    {
        MVVM.Model.EmployeeModel employeeModel = new EmployeeModel();
        //INSERT
        [TestMethod()]
        public void InsertEmployeeTestCorrectData()
        {
            //Arange
            bool actual = true, expected = true;
            string fName = "Кравцов",
                lName = "Рябцов",
                mName = "Антонович";
            int spec = 1,
                ws = 2;
            //Act
            actual = employeeModel.InsertEmployee(fName, lName, mName, spec, ws);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void InsertEmployeeTestIncorrectData()
        {
            //Arange
            bool actual = false, expected = false;
            object fName = "#",
                 lName = '^',
                 mName = "][",
                spec = 5.13,
                ws = new int[3];
            //Act
            try {actual = employeeModel.InsertEmployee(Convert.ToString(fName),
                Convert.ToString(lName), Convert.ToString(mName), Convert.ToInt32(spec),
                Convert.ToInt32(ws)); } catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void InsertEmployeeTestBorderData()
        {
            //Arange
            bool actual = false, expected = false;
            object fName = "Кравцов",
                  lName = "Рябцов",
                  mName = "Антонович",
                 spec = 1,
                 ws = 3.14;
            //Act

            actual = employeeModel.InsertEmployee(Convert.ToString(fName),
                Convert.ToString(lName), Convert.ToString(mName), Convert.ToInt32(spec),
                Convert.ToInt32(ws));
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //DELETE
        [TestMethod()]
        public void DeleteEmployeeTestCorrectData()
        {
            //Arange
            bool actual = true, expected = true;
            int id = 120;
            //Act
            actual = employeeModel.DeleteEmployee(id);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DeleteEmployeeTestIncorrectData()
        {
            //Arange
            bool actual = false, expected = false;
            object id = 'l';
            //Act
            actual = employeeModel.DeleteEmployee(Convert.ToInt32(id));
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DeleteEmployeeTestBorderData()
        {
            //Arange
            bool actual = false, expected = false;
            float id = 3.14f;
            //Act
            actual = employeeModel.DeleteEmployee(Convert.ToInt32(id));
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //UPDATE
        [TestMethod()]
        public void UpdateEmployeeTestCorrectData()
        {
            //Arange
            bool actual = true, expected = true;
            string fName = "Кравцов",
                 lName = "Рябцов",
                 mName = "Антонович";
            int id = 120,
                spec = 1,
                ws = 2;
            //Act
            actual = employeeModel.UpdateEmployee(id, fName, lName, mName, spec, ws);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void UpdateEmployeeTestIncorrectData()
        {
            //Arange
            bool actual = false, expected = false;
            object fName = '-',
                   lName = "*",
                   mName = "=",
                   id = -1,
                   spec = new string[3],
                   ws = -120;
            //Act
            try {actual = employeeModel.UpdateEmployee(Convert.ToInt32(id), Convert.ToString(fName), 
                Convert.ToString(lName), Convert.ToString(mName), Convert.ToInt32(spec), Convert.ToInt32(ws));}
            catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void UpdateEmployeeTestBorderData()
        {
            //Arange
            bool actual = false, expected = false;
            string fName = "Кравцов",
                 lName = "Рябцов",
                 mName = "Антонович";
            int id = 120,
                spec = -1,
                ws = 2;
            //Act
            try { actual = employeeModel.UpdateEmployee(id, fName, lName, mName, spec, ws); } catch { }
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    
}