using System;
using System.Collections.Generic;
using System.Text;
namespace VendingMachine
{
    class Menu
    {
        public int CustomerWallet { get; set; }
        public static void ShowMenu()
        {
            Console.WriteLine("** Please Insert coins & select Product of your choice , collect the product and remaining coins if any **");
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**  Welcome to the Vending Machine 2023 ! **");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Press 1. Insert Coins");                    
            Console.WriteLine("================================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tProducts\tPrice");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("================================================");
            Console.WriteLine("Press 2. Cola\t\t$1.0");
            Console.WriteLine("Press 3. Chips\t\t$0.50");
            Console.WriteLine("Press 4. Candy\t\t$0.65");
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ENTER to Exit");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--------------------------------------------");
        }
    }
}
