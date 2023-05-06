using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PaybarIranDoor.Modules;

namespace PaybarIranDoor.Models
{
    public class Error
    {
        private MySqlConnection sConnection;

        public Error()
        {
            sConnection.Connect();
        }

        public int Insert(string className, string function, string message)
        {
            var sql = string.Format("INSERT INTO tbl_errors (class,function,message,created_at) VALUES('{0}','{1}','{2}','{3}')", className, function, message, Utils.DateToString());
            return sConnection.ExecuteNonQuery(sql);
        }

        public int Delete()
        {
            var sql = "DELETE FROM tbl_errors";
            return sConnection.ExecuteNonQuery(sql);
        }

        public List<KeyValuePair<string, object>> Get(int id)
        {
            var sql = string.Format("SELECT * FROM tbl_errors WHERE id={0}", id);
            using (MySqlDataReader reader = sConnection.ExecuteReader(sql))
            {
                var record = new List<KeyValuePair<string, object>>();
                if (reader.Read())
                {
                    return GetRecord(reader);
                }
            }
            return null;
        }

        public List<List<KeyValuePair<string, object>>> GetPaginate(int page = 1)
        {
            var sql = string.Format("SELECT * FROM tbl_errors LIMIT {0},{1}", (page - 1) * Utils.PageItems, Utils.PageItems);
            var records = new List<List<KeyValuePair<string, object>>>();
            using (MySqlDataReader reader = sConnection.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    records.Add(GetRecord(reader));
                }
            }
            return records.Count > 0 ? records : null;
        }

        private List<KeyValuePair<string, object>> GetRecord(MySqlDataReader reader)
        {
            var record = new List<KeyValuePair<string, object>>();
            record.Add(new KeyValuePair<string, object>("id", reader.GetInt32(0)));
            record.Add(new KeyValuePair<string, object>("class", reader.GetString(1)));
            record.Add(new KeyValuePair<string, object>("function", reader.GetString(2)));
            record.Add(new KeyValuePair<string, object>("message", reader.GetString(3)));
            record.Add(new KeyValuePair<string, object>("created_at", reader.GetString(4)));
            record.Add(new KeyValuePair<string, object>("updated_at", reader.GetString(5)));
            return record;
        }
    }
}