using System;
using System.Globalization;

namespace CSharpStudying
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello loops");

            string course1 = "course1";
            string course2 = "course2";
            string course3 = "course3";

            Console.WriteLine(course1);
            Console.WriteLine(course2); 
            Console.WriteLine( course3);

            string[] courses= new String[] { "course1", "course2", "course3", "extra course" };
            Console.WriteLine(courses[3]);

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine(courses[i]);
            }

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("FOOTER");

        }

    }

}
