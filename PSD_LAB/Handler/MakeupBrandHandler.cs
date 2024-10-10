using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Handler
{
    public class MakeupBrandHandler
    {
        MakeupBrandRepository MBR = new MakeupBrandRepository();

        public List<MakeupBrand> GetMakeupBrands()
        {
            return MBR.GetMakeupBrands();
        }
        public void RemoveMakeupBrand(int makeupbrandid)
        {
            MBR.RemoveMakeupBrand(makeupbrandid);
        }
        
        public void AddMakeupBrand(string makeupbrandname, int makeupbrandrating)
        {
            MBR.addMakeupBrand(makeupbrandname, makeupbrandrating);
        }
        public void UpdateMakeupBrand(int id, string name, int price)
        {
            MBR.UpdateMakeupBrand(id, name, price);
        }

        public MakeupBrand GetMakeupBrandById(int id)
        {
            return MBR.GetMakeupBrandById(id);
        }
    }
}