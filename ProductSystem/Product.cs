using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSystem
{
    class Product //Entity
    {
        public int Id { get; set; } // SQL'deki Primary Key 
        public int CategoryId { get; set; } // SQL'deki Foreign Key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } 
        public int UnitInStock { get; set; }  // ürünün stok adedi

    }
}
