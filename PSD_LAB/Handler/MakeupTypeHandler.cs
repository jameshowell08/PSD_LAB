using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Handler
{
    public class MakeupTypeHandler
    {
        MakeupTypeRepository MTR = new MakeupTypeRepository();

        public List<MakeupType> GetMakeupTypes()
        {
            return MTR.GetMakeupTypes();
        }
        public void RemoveMakeupType(int makeuptypeid)
        {
            MTR.RemoveMakeupType(makeuptypeid);
        }

        public void AddMakeupType(string makeupbrandname)
        {
            MTR.addMakeupType(makeupbrandname);
        }
        public void UpdateMakeupType(int id, string name)
        {
            MTR.UpdateMakeupType(id, name);
        }
        public MakeupType GetMakeupTypeByID(int id)
        {
            return MTR.GetMakeupTypeByID((int)id);
        }
    }
}