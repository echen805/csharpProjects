using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool orderDone = false;

            List<IMenu> FoodMenu = new List<IMenu>();
            List<Item> Inventory = new List<Item>();

            //Beef            
            Meat tritip = new Meat(1, "Tri tip 16 oz", 16.00, 10);
            Meat sirloin = new Meat(2, "Sirloin 16 oz", 22.00, 10);
            Meat ribeye = new Meat(3, "Ribeye 16 oz", 28.00, 10);
            Meat tBone = new Meat(4, "Ribeye 16 oz", 36.00, 10);

            //Lamb


            // Adding items to menu
            FoodMenu.Add(tritip);
            FoodMenu.Add(sirloin);
            FoodMenu.Add(ribeye);
            FoodMenu.Add(tBone);

            // Adding items to Inventory
            Inventory.Add(tritip);
            Inventory.Add(sirloin);
            Inventory.Add(ribeye);
            Inventory.Add(tBone);
            

            Console.WriteLine("Welcome to Ed's Restaurant, where you go big or go home!\n" + 
                "What would you like to order?\n");
            Console.WriteLine(PrintMenuHeader());



            foreach (Item stock in Inventory)
            {
                stock.printMenu();
                //Console.WriteLine($"{stock.printMenu()}");
            }


            //foreach (IMenu orders in FoodMenu)
            //{
            //    Console.WriteLine($"{orders}");
            //}

            List<Item> Receipt = new List<Item>();
            string input;
            List<string> inputList = new List<string>();
            string continueOrder;          
            //Item tempItem = new Item();

            while (orderDone != true)
            {
                Console.WriteLine("\nTo order: Please input the menu ID and quantity, separated by a comma.");
                input = Console.ReadLine();
                inputList = input.Split(',').ToList();

                for(int i = 0; i<inputList.Count;i+=2)
                {                                     
                    // Grabs the menu ID the user inputted
                    int menuID = (int.Parse(inputList[i]));

                    Item tempItem = new Item();
                    // Takes the menu ID and cross references with the inventory
                    tempItem = Inventory.Find(food => food.ItemID==menuID);
                    int amtOrdered = int.Parse(inputList[i + 1]);

                    tempItem.UpdateInventory(amtOrdered);
                    Item order = new Item(tempItem.ItemID, tempItem.Name, tempItem.Cost, amtOrdered);
                    Receipt.Add(order);                    
                }

                Console.WriteLine("Thank you for the order. Would you like to order more?" + 
                    "\nEnter 'Yes' to continue, 'Menu' to see the menu or press any key to see the receipt.");

                continueOrder = Console.ReadLine().ToLower();
                if (continueOrder.Equals("yes"))
                {
                    orderDone = false;
                }
                else if (continueOrder.Equals("menu"))
                {
                    Console.WriteLine(PrintMenuHeader());
                    foreach (Item left in Inventory)
                    {
                        left.printMenu();
                        //Console.WriteLine(left);
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Here is the receipt:\n");
            Console.WriteLine(PrintReceiptHeader());

            foreach (Item transaction in Receipt)
            {
                Console.WriteLine(transaction);
            }

            Console.WriteLine("\nThank you for visiting! I hope to see you again!\nPress any key to exit..");
            Console.ReadKey();
        }

        public static string PrintMenuHeader()
        {
            return $"{"ID", -10} {"Item",-7} {"Quantity",18} {"Cost",18}\n" +
                $"{"===",-10} { "====",-7} { "========",18} { "========",18}";
        }

        public static string PrintReceiptHeader()
        {
            return $"{"Item",-7} {"Quantity",25} {"Total",18}\n" +
                $"{ "====",-7} { "========",25} {"=====",18}";
        }
    }
}
