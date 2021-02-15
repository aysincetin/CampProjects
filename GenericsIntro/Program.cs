using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Zehra");
            Console.WriteLine(names.Length);
            names.Add("Ayşe");
            Console.WriteLine(names.Length);
        }
    }
}
