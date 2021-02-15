using System;

namespace CreditSystem
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}
