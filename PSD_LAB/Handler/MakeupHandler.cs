using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Handler
{
    public class MakeupHandler
    {
        MakeupRepository MUR = new MakeupRepository();

        public List<Makeup> GetMakeups()
        {
            return MUR.GetMakeups();
        }
        public void RemoveMakeup(int makeupid)
        {
            MUR.RemoveMakeup(makeupid);
        }
        public void AddMakeup(string name, int price, int weight, int typeid, int brandid)
        {
            MUR.addMakeup(name, price, weight, typeid, brandid);
        }
        
        public Makeup GetMakeupByID(int Id)
        {
            return MUR.GetMakeupByID(Id);
        }
        public void UpdateMakeup(int id, string name, int price, int weight, int typeid, int brandid)
        {
            MUR.UpdateMakeup(id, name, price, weight, typeid,brandid);
        }


    }
}