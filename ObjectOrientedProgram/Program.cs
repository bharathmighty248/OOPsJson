using ObjectOrientedProgram.InventoryManagement;
using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        const string INVENTORY_JSON =@"C:\Users\USER\source\repos\ObjectOrientedProgram\InventoryManagement\inventory.json";
        static void Main(string[] args)
        {
            InventoryMain main = new InventoryMain();
            main.DisplayData(INVENTORY_JSON);
        }
    }
}
