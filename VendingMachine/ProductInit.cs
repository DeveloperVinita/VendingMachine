using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class ProductInit
    {   
        public static Product Cola = new Product
        {
            ProductName = "COLA",
            Price = 1         
        };
        public static Product Chips = new Product
        {
            ProductName = "CHIPS",
            Price = 0.50m
          
        };
        public static Product Candy = new Product
        {
            ProductName = "CANDY",
            Price = 0.65m
        
        };
    }
}

