using ProjectDal;
using System.Data;

namespace ProjectSQLLayer
{
    public class QuantityUnitSQL : BaseSQL
    {
        public DataTable GetQuantityPerUnitSQL()
        {
            string query = @"exec getAllQPU";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);

            return table;
        }

        public DataTable GetQuantityOfUnitSQL()
        {
            string query = @"exec getQPU";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);

            return table;
        }
    }
}