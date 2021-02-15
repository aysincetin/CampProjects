using System;

namespace CustomerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "123";
            customer1.Name = "Ayşin";
            customer1.LastName = "Çetin";
            customer1.IdentityNumber = "123456789";

            LegalCustomer customer2 = new LegalCustomer();
            customer1.Id = 2;
            customer2.CustomerNumber = "12345";
            customer2.CompanyName= "Company of Best";
            customer2.TaxNumber = "789456";

            Customer musteri3 = new RealCustomer();  
            Customer customer4 = new LegalCustomer();
                 
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("Customer info: " + customer1.Name +" " +customer1.LastName);
            customerManager.Add(customer1);
            Console.WriteLine("_______________");
            Console.WriteLine("Customer info: " + customer2.CompanyName + " " + customer2.TaxNumber);
            customerManager.Add(customer2);

        }
    }
}
