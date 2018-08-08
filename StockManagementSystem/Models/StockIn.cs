using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    class StockIn
    {
        public int CompanyId { get; set; }
        public int CategoryId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }          
    }
}
