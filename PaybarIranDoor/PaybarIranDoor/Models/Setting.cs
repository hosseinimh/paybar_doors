using MySql.Data.MySqlClient;
using PaybarIranDoor.Modules;
using PaybarIranDoor.Models.Base;
using FIELD = System.Collections.Generic.KeyValuePair<string, object>;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;

namespace PaybarIranDoor.Models
{
    public class Setting : BaseTable
    {
        public Setting() : base()
        {
            if (Count() == 0)
            {
                Insert();
            }
        }

        public RECORD Get()
        {
            var sql = "SELECT * FROM tbl_settings WHERE id=1";
            return Get(sql);
        }

        public int Update(int transitEntrance, int transitScan, int transhipmentEntrance, int transhipmentScan, int transhipmentTonage)
        {
            var sql = string.Format("UPDATE tbl_settings SET transit_entrance={0},transit_scan={1},transhipment_entrance={2},transhipment_scan={3},transhipment_tonage={4},updated_at={5} WHERE id=1", transitEntrance, transitScan, transhipmentEntrance, transhipmentScan, transhipmentTonage, Utils.DateToString());
            return ExecuteNonQuery(sql);
        }

        private int Insert()
        {
            var sql = string.Format("INSERT INTO tbl_settings (id,transit_entrance,transit_scan,transhipment_entrance,transhipment_scan,transhipment_tonage,created_at) VALUES(1,{0},{1},{2},{3},{4},'{5}')", 0, 0, 0, 0, 0, Utils.DateToString());
            return ExecuteNonQuery(sql);
        }

        private int Count()
        {
            var sql = "SELECT COUNT(*) FROM tbl_settings";
            return (int)ExecuteScalar(sql);
        }

        private new RECORD GetRecord(MySqlDataReader reader)
        {
            var record = new RECORD();
            record.Add(new FIELD("id", reader.GetInt32(0)));
            record.Add(new FIELD("transit_entrance", reader.GetInt32(1)));
            record.Add(new FIELD("transit_scan", reader.GetInt32(2)));
            record.Add(new FIELD("transhipment_entrance", reader.GetInt32(3)));
            record.Add(new FIELD("transhipment_scan", reader.GetInt32(4)));
            record.Add(new FIELD("transhipment_tonage", reader.GetInt32(5)));
            record.Add(new FIELD("created_at", reader.GetString(6)));
            record.Add(new FIELD("updated_at", reader.GetString(7)));
            return record;
        }
    }
}