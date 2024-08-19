using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {

        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added.");
        }


        public void Update(Product product) {

            Console.WriteLine(product.ProductName + " updated.");

        }

        public int topla(int sayi1, int sayi2)
        {
            return sayi1+ sayi2;
        }



        /*public void BiseyYap(int sayi)
        {
            sayi = 99;
        }*/

    }
}
