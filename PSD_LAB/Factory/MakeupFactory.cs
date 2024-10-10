using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Factory
{
    public class MakeupFactory
    {
        public Makeup createMakeup(int makeupid, string makeupname, int makeupprice, int makeupweight, int makeuptypeid, int makeupbrandid)
        {
            Makeup makeup = new Makeup();
            makeup.MakeupID = makeupid;
            makeup.MakeupName = makeupname;
            makeup.MakeupPrice = makeupprice;  
            makeup.MakeupWeight = makeupweight;
            makeup.MakeupTypeID = makeuptypeid;
            makeup.MakeupBrandID = makeupbrandid;
            return makeup;
        }
    }
}