using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenInGeneralEducationInstitution.MVVM.Model
{
    class SaleModel
    {
        Entities entities = new Entities();
        public bool InsertSale(string Lname, string price)
        {
            try
            {
                Sale sale = new Sale();
                sale.Student.LastName = Lname;
                sale.Price = Convert.ToDecimal(price);
                entities.Sale.Add(sale);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteSale(int id)
        {
            try
            {
                var DRow = entities.Sale.Where(w => w.ID_Sale_RK == id).FirstOrDefault();
                entities.Sale.Remove(DRow);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateSale(int id, string Lname, string price)
        {
            try
            {
                var URow = entities.Sale.Where(w => w.ID_Sale_RK == id).FirstOrDefault();
                URow.Student.LastName = Lname;
                URow.Price = Convert.ToDecimal(price);
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
