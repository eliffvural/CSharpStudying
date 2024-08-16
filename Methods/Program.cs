using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello methods");

            string productName = "laptop";
            double price = 50000;
            string description = "laptoplaptoplaptop";

            //lets create a class like this;

            Product product1 = new Product();
            Product product2 = new Product();

            product1.ProductName = "apple";
            product1.Id = 1;
            product1.Description = "apple apple apple";
            product1.Price = 50;

            product2.ProductName = "orange";
            product2.Id = 2;
            product2.Description = "orange orange orange";
            product2.Price = 60;

            //lets create array;

            Product[] products = new Product[] { product1};

            //foreach 

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("---------------");

            }


        }
    }
}