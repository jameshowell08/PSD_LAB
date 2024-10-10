using PSD_LAB.Factory;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Repositories
{
    public class MakeupRepository
    {
        public Database1Entities db = DatabaseSingleton.GetInstance();
        MakeupFactory MUF = new MakeupFactory();

        public void addMakeup(string makeupname, int makeupprice, int makeupweight, int makeuptypeid, int makeupbrandid)
        {
            Makeup makeup = MUF.createMakeup(GenerateID(), makeupname, makeupprice, makeupweight, makeuptypeid, makeupbrandid);
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }

        public int GenerateID()
        {
            return GetLastID() + 1;
        }
        public int GetLastID()
        {
            return (from x in db.Makeups select x.MakeupID).ToList().LastOrDefault();
        }
        public List<Makeup> GetMakeups()
        {
            return db.Makeups.ToList();
        }
        public void RemoveMakeup(int makeupid)
        {
            Makeup makeup = db.Makeups.Find(makeupid);
            db.Makeups.Remove(makeup);
            db.SaveChanges();
        }
        public Makeup GetMakeupByID(int Id)
        {
            return db.Makeups.Where(x=> x.MakeupID == Id).FirstOrDefault();
        }

        public void UpdateMakeup(int id, string name, int price, int weight, int typeid, int brandid)
        {
            Makeup makeup=db.Makeups.Find(id);
            makeup.MakeupID = id;
            makeup.MakeupName = name;
            makeup.MakeupPrice = price;
            makeup.MakeupWeight = weight;
            makeup.MakeupTypeID = typeid;
            makeup.MakeupBrandID = brandid;
            db.SaveChanges();
        }


    }
}