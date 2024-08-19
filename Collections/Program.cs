using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello collections");


            /*string[] nouns = new string[] { "emre", "elif", "hijjj" };
            Console.WriteLine(nouns[0]);
            Console.WriteLine(nouns[1]);
            Console.WriteLine(nouns[2]);
            //Console.WriteLine(nouns[3]);
            //Console.WriteLine(nouns[4]);

            //new ile birlikte yeni referans adresi tanimladik ve eski elemanlari kaybetmis oluruz
            nouns = new string[5];
            nouns[4] = "minikk hijjj";
            Console.WriteLine(nouns[4]);
            Console.WriteLine(nouns[0]);*/

            List<string> nouns2 = new List<string> { "emre", "elif", "hijjj"};
            Console.WriteLine(nouns2[0]);
            Console.WriteLine(nouns2[1]);
            Console.WriteLine(nouns2[2]);
            Console.WriteLine(nouns2[3]);



        }
    }

}