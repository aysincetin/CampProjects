using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to basket" +" " + product.Name);
            
        }
        public void Add2(string productName, string info, double price,int quantity)
        {
            Console.WriteLine("Added - "+ " " + productName);
        }
    }
}
