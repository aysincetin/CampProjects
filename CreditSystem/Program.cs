using System;
using System.Collections.Generic;

namespace CreditSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            // interface can keep the reference of the class that implemented it
            // an interface can't take "new" keyword

            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager autoCreditManager = new AutoCreditManager();
            ICreditManager mortgageCrediManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            

            ApplicationManager basvuruManager = new ApplicationManager();
            basvuruManager.DoApplication(personalCreditManager, new DatabaseLoggerService());

            Console.WriteLine("______________________\n");

            basvuruManager.DoApplication(autoCreditManager, new FileLoggerService());
            List<ICreditManager> credits = new List<ICreditManager>() { personalCreditManager, autoCreditManager };
            // ApplicationManager.CreditPreInformation(credits);
        }
    }
}
