using ObjectOrientedProgram.InventoryManagement;
using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        const string INVENTORY_JSON = @"D:\BridgeLabz Problems Git Hub Local Repository\OOPsJson\ObjectOrientedProgram\InventoryManagement\inventory.json";
        static void Main(string[] args)
        {
            InventoryMain main = new InventoryMain();
            main.ReadJsonFile(INVENTORY_JSON);
        }
    }
}
