using System;

namespace ClassIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            //string name = "Ayşin";
            //int age = 24;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.CourseInstructor = "Teacher1";
            course1.ViewRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.CourseInstructor = "Teacher2";
            course2.ViewRate = 70;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.CourseInstructor = "Teacher3";
            course3.ViewRate = 80;

            //Console.WriteLine(Course1.CourseAdi + " " + Course1.CourseEgitmeni + " " + Course1.IzlenmeOrani);
            //Console.WriteLine(Course2.CourseAdi + " " + Course2.CourseEgitmeni + " " + Course2.IzlenmeOrani);
            //Console.WriteLine(Course3.CourseAdi + " " + Course3.CourseEgitmeni + " " + Course3.IzlenmeOrani);

            Course[] courses = new Course[] { course1, course2, course3 };
            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string CourseInstructor { get; set; }
        public int ViewRate { get; set; }
    }
}

