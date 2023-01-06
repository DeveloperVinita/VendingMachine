using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{ 
  public  class VendingMachines : VendingMachineBaseClass 
    {
        public static bool insert { get; private set; }
        
        public void VendingMachineSetup()
        {
        }

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
                        CustomerWallet = VendingMachines.CustomerInput();
                        break;                   
                    case 2:
                        ProductChoice = ProductInit.Cola;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 3:
                        ProductChoice = ProductInit.Chips;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 4:
                        ProductChoice = ProductInit.Candy;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 5:                     
                        FinishPurchase();
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

                if (string.IsNullOrWhiteSpace(inputText))
                {
                    if (CustomerWallet > 0)
                    {

                    }
                    insert = false; 
                }

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

       public static void CheckValidPurchase(ProductItem productChoice)
        {
            ProductItem ProductChoice = productChoice;

            if (CustomerWallet < productChoice.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPrice is {0} and you have {1} in your wallet.Please insert coins.\n", ProductChoice.Price, CustomerWallet);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                shoppingCart.Add(ProductChoice);
                var shoppingItem = shoppingCart.Last().ProductName;
                Console.WriteLine("You added a {0} ,Please finish your purchase & collect the product", shoppingItem);
                CustomerWallet -=ProductChoice.Price;
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static bool FinishPurchase()
        {
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"Cart item: {item.ProductName}\tPrice: {item.Price}\n");          
                if (item is Snacks)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Snacks.Use(item.ProductName);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.WriteLine("Here's your change! {0}", CustomerWallet);

            return insert = false;
        }

    }

}

