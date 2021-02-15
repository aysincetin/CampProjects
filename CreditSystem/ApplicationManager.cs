 using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSystem
{
    class ApplicationManager
    {
        // method injection
        public void DoApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void CreditPreInformation(List<ICreditManager> credits) // credit list
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
