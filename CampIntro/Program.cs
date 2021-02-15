using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string categoryTag = "Category";
            //int studentNumber = 32000;
            //double bankRate = 1.45;
            bool IfEntry = false;
            double dollarYesterday = 7.35;
            double dollarToday = 7.45;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Decrease button");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("Increase button");
            }
            else
            {
                Console.WriteLine("Not changed button");
            }

            if(IfEntry == true)
            {
                Console.WriteLine("Settings button");
            }
            else
            {
                Console.WriteLine("Enter button");
            }
            
            Console.WriteLine(categoryTag);
        }
    }
}
