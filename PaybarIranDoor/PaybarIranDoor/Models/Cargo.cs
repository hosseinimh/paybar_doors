using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PaybarIranDoor.Modules;

namespace PaybarIranDoor.Models
{
    public class Cargo
    {
        private MySqlConnection sConnection;

        public Cargo()
        {
            sConnection.Connect();
        }

        public int Insert(byte type, string name, string family, string nationalNo, string phone, string plaque, string cargo)
        {
            var sql = string.Format("INSERT INTO tbl_cargos (type,name,family,national_no,phone,plaque,cargo,created_at) VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", type, name, family, nationalNo, phone, plaque, cargo, Utils.DateToString());
            return sConnection.ExecuteNonQuery(sql);
        }

        public int Update(int id, byte type, string name, string family, string nationalNo, string phone, string plaque, string cargo)
        {
            var sql = string.Format("UPDATE tbl_cargos SET type={0},name='{1}',family='{2}',national_no='{3}',phone='{4}',plaque='{5}',cargo='{6}',updated_at='{7}'", type, name, family, nationalNo, phone, plaque, cargo, Utils.DateToString());
            return sConnection.ExecuteNonQuery(sql);
        }

        public List<KeyValuePair<string, object>> Get(int id)
        {
            var sql = string.Format("SELECT * FROM tbl_cargos WHERE id={0}", id);
            return Get(sql);
        }

        public List<List<KeyValuePair<string, object>>> GetPaginate(int page = 1)
        {
            var sql = string.Format("SELECT * FROM tbl_cargos LIMIT {0},{1}", (page - 1) * Utils.PageItems, Utils.PageItems);
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
            record.Add(new KeyValuePair<string, object>("name", reader.GetString(1)));
            record.Add(new KeyValuePair<string, object>("family", reader.GetString(2)));
            record.Add(new KeyValuePair<string, object>("national_no", reader.GetString(3)));
            record.Add(new KeyValuePair<string, object>("phone", reader.GetString(4)));
            record.Add(new KeyValuePair<string, object>("plaue", reader.GetString(5)));
            record.Add(new KeyValuePair<string, object>("cargo", reader.GetString(6)));
            record.Add(new KeyValuePair<string, object>("type", reader.GetByte(7)));
            record.Add(new KeyValuePair<string, object>("created_at", reader.GetString(8)));
            record.Add(new KeyValuePair<string, object>("updated_at", reader.GetString(9)));
            return record;
        }
    }
}