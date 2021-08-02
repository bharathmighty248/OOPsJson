using ObjectOrientedProgram.InventoryManagement;
using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        const string INVENTORY_JSON = @"D:\BridgeLabz Problems Git Hub Local Repository\OOPsJson\ObjectOrientedProgram\InventoryManagement\inventory.json";
        static void Main(string[] args)
        {
            string choice="start";
            InventoryMain main = new InventoryMain();
            Console.WriteLine("\nWelCome To Json Inventory Management\nSelect one Option below..\n1. Add\n2.Edit\n3. Delete\n4. Display\n5. Stop");
            while (choice != "5")
            {
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "1":
                        main.Additems(INVENTORY_JSON);
                        break;

                    case "2":
                        main.Edit(INVENTORY_JSON);
                        break;

                    case "3":
                        main.Deleteitems(INVENTORY_JSON);
                        break;

                    case "4":
                        main.DisplayData(INVENTORY_JSON);
                        break;

                }
            }
        }
    }
}
