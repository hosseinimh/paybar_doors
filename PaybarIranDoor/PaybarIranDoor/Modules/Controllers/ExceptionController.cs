using System;
using System.Reflection;
using System.Windows.Forms;

namespace PaybarIranDoor.Modules.Controllers
{
    public static class ExceptionController
    {
        public static void LogError(Exception e, MethodBase methodBase)
        {
            string className = methodBase.ReflectedType.Name;
            string function = methodBase.Name;
            MessageBox.Show(e.Message + " " + className + " " + function, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AryooException aEx = new AryooException(className, function, e.Message, ExceptionLevel.Warning);
            ErrorController.LogError(aEx);
        }

        public static void LogError(AryooException e)
        {
            AryooMessageBox.Show(e);
        }
    }
}