using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    class Item
    {
        public int Category { get; set; }
        public int Company { get; set; }
        public string Name { get; set; }
        public int ReorderLevel { get; set; }   
        
    }
}
