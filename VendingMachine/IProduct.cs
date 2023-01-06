using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public interface  IProduct
    {
          string ProductName { get; set; }
          decimal Price { get; set; }
          void Purchase(decimal customerWallet, decimal productPrice, ProductItem product);
          void Use(string ProductName);


    }
}
