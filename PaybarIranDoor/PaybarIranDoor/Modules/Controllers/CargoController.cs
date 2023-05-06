using System;
using System.Reflection;
using PaybarIranDoor.Models;
using PaybarIranDoor.Modules.Enums;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;
using RECORDS = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>>;

namespace PaybarIranDoor.Modules.Controllers
{
    public class CargoController
    {
        private Cargo mTable;

        public CargoController()
        {
            mTable = new Cargo();
        }

        private void Add(CargoOperationType type, string name, string family, string nationalNo, string phone, string plaque, string cargo)
        {
            try
            {
                Validate(ref name, ref family, ref phone, ref plaque, ref cargo);
                mTable.Insert((byte)type, name, family, nationalNo, phone, plaque, cargo);
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }
        }

        private void Edit(int id, CargoOperationType type, string name, string family, string nationalNo, string phone, string plaque, string cargo)
        {
            try
            {
                Validate(ref name, ref family, ref phone, ref plaque, ref cargo);
                mTable.Update(id, (byte)type, name, family, nationalNo, phone, plaque, cargo);
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

        private void Validate(ref string name, ref string family, ref string phone, ref string plaque, ref string cargo)
        {
            Utils.ValidateString(ref name);
            Utils.ValidateString(ref family);
            Utils.ValidateString(ref phone);
            Utils.ValidateString(ref plaque);
            Utils.ValidateString(ref cargo);
        }
    }
}