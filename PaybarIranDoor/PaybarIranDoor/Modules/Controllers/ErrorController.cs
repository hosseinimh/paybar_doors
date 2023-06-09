﻿using System;
using System.Reflection;
using Aryoo.Common;
using PaybarIranDoor.Models;
using PaybarIranDoor.Modules.Enums;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;
using RECORDS = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>>;

namespace PaybarIranDoor.Modules.Controllers
{
    public class ErrorController
    {
        private Error mTable;

        public ErrorController()
        {
            mTable = new Error();
        }

        public static void LogError(AryooException e)
        {
            try
            {
                ErrorController errorController = new ErrorController();
                errorController.Add(e.Class, e.Function, e.Message);
            }
            catch
            {
            }
        }

        private void Add(string className, string function, string message)
        {
            try
            {
                mTable.Insert(className, function, Make(message));
            }
            catch
            {
            }
        }

        public void RemoveErrors()
        {
            try
            {
                mTable.DeleteAll();
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }
        }

        public RECORD GetError(int id)
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

        public RECORDS GetErrors(int page = 1)
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

        private string Make(string message)
        {
            return message.Replace('\'', ' ');
        }
    }
}