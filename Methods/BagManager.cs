﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BagManager
    {

        public void Add(Product product) //parantez varsa method çalisiyor demektir.
        {
            Console.WriteLine("congrulations!! added to bag: "+ product.ProductName);
        }


        public void Add2(string productName, string description, double price, int stock) 
        {
            Console.WriteLine("Congrulations!! Added to bag: " + productName+ description+price+stock);
        
        }


    }
}
