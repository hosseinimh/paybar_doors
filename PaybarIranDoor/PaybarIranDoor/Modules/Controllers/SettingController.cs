using System;
using System.Reflection;
using PaybarIranDoor.Models;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;

namespace PaybarIranDoor.Modules.Controllers
{
    public class SettingController
    {
        private Setting mTable;

        public SettingController()
        {
            mTable = new Setting();
        }

        public void Edit(int transitEntrance, int transitScan, int transhipmentEntrance, int transhipmentScan, int transhipmentTonage)
        {
            try
            {
                mTable.Update(transhipmentEntrance, transitScan, transhipmentEntrance, transhipmentScan, transhipmentTonage);
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }
        }

        public RECORD Get()
        {
            try
            {
                return mTable.Get();
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }

            return null;
        }
    }
}