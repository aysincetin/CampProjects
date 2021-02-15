using System;

namespace Methods
{
    //DRY = don't repeat yourself
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();  //instance
            product1.Name = "Keyboard";
            product1.Price = 100;
            product1.Info = "Laptop keyboard";

            Product product2 = new Product();
            product2.Name = "Mouse";
            product2.Price = 80;
            product2.Info = "USB mouse";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Info);
                Console.WriteLine("___________________");
            }

            Console.WriteLine("__________Methods_____________");

            //reusibility 
            //encapsulation 

            BasketManager basketManager = new BasketManager(); // instance olusturuldu
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2("Screen","15.6 inch screen",700,5);
            basketManager.Add2("Flash Memory", "64 GB flash memory", 70,6);
            
            
        }
    }
}
