using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string BoxNumber { get; set; }
        public string StockKeepingUnit { get; set; }
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public DateTime SavedDateTime { get; set; }

    }
}
