using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Factory
{
    public class MakeupBrandFactory
    {
        public MakeupBrand createMakeupBrand(int makeupbrandid, string makeupbrandname, int makeuptyperating)
        {
            MakeupBrand makeupbrand = new MakeupBrand();
            makeupbrand.MakeupBrandID = makeupbrandid;
            makeupbrand.MakeupBrandName = makeupbrandname;
            makeupbrand.MakeupBrandRating = makeuptyperating;
            return makeupbrand;
        }
    }
}