using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class ProductItem : IProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }


        public void Purchase(decimal customerWallet, decimal productPrice, ProductItem product )
        {
            decimal CustomerWallet = customerWallet;
            decimal ProductPrice = productPrice;
            CustomerWallet -= ProductPrice;
            ProductItem Product = product;

            Console.WriteLine("{0} added to cart.", ProductName);
            Console.WriteLine("You have {0} $ left in your wallet.", CustomerWallet);
        }

        public void Use(string ProductName)
        {
            Console.WriteLine("Nothing'!");
        }
    }
    public class Snacks : ProductItem
    {
        public static new void Use(string ProductName )
        {
            Console.WriteLine("THANK YOU for the purchasing, {0} !", ProductName);
        }
    }

}
