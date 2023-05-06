using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PaybarIranDoor.Modules;

namespace PaybarIranDoor.Models
{
    public class Setting
    {
        private MySqlConnection sConnection;

        public Setting()
        {
            sConnection.Connect();
            if (Count()==0)
            {
                Insert();
            }
        }

        public List<KeyValuePair<string, object>> Get(int id)
        {
            var sql = string.Format("SELECT * FROM tbl_settings WHERE id={0}", id);
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

        private int Insert()
        {
            var sql = string.Format("INSERT INTO tbl_settings (transit_entrance,transit_scan,transhipment_entrance,transhipment_scan,transhipment_tonage,created_at) VALUES({0},{1},{2},{3},{4},'{5}')", 0, 0, 0, 0, 0, Utils.DateToString());
            return sConnection.ExecuteNonQuery(sql);
        }

        private int Count()
        {
            var sql = "SELECT COUNT(*) FROM tbl_settings";
            return (int)sConnection.ExecuteScalar(sql);
        }

        private List<KeyValuePair<string, object>> GetRecord(MySqlDataReader reader)
        {
            var record = new List<KeyValuePair<string, object>>();
            record.Add(new KeyValuePair<string, object>("id", reader.GetInt32(0)));
            record.Add(new KeyValuePair<string, object>("transit_entrance", reader.GetInt32(1)));
            record.Add(new KeyValuePair<string, object>("transit_scan", reader.GetInt32(2)));
            record.Add(new KeyValuePair<string, object>("transhipment_entrance", reader.GetInt32(3)));
            record.Add(new KeyValuePair<string, object>("transhipment_scan", reader.GetInt32(4)));
            record.Add(new KeyValuePair<string, object>("transhipment_tonage", reader.GetInt32(5)));
            record.Add(new KeyValuePair<string, object>("created_at", reader.GetString(6)));
            record.Add(new KeyValuePair<string, object>("updated_at", reader.GetString(7)));
            return record;
        }
    }
}