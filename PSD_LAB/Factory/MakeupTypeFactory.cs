using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Factory
{
    public class MakeupTypeFactory
    {
        public MakeupType createMakeupType(int makeuptypeid, string makeuptypename)
        {
            MakeupType makeuptype = new MakeupType();
            makeuptype.MakeupTypeID = makeuptypeid;
            makeuptype.MakeupTypeName = makeuptypename;
            return makeuptype;
        }
    }
}