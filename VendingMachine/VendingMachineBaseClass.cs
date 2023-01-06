using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class VendingMachineBaseClass
    {
        public static decimal CustomerWallet { get; set; }

        public static ProductItem ProductChoice = ProductInit.Init;

        public  static List<ProductItem> shoppingCart = new List<ProductItem>();
    }

}

