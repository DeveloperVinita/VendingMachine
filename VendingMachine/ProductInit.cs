using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class ProductInit
    {
        public static ProductItem Init = new ProductItem
        {
            ProductName = "",
            Price = 0           
        };


        public static Snacks Cola = new Snacks
        {
            ProductName = "COLA",
            Price = 1
            
        };

        public static Snacks Chips = new Snacks
        {
            ProductName = "CHIPS",
            Price = 0.50m
          
        };
        public static Snacks Candy = new Snacks
        {
            ProductName = "CANDY",
            Price = 0.65m
        
        };

        List<ProductItem> inventory = new List<ProductItem>
        {
              Cola,
              Chips,
               Candy
        };


    }


}

