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
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id=2, CategoryId=2, ProductName="television", UnitPrice=60000, UnitsInStock=4};

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);

            /*int sayi = 100;
            productManager.BiseyYap(sayi);

            Console.WriteLine(sayi);*/

            //int, double, bool ... deger tip
            //diziler, class, abstract class, interface ... referans tip


        }
    }

}