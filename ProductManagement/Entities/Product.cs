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
        public string Ean8 { get; set; }
        public string Ean13 { get; set; }
        public DateTime SavedDateTime { get; set; }
        public string ProductName { get; set; }

    }
}
