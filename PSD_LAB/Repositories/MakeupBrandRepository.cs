using PSD_LAB.Factory;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Repositories
{
    public class MakeupBrandRepository
    {
        public Database1Entities db = DatabaseSingleton.GetInstance();
        MakeupBrandFactory MBF = new MakeupBrandFactory();

        public void addMakeupBrand(string makeupbrandname, int makeupbrandrating)
        {
            MakeupBrand makeupbrand = MBF.createMakeupBrand(GenerateID(), makeupbrandname, makeupbrandrating);
            db.MakeupBrands.Add(makeupbrand);
            db.SaveChanges();

        }
        public int GenerateID()
        {
            return GetLastID() + 1;
        }
        public int GetLastID()
        {
            return (from x in db.MakeupBrands select x.MakeupBrandID).ToList().LastOrDefault();
        }
        public List<MakeupBrand> GetMakeupBrands()
        {
            return db.MakeupBrands.OrderByDescending(x => x.MakeupBrandRating).ToList();
        }

        public void RemoveMakeupBrand(int makeupbrandid) 
        {
            MakeupBrand makeupbrand = db.MakeupBrands.Find(makeupbrandid);
            db.MakeupBrands.Remove(makeupbrand);
            db.SaveChanges();
        }
        public MakeupBrand GetMakeupBrandById(int Id)
        {
            return db.MakeupBrands.Where(x=>x.MakeupBrandID == Id).FirstOrDefault();
        }
        public void UpdateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrand makeupbrand = db.MakeupBrands.Find(id);
            makeupbrand.MakeupBrandID = id;
            makeupbrand.MakeupBrandName = name;
            makeupbrand.MakeupBrandRating = rating;
            db.SaveChanges();
        }
    }
}