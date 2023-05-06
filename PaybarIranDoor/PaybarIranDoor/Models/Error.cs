using MySql.Data.MySqlClient;
using PaybarIranDoor.Modules;
using PaybarIranDoor.Models.Base;
using FIELD = System.Collections.Generic.KeyValuePair<string, object>;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;
using RECORDS = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>>;

namespace PaybarIranDoor.Models
{
    public class Error : BaseTable
    {
        public int Insert(string className, string function, string message)
        {
            var sql = string.Format("INSERT INTO tbl_errors (class,function,message,created_at) VALUES('{0}','{1}','{2}','{3}')", className, function, message, Utils.DateToString());
            return ExecuteNonQuery(sql);
        }

        public int DeleteAll()
        {
            var sql = "DELETE FROM tbl_errors";
            return ExecuteNonQuery(sql);
        }

        public RECORD Get(int id)
        {
            var sql = string.Format("SELECT * FROM tbl_errors WHERE id={0}", id);
            return Get(sql);
        }

        public RECORDS GetPaginate(int page = 1)
        {
            var sql = string.Format("SELECT * FROM tbl_errors LIMIT {0},{1}", (page - 1) * Utils.PageItems, Utils.PageItems);
            return GetPaginate(sql, page);
        }

        private new RECORD GetRecord(MySqlDataReader reader)
        {
            var record = new RECORD();
            record.Add(new FIELD("id", reader.GetInt32(0)));
            record.Add(new FIELD("class", reader.GetString(1)));
            record.Add(new FIELD("function", reader.GetString(2)));
            record.Add(new FIELD("message", reader.GetString(3)));
            record.Add(new FIELD("created_at", reader.GetString(4)));
            record.Add(new FIELD("updated_at", reader.GetString(5)));
            return record;
        }
    }
}