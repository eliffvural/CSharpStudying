﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("hello oop1!");

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock=3;


        }
    }

}