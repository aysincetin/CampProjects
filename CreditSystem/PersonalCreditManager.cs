using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSystem
{
    class PersonalCreditManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer Loan Payment Plan Has Been Calculated");
        }
        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
