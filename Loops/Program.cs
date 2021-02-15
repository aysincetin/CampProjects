using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] courses = new string[] { "Software Developer Training Camp", "Introduction to Programming Course", "Java Course"};

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("---------------------------------------------------------");
            foreach (string course in courses) //to return array-based structures
            {
                Console.WriteLine(course);
            }

            
        }
    }
}
