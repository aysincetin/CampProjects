using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerSystem
{
     // business class
    class CustomerManager
    {
        public void Add(Customer customer) //Polymorphism
        {
            Console.WriteLine("Customer added");
        }
    }
}
