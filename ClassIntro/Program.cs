using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "emre";
            int yas = 22;

            Course course1= new Course();
            course1.CourseName = "C#";
            course1.Teacher = "Emre Taş";
            course1.Watching = 658000;

            Course course2 = new Course();
            course2.CourseName = "java";
            course2.Teacher = "Elif Taş";
            course2.Watching = 802300;

            Course course3 = new Course();
            course3.CourseName = "cpp";
            course3.Teacher = "Hijjj Taş";
            course3.Watching = 236500;

            Console.WriteLine(course1.CourseName+ "eğitimi: " + course1.Teacher );

            Console.WriteLine("hello class");

        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public int Watching { get; set; }
       

    }

}