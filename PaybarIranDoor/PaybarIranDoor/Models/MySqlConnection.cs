using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PaybarIranDoor.Modules.Controllers;

namespace PaybarIranDoor.Models
{
    class MySqlConnection
    {
        private MySql.Data.MySqlClient.MySqlConnection sConnection;

        ~MySqlConnection()
        {
            try
            {
                sConnection.Close();
            }
            catch
            { }
        }

        public void Connect()
        {
            try
            {
                string connectionString = GetConnectionString();
                sConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                sConnection.Open();
            }
            catch (Exception e)
            {
                ExceptionController.LogError(e, MethodInfo.GetCurrentMethod());
            }
        }

        private static string GetConnectionString()
        {
            string conStr = null;
            try
            {
                StreamReader reader = new StreamReader(Application.StartupPath + "\\connstr.txt");
                conStr = reader.ReadLine();
                reader.Close();
            }
            catch
            {
            }
            return conStr;
        }

        public int ExecuteNonQuery(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, sConnection);
            return command.ExecuteNonQuery();
        }

        public object ExecuteScalar(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, sConnection);
            return command.ExecuteScalar();
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, sConnection);
            return command.ExecuteReader();
        }
    }
}
