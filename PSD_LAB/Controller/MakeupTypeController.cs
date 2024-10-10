using PSD_LAB.Handler;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Controller
{
    public class MakeupTypeController
    {
        MakeupTypeHandler MTH = new MakeupTypeHandler();

        public List<MakeupType> GetMakeupTypes()
        {
            return MTH.GetMakeupTypes();
        }
        public void RemoveMakeupType(int makeuptypeid)
        {
            MTH.RemoveMakeupType(makeuptypeid);
        }
        public int InsertMakeupTypeValidation(string name)
        {
            if (name.Length > 1 && name.Length < 99)
            {
                MTH.AddMakeupType(name);
                return 1;
            }
            return 0;
        }

        public int UpdateMakeupTypeValidation(int id, string name)
        {
            if (name.Length > 1 && name.Length < 99)
            {
                MTH.UpdateMakeupType(id, name);
                return 1;
            }
            return 0;
        }

        public MakeupType GetMakeupTypeByID(int id)
        {
            return MTH.GetMakeupTypeByID(id);
        }

    }
}