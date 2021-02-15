using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSystem
{
    class AutoCreditManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Auto Loan Payment Plan Has Been Calculated");
        }
        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
