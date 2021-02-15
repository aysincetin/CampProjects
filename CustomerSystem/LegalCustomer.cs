using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerSystem
{
    
    class LegalCustomer : Customer    //  inheritance-> legal customer ia a customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
