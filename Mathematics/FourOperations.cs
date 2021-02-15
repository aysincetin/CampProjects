using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematics
{
    class FourOperations
    {
        public void Add(int number1, int number2)
        {
            int total = number1 + number2;
            Console.WriteLine("Addition =" + " " + total);
        }
        public void Subtract(int number1, int number2)
        {
            int result = number2 - number1;
            Console.WriteLine("Subtion =" + " " + result);

        }
        public void Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Multiplication =" + " " + result);

        }
        public void Division(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine("Division =" + " " + result);

        }
    }
}
