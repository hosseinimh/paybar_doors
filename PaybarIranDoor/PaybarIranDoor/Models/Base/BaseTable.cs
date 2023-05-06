using MySql.Data.MySqlClient;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;
using RECORDS = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>>;

namespace PaybarIranDoor.Models.Base
{
    public class BaseTable
    {
        private BaseConnection sConnection;

        public BaseTable()
        {
            sConnection.Connect();
        }

        protected RECORD Get(string sql)
        {
            using (MySqlDataReader reader = sConnection.ExecuteReader(sql))
            {
                if (reader.Read())
                {
                    return GetRecord(reader);
                }
            }
            return null;
        }

        protected RECORDS GetPaginate(string sql, int page = 1)
        {
            var records = new RECORDS();
            using (MySqlDataReader reader = sConnection.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    records.Add(GetRecord(reader));
                }
            }
            return records.Count > 0 ? records : null;
        }

        protected RECORD GetRecord(MySqlDataReader reader)
        {
            return new RECORD();
        }

        protected int ExecuteNonQuery(string sql)
        {
            return sConnection.ExecuteNonQuery(sql);
        }

        protected object ExecuteScalar(string sql)
        {
            return sConnection.ExecuteScalar(sql);
        }

        protected MySqlDataReader ExecuteReader(string sql)
        {
            return sConnection.ExecuteReader(sql);
        }
    }
}