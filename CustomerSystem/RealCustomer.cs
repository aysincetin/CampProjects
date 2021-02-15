using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerSystem
{
    class RealCustomer: Customer   // inheritance-> real customer is a customer
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
