using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgram.InventoryManagement
{
    public class InventoryMain
    {
        public void DisplayData(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string jsonData = File.ReadAllText(filepath);
                    InventoryModel jsonObjectArray = JsonConvert.DeserializeObject<InventoryModel>(jsonData);
                    Console.WriteLine("Type" + "\t" + "Name" + "\t" + "Weight" + "\t" + "Rate" + "\t" + "Amount");
                    List<Rice> rice = jsonObjectArray.RiceList;
                    foreach (var item in rice)
                    {
                        Console.WriteLine("Rice" + "\t" + "{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg);
                    }
                    List<Wheat> wheat = jsonObjectArray.WheatList;
                    foreach (var item in wheat)
                    {
                        Console.WriteLine("Wheat" + "\t" + "{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg);
                    }
                    List<Pulses> pulses = jsonObjectArray.PulsesList;
                    foreach (var item in pulses)
                    {
                        Console.WriteLine("Pulses" + "\t" + "{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg + "\n");
                    }

                }
                else
                {
                    Console.WriteLine("\nSpecified file path does not exist");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
        public void Edit(String filepath)
        {
            string jsonData = File.ReadAllText(filepath);
            InventoryModel jsonObjectArray = JsonConvert.DeserializeObject<InventoryModel>(jsonData);
            String Type = "";
            String Check = "";
            Console.WriteLine("Enter a List name(Rice,Wheat or Pulses) to edit :");
            Check = Console.ReadLine().ToLower();
            switch (Check)
            {
                case "rice":
                    Console.WriteLine("Enter rice type to edit:");
                    Type = Console.ReadLine().ToLower();
                    List<Rice> rice = jsonObjectArray.RiceList;
                    foreach (var item in rice)
                    {
                        if (item.Name.ToLower() == Type)
                        {
                            Console.WriteLine("Enter new rice Weight :");
                            item.Weight = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new rice PricePerKg :");
                            item.PricePerKg = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Name doesnt Exist!");
                        }

                    }
                    InventoryMain.WriteToFile(jsonObjectArray);
                    Console.WriteLine("DATA EDITED!");
                    break;

                case "wheat":
                    Console.WriteLine("Enter wheat type to edit:");
                    Type = Console.ReadLine().ToLower();
                    List<Wheat> wheat = jsonObjectArray.WheatList;
                    foreach (var item in wheat)
                    {
                        if (item.Name.ToLower() == Type)
                        {
                            Console.WriteLine("Enter new wheat Weight :");
                            item.Weight = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new wheat PricePerKg :");
                            item.PricePerKg = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Name doesnt Exist!");
                        }
                    }
                    InventoryMain.WriteToFile(jsonObjectArray);
                    Console.WriteLine("DATA EDITED!");
                    break;

                case "pulses":
                    Console.WriteLine("Enter rice type to edit:");
                    Type = Console.ReadLine().ToLower();
                    List<Pulses> pulses = jsonObjectArray.PulsesList;
                    foreach (var item in pulses)
                    {
                        if (item.Name.ToLower() == Type)
                        {
                            Console.WriteLine("Enter new pulses Weight :");
                            item.Weight = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new pulses PricePerKg :");
                            item.PricePerKg = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Name doesnt Exist!");
                        }
                    }
                    InventoryMain.WriteToFile(jsonObjectArray);
                    Console.WriteLine("DATA EDITED!");
                    break;

                default:
                    Console.WriteLine("Name doesnt exist!");
                    break;
            }
        }
        public static void WriteToFile(InventoryModel inventory)
        {
            string jsonConvrsion = JsonConvert.SerializeObject(inventory);
            System.IO.File.WriteAllText(@"D:\BridgeLabz Problems Git Hub Local Repository\OOPsJson\ObjectOrientedProgram\InventoryManagement\inventory.json", jsonConvrsion);
        }
        public void Deleteitems(String filepath)
        {
            string jsonData = File.ReadAllText(filepath);
            InventoryModel jsonObjectArray = JsonConvert.DeserializeObject<InventoryModel>(jsonData);
            String Type = "";
            int counter = 0;
            String Check = "";
            Console.WriteLine("Enter a List name(Rice,Wheat or Pulses) to edit :");
            Check = Console.ReadLine().ToLower();
            switch (Check)
            {
                case "rice":
                    Console.WriteLine("Enter rice type to delete:");
                    Type = Console.ReadLine().ToLower();
                    List<Rice> rice = jsonObjectArray.RiceList;
                    foreach (var item in rice.ToArray())
                    {
                        counter++;
                        if (item.Name.ToLower() == Type)
                        {
                            rice.Remove(item);
                        }
                        else
                        {
                            if (counter == rice.Count)
                                Console.WriteLine("Name doesnt Exist!");
                        }
                    }
                    InventoryMain.WriteToFile(jsonObjectArray);
                    Console.WriteLine("DATA DELTED!");
                    break;


                case "wheat":
                    Console.WriteLine("Enter wheat type to Delete:");
                    Type = Console.ReadLine().ToLower();
                    List<Wheat> wheat = jsonObjectArray.WheatList;
                    foreach (var item in wheat.ToArray())
                    {
                        if (item.Name.ToLower() == Type)
                        {
                            wheat.Remove(item);
                        }
                        else
                        {
                            Console.WriteLine("Name doesnt Exist!");
                        }
                    }
                    InventoryMain.WriteToFile(jsonObjectArray);
                    Console.WriteLine("DATA DELTED!");
                    break;

                case "pulses":
                    Console.WriteLine("Enter pulses type to Delete:");
                    Type = Console.ReadLine().ToLower();
                    List<Pulses> pulses = jsonObjectArray.PulsesList;
                    foreach (var item in pulses.ToArray())
                    {
                        if (item.Name.ToLower() == Type)
                        {
                            if (item.Name.ToLower() == Type)
                            {
                                pulses.Remove(item);
                            }
                            else
                            {
                                Console.WriteLine("Name doesnt Exist!");
                            }
                        }
                    }
                    InventoryMain.WriteToFile(jsonObjectArray);
                    Console.WriteLine("DATA DELTED!");
                    break;
                default:
                    Console.WriteLine("Name doesnt exist!");
                    break;
            }

        }
        public void Additems(String filepath)
        {
            string jsonData = File.ReadAllText(filepath);
            InventoryModel jsonObjectArray = JsonConvert.DeserializeObject<InventoryModel>(jsonData);
            String Check = "";
            Console.WriteLine("Enter a List name(Rice,Wheat or Pulses) to edit :");
            Check = Console.ReadLine().ToLower();
            switch (Check)
            {
                case "rice":
                    List<Rice> rice = jsonObjectArray.RiceList;
                    Rice rc = new Rice();
                    Console.WriteLine("Enter new rice type :");
                    rc.Name = Console.ReadLine().ToLower();
                    Console.WriteLine("Enter Weight of new rice :");
                    rc.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter PricePerKg of new Rice :");
                    rc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                    rice.Add(rc);
                    InventoryMain.WriteToFile(jsonObjectArray);
                    Console.WriteLine("DATA ADDED!");
                    break;


                case "wheat":

                    List<Wheat> wheat = jsonObjectArray.WheatList;
                    Wheat wh = new Wheat();
                    Console.WriteLine("Enter new wheat type :");
                    wh.Name = Console.ReadLine().ToLower();
                    Console.WriteLine("Enter Weight of new rice :");
                    wh.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter PricePerKg of new Wheat :");
                    wh.PricePerKg = Convert.ToInt32(Console.ReadLine());
                    wheat.Add(wh);
                    InventoryMain.WriteToFile(jsonObjectArray);
                    Console.WriteLine("DATA ADDED!");
                    break;

                case "pulses":
                    List<Pulses> pulses = jsonObjectArray.PulsesList;
                    Pulses pl = new Pulses();
                    Console.WriteLine("Enter new pulses type :");
                    pl.Name = Console.ReadLine().ToLower();
                    Console.WriteLine("Enter Weight of new pulses :");
                    pl.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter PricePerKg of new Pulses :");
                    pl.PricePerKg = Convert.ToInt32(Console.ReadLine());
                    pulses.Add(pl);
                    InventoryMain.WriteToFile(jsonObjectArray);
                    Console.WriteLine("DATA ADDED!");
                    break;
                default:
                    Console.WriteLine("Name doesnt exist!");
                    break;
            }
        }
    }
}
