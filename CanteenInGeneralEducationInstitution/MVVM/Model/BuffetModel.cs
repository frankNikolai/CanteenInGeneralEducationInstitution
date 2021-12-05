using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenInGeneralEducationInstitution.MVVM.Model
{
    public class BuffetModel
    {
        Entities entities = new Entities();
        public bool InsertBuffet(string buffetName)
        {
            try
            {
                Buffet buffer = new Buffet();
                buffer.Name = buffetName;
                entities.Buffet.Add(buffer);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteBuffet(int id)
        {
            try
            {
                var DRow = entities.Buffet.Where(w => w.ID_Buffet_RK == id).FirstOrDefault();
                entities.Buffet.Remove(DRow);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateBuffet(int id, string buffetName)
        {
            try
            {
                var URow = entities.Buffet.Where(w => w.ID_Buffet_RK == id).FirstOrDefault();
                URow.Name = buffetName;
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
