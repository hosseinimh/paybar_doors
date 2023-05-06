using MySql.Data.MySqlClient;
using PaybarIranDoor.Modules;
using PaybarIranDoor.Models.Base;
using FIELD = System.Collections.Generic.KeyValuePair<string, object>;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;
using RECORDS = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>>;

namespace PaybarIranDoor.Models
{
    public class Cargo : BaseTable
    {
        public int Insert(byte type, string name, string family, string nationalNo, string phone, string plaque, string cargo)
        {
            var sql = string.Format("INSERT INTO tbl_cargos (type,name,family,national_no,phone,plaque,cargo,created_at) VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", type, name, family, nationalNo, phone, plaque, cargo, Utils.DateToString());
            return ExecuteNonQuery(sql);
        }

        public int Update(int id, byte type, string name, string family, string nationalNo, string phone, string plaque, string cargo)
        {
            var sql = string.Format("UPDATE tbl_cargos SET type={0},name='{1}',family='{2}',national_no='{3}',phone='{4}',plaque='{5}',cargo='{6}',updated_at='{7}'", type, name, family, nationalNo, phone, plaque, cargo, Utils.DateToString());
            return ExecuteNonQuery(sql);
        }

        public RECORD Get(int id)
        {
            var sql = string.Format("SELECT * FROM tbl_cargos WHERE id={0}", id);
            return Get(sql);
        }

        public RECORDS GetPaginate(int page = 1)
        {
            var sql = string.Format("SELECT * FROM tbl_cargos LIMIT {0},{1}", (page - 1) * Utils.PageItems, Utils.PageItems);
            return GetPaginate(sql, page);
        }

        private new RECORD GetRecord(MySqlDataReader reader)
        {
            var record = new RECORD();
            record.Add(new FIELD("id", reader.GetInt32(0)));
            record.Add(new FIELD("name", reader.GetString(1)));
            record.Add(new FIELD("family", reader.GetString(2)));
            record.Add(new FIELD("national_no", reader.GetString(3)));
            record.Add(new FIELD("phone", reader.GetString(4)));
            record.Add(new FIELD("plaue", reader.GetString(5)));
            record.Add(new FIELD("cargo", reader.GetString(6)));
            record.Add(new FIELD("type", reader.GetByte(7)));
            record.Add(new FIELD("created_at", reader.GetString(8)));
            record.Add(new FIELD("updated_at", reader.GetString(9)));
            return record;
        }
    }
}