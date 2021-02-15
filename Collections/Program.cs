using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Ayşin", "Ayşe", "Fatma" ,"Merve"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //names[4] = "Zeynep";
            //Console.WriteLine(names2[4]);  // output Zeynep
            //Console.WriteLine(names2[0]);  


            // üsttekileri koleksiyon seklinde yazmak daha kullanısşlı
            List<string> names2 = new List<string> { "Ayşin", "Ayşe", "Merve", "Ece" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            //yeni eleman ekleme
            names2.Add("Zeynep");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}
