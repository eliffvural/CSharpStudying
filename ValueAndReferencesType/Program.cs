using System;

namespace ValueAndReferencesType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello types");

            int number1 = 19;
            int number2 = 21;
            number1 = number2;
            number2 = 65;


            int[] numbers= new int[] {19, 21, 03};
            int[] numbers2 = new int[] { 190, 210, 300 };


        }

    }

}