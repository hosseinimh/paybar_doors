using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PaybarIranDoor.Modules;
using PaybarIranDoor.Modules.Enums;

namespace PaybarIranDoor.Models
{
    public class User
    {
        private MySqlConnection sConnection;

        public User()
        {
            sConnection.Connect();
        }

        public int Insert(string username, string password, string name, string family, UserRole role)
        {
            var sql = string.Format("INSERT INTO tbl_users (username,password,name,family,role,created_at) VALUES('{0}','{1}','{2}','{3}',{4})", username, password, name, family, (int)role, Utils.DateToString());
            return sConnection.ExecuteNonQuery(sql);
        }

        public List<KeyValuePair<string, object>> Get(int id)
        {
            var sql = string.Format("SELECT * FROM tbl_users WHERE id={0}", id);
            return Get(sql);
        }

        public List<KeyValuePair<string, object>> Get(string username, string password, UserRole role)
        {
            var sql = string.Format("SELECT * FROM tbl_users WHERE username LIKE '{0}' AND password LIKE '{1}' AND role={2}", username, password, (int)role);
            return Get(sql);
        }

        public List<List<KeyValuePair<string, object>>> GetPaginate(int page = 1)
        {
            var sql = string.Format("SELECT * FROM tbl_users LIMIT {0},{1}", (page - 1) * Utils.PageItems, Utils.PageItems);
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

        private List<KeyValuePair<string, object>> Get(string sql)
        {
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

        private List<KeyValuePair<string, object>> GetRecord(MySqlDataReader reader)
        {
            var record = new List<KeyValuePair<string, object>>();
            record.Add(new KeyValuePair<string, object>("id", reader.GetInt32(0)));
            record.Add(new KeyValuePair<string, object>("username", reader.GetString(1)));
            record.Add(new KeyValuePair<string, object>("name", reader.GetString(3)));
            record.Add(new KeyValuePair<string, object>("family", reader.GetString(4)));
            record.Add(new KeyValuePair<string, object>("role", reader.GetByte(5)));
            record.Add(new KeyValuePair<string, object>("created_at", reader.GetString(6)));
            record.Add(new KeyValuePair<string, object>("updated_at", reader.GetString(7)));
            return record;
        }
    }
}