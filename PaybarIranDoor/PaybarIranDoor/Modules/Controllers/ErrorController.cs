using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using PaybarTariff.Models;

namespace PaybarIranDoor.Modules.Controllers
{
    public class ErrorController : BaseController
    {
        private ErrorTable error;

        public ErrorController()
        {
            error = new ErrorTable(false);
            aryooColumns = new AryooColumns(new string[] { "Id=>Id", "OperatorId=>OperatorId", "OperatorName=>OperatorName", "Class=>Class", "Function=>Function", "Message=>Message", "Year=>Year", "Month=>Month", "Day=>Day", "Hour=>Hour", "Minute=>Minute", "Second=>Second" });
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
                ErrorTable errorTable = new ErrorTable(false);
                errorTable.Insert(className, function, Make(message));
            }
            catch
            {
            }
        }

        public void RemoveErrors()
        {
            try
            {
                error.Delete();
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, System.Reflection.MethodInfo.GetCurrentMethod());
            }
        }

        public AryooDataRow GetError(int id)
        {
            AryooDataRow returnRow = null;

            try
            {
                returnRow = MakeDataRow(aryooColumns, error.Get(id));
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, System.Reflection.MethodInfo.GetCurrentMethod());
            }

            return returnRow;
        }

        public AryooSqlEnumerator GetErrors()
        {
            AryooSqlEnumerator enumerator = null;

            try
            {
                enumerator = new AryooSqlEnumerator(error.Gets(), aryooColumns);
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, System.Reflection.MethodInfo.GetCurrentMethod());
            }

            return enumerator;
        }

        private string Make(string message)
        {
            return message.Replace('\'', ' ');
        }

        public string MakeXML()
        {
            string xmlPath = Application.StartupPath + "\\errors.xml";

            try
            {
                StreamWriter writer = new StreamWriter(xmlPath, false, UTF8Encoding.UTF8);
                AryooSqlEnumerator enumerator = null;
                enumerator = new AryooSqlEnumerator(error.Gets(), aryooColumns);
                writer.WriteLine("<errors>");

                while (enumerator.MoveNext())
                {
                    writer.WriteLine("\t<error operator=\"" + enumerator.Current["OperatorName"] + "\" year=\"" + enumerator.Current["Year"] + "\" month=\"" + enumerator.Current["Month"] + "\" day=\"" + enumerator.Current["Day"] + "\" hour=\"" + enumerator.Current["Hour"] + "\" minute=\"" + enumerator.Current["Minute"] + "\" second=\"" + enumerator.Current["Second"] + "\">");
                    writer.WriteLine("\t\t<class>" + enumerator.Current["Class"] + "</class>");
                    writer.WriteLine("\t\t<function>" + enumerator.Current["Function"] + "</function>");
                    writer.WriteLine("\t\t<message>");
                    writer.WriteLine("\t\t\t" + enumerator.Current["Message"].ToString());
                    writer.WriteLine("\t\t</message>");
                    writer.WriteLine("\t</error>");
                }

                writer.WriteLine("</errors>");
                writer.Flush();
                writer.Close();
            }
            catch (Exception e)
            {
                xmlPath = null;
                ExceptionController.LogError(e, System.Reflection.MethodInfo.GetCurrentMethod());

                if (File.Exists(xmlPath))
                {
                    try
                    {
                        File.Delete(xmlPath);
                    }
                    catch
                    {
                    }
                }
            }

            return xmlPath;
        }
    }
}