using System;
using System.Reflection;
using PaybarIranDoor.Models;
using PaybarIranDoor.Modules.Enums;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;
using RECORDS = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>>;

namespace PaybarIranDoor.Modules.Controllers
{
    public class UserController
    {
        private User mTable;

        public UserController()
        {
            mTable = new User();
        }

        private void Add(string username, string password, string name, string family, UserRole role)
        {
            try
            {
                Validate(ref name, ref family);
                mTable.Insert(username, password, name, family, (byte)role);
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }
        }

        private void Edit(int id, string name, string family, UserRole role)
        {
            try
            {
                Validate(ref name, ref family);
                mTable.Update(id, name, family, (byte)role);
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }
        }

        public RECORD Get(int id)
        {
            try
            {
                return mTable.Get(id);
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }

            return null;
        }

        public RECORDS GetPaginate(int page = 1)
        {
            try
            {
                return mTable.GetPaginate(page);
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }

            return null;
        }

        private void Validate(ref string name, ref string family)
        {
            Utils.ValidateString(ref name);
            Utils.ValidateString(ref family);
        }
    }
}