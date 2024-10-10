using PSD_LAB.Factory;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace PSD_LAB.Repositories
{
    public class MakeupTypeRepository
    {
        public Database1Entities db = DatabaseSingleton.GetInstance();
        MakeupTypeFactory MTF = new MakeupTypeFactory();

        public void addMakeupType(string makeuptypename)
        {
            MakeupType makeuptype = MTF.createMakeupType(GenerateID(),makeuptypename);
            db.MakeupTypes.Add(makeuptype);
            db.SaveChanges();
         
        }
        public int GenerateID()
        {
            return GetLastID() + 1;
        }
        public int GetLastID()
        {
            return (from x in db.MakeupTypes select x.MakeupTypeID).ToList().LastOrDefault();
        }
        public List<MakeupType> GetMakeupTypes()
        {
            return db.MakeupTypes.ToList();
        }

        public void RemoveMakeupType(int makeuptypeid)
        {
            MakeupType makeuptype = db.MakeupTypes.Find(makeuptypeid);
            db.MakeupTypes.Remove(makeuptype);
            db.SaveChanges();
        }

        public MakeupType GetMakeupTypeByID(int Id)
        {
            return db.MakeupTypes.Where(x=>x.MakeupTypeID == Id).FirstOrDefault();
        }
        public void UpdateMakeupType(int id, string name)
        {
            MakeupType makeuptype = db.MakeupTypes.Find(id);
            makeuptype.MakeupTypeID = id;
            makeuptype.MakeupTypeName = name;
            db.SaveChanges();
        }
    }
}