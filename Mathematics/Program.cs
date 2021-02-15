using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();
            fourOperations.Add(3,4);
            fourOperations.Subtract(5, 7);
            fourOperations.Multiplication(8, 9);
            fourOperations.Division(10,2);
        }
    }
}
