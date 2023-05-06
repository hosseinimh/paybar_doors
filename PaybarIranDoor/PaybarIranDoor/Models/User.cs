using MySql.Data.MySqlClient;
using PaybarIranDoor.Modules;
using PaybarIranDoor.Models.Base;
using FIELD = System.Collections.Generic.KeyValuePair<string, object>;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;
using RECORDS = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>>;

namespace PaybarIranDoor.Models
{
    public class User : BaseTable
    {
        public int Insert(string username, string password, string name, string family, byte role)
        {
            var sql = string.Format("INSERT INTO tbl_users (username,password,name,family,role,created_at) VALUES('{0}','{1}','{2}','{3}',{4})", username, password, name, family, role, Utils.DateToString());
            return ExecuteNonQuery(sql);
        }

        public int Update(int id, string name, string family, byte role)
        {
            var sql = string.Format("UPDATE tbl_users SET name='{1}',family='{2}',role={3},updated_at='{4}' WHERE id={0}", id, name, family, (byte)role, Utils.DateToString());
            return ExecuteNonQuery(sql);
        }

        public RECORD Get(int id)
        {
            var sql = string.Format("SELECT * FROM tbl_users WHERE id={0}", id);
            return Get(sql);
        }

        public RECORD Get(string username, string password, byte role)
        {
            var sql = string.Format("SELECT * FROM tbl_users WHERE username LIKE '{0}' AND password LIKE '{1}' AND role={2}", username, password, role);
            return Get(sql);
        }

        public RECORDS GetPaginate(int page = 1)
        {
            var sql = string.Format("SELECT * FROM tbl_users LIMIT {0},{1}", (page - 1) * Utils.PageItems, Utils.PageItems);
            return GetPaginate(sql, page);
        }

        private new RECORD GetRecord(MySqlDataReader reader)
        {
            var record = new RECORD();
            record.Add(new FIELD("id", reader.GetInt32(0)));
            record.Add(new FIELD("username", reader.GetString(1)));
            record.Add(new FIELD("name", reader.GetString(3)));
            record.Add(new FIELD("family", reader.GetString(4)));
            record.Add(new FIELD("role", reader.GetByte(5)));
            record.Add(new FIELD("created_at", reader.GetString(6)));
            record.Add(new FIELD("updated_at", reader.GetString(7)));
            return record;
        }
    }
}