using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    class StockOut : StockIn
    {
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public string ItemName { get; set; }
        public int OutQuantity { get; set; }
        public SqlDateTime Date { get; set; }
    }
}
