using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenInGeneralEducationInstitution.MVVM.Model
{
    public class DinningRoomModel
    {
        Entities entities = new Entities();
        public bool InsertDinningRoom(string name, string sname, string bname)
        {
            try
            {
                DinningRoom dinningRoom = new DinningRoom();
                dinningRoom.Name = name;
                dinningRoom.Supply.Name = sname;
                dinningRoom.Buffet.Name = bname;
                entities.DinningRoom.Add(dinningRoom);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteDinningRoom(int id)
        {
            try
            {
                var DRow = entities.DinningRoom.Where(w => w.ID_DinningRoom == id).FirstOrDefault();
                entities.DinningRoom.Remove(DRow);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateDinningRoom(int id, string name, string sname, string bname)
        {
            try
            {
                var URow = entities.DinningRoom.Where(w => w.ID_DinningRoom == id).FirstOrDefault();
                URow.Name = name;
                URow.Supply.Name = sname;
                URow.Buffet.Name = bname;
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
