using PSD_LAB.Handler;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Controller
{
    public class MakeupBrandController
    {
        MakeupBrandHandler MBH = new MakeupBrandHandler();
        public List<MakeupBrand> GetMakeupBrands()
        {
            return MBH.GetMakeupBrands();
        }
        public void RemoveMakeupBrand(int makeupbrandid)
        {
            MBH.RemoveMakeupBrand(makeupbrandid);
        }

        public int InsertMakeupBrandValidation(string name, int rating)
        {
            if (name.Length > 1 && name.Length < 99)
            {
               if ( rating > 0 && rating < 100)
                {
                    MBH.AddMakeupBrand(name, rating);
                    return 1;
                }
            }
            return 0;
        }

        public int UpdateMakeupBrandValidation(int id, string name, int rating)
        {
            if (name.Length > 1 && name.Length < 99)
            {
                if (rating > 0 && rating < 100)
                {
                    MBH.UpdateMakeupBrand(id, name, rating);
                    return 1;
                }
            }
            return 0;
        }

        public MakeupBrand GetMakeupBrandByID(int id)
        {
            return MBH.GetMakeupBrandById(id);
        }

    }
}