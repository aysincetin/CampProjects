using System;

namespace ProductSystem
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            // another way to set an instance
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Pencil", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();  
            productManager.Add(product1);
            productManager.Update(product1);
            Console.WriteLine("_____________");
            productManager.Add(product2);
            productManager.Update(product2);
        }
    }
}
