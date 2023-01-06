using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{ 
  public  class VendingMachines  
    {
        public static decimal CustomerWallet { get; set; }

        public static List<Product> shoppingCart = new List<Product>();
        public static bool insert { get; private set; }
        

        public static void MenuChoices()
        {
            Console.Clear();
            insert = true;
            while (insert)
            {
                Menu.ShowMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your wallet contains: {0}", CustomerWallet);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("--------------------------------------------");
                Console.Write("Make your choice (1-5, ENTER to leave): ");

                string inputText = Console.ReadLine();
                insert = int.TryParse(inputText, out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        CustomerWallet = CustomerInput();
                        break;                   
                    case 2:
                        CheckValidPurchase(ProductInit.Cola);
                        break;
                    case 3:
                        CheckValidPurchase(ProductInit.Chips);
                        break;
                    case 4:                     
                       CheckValidPurchase(ProductInit.Candy);                     
                        break;                   
                    default:
                        insert = false;
                        break;
                }
            }
        }


     public static decimal CustomerInput()
        {
            Console.Clear();
            Console.WriteLine("Insert Coins\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You can only insert coins in  Nickels=0.05 , Dimes=0.1  and Quarter=0.25\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            decimal[] moneyArray = new decimal[] { 0.05m, 0.1m, 0.25m };

            bool insert = true;
            while (insert)
            {
                Console.WriteLine("Insert Coins (ENTER to stop)");
                string inputText = Console.ReadLine();                

                insert = decimal.TryParse(inputText, out decimal inputMoney);
                if (insert == true)
                {
                decimal first = Array.Find(moneyArray, p => p.Equals(inputMoney));
                    if (first == inputMoney)
                    {
                        CustomerWallet += inputMoney;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You wallet contains {0}", CustomerWallet);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This is not a valid coin!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                else
                {
                    Console.WriteLine("Returns to menu!");
                }                              
            }
            return CustomerWallet;
        }

       public static void CheckValidPurchase(Product productChoice)
        {

            if (CustomerWallet < productChoice.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPrice is {0} and you have {1} in your wallet.Please insert coins.\n", productChoice.Price, CustomerWallet);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                shoppingCart.Add(productChoice);              
                Console.WriteLine("You added a {0} ,Please collect the product", productChoice.ProductName);
                CustomerWallet -= productChoice.Price;
                FinishPurchase();
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static bool FinishPurchase()
        {
            foreach (var item in shoppingCart)
            {                   
                if (item is Product)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("THANK YOU for the purchasing, {0} !", item.ProductName);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.WriteLine("Here's your change! {0}", CustomerWallet);

            return insert = false;
        }

    }

}

