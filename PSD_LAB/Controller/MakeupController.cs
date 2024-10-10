using PSD_LAB.Handler;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Controller
{
    public class MakeupController
    {
        MakeupHandler MUH = new MakeupHandler();

        public List<Makeup> GetMakeups()
        {
            return MUH.GetMakeups();
        }
        public void RemoveMakeup(int makeupid)
        {
            MUH.RemoveMakeup(makeupid);
        }

        public int InsertMakeupValidation(string name, int price, int weight, int typeid, int brandid)
        {
            if (name.Length > 1 && name.Length < 99)
            {
                if (price >= 1)
                {
                    if (weight > 1500)
                    {
                        MUH.AddMakeup(name, price, weight, typeid, brandid);
                        return 1;
                    }
                }
            }
            return 0;
        }

        public Makeup GetMakeupByID(int Id)
        {
            return MUH.GetMakeupByID(Id);
        }

        public int UpdateMakeupValidation(int id, string name, int price, int weight, int typeid, int brandid)
        {
            if (name.Length > 1 && name.Length < 99)
            {
                if (price >= 1)
                {
                    if (weight > 1500)
                    {
                        MUH.UpdateMakeup(id,name, price, weight, typeid, brandid);
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}