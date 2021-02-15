using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSystem
{
    class MortgageCreditManager:ICreditManager 
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Loan Payment Plan Has Been Calculated");
        }
        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
