using ProjectModel;
using ProjectSQLLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities
{
    public class QuantityUnitEntities : BaseEntities
    {
        public QuantityUnitSQL quantityUnitSQL { get; set; }
        public QuantityUnitEntities()
        {
            quantityUnitSQL= new QuantityUnitSQL();
        }
        public List<QuantityPerUnit> GetQuantityPerUnitE()
        {
            return DataTableToList<QuantityPerUnit>(quantityUnitSQL.GetQuantityPerUnitSQL());
        }

        public List<QuantityPerUnit> GetQuantityOfUnitE()
        {
            return DataTableToList<QuantityPerUnit>(quantityUnitSQL.GetQuantityOfUnitSQL());
        }
    }
}
