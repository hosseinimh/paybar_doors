using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using PaybarTariff.Models;
using PaybarIranDoor.Modules.Enums;

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
                Validate(name, family, phone, plaque, cargo);
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
                Validate(name, family, phone, plaque, cargo);
                mTable.Update(id, (byte)type, name, family, nationalNo, phone, plaque, cargo);
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }
        }

        public List<KeyValuePair<string, object>> Get(int id)
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

        public List<List<KeyValuePair<string, object>>> GetPaginate(int page = 1)
        {
            AryooSqlEnumerator enumerator = null;

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

        private void Validate(string name, string family, string phone, string plaque, string cargo)
        {
            Utils.ValidateString(name);
            Utils.ValidateString(family);
            Utils.ValidateString(phone);
            Utils.ValidateString(plaque);
            Utils.ValidateString(cargo);
        }
    }
}