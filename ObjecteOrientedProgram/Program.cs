﻿using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Welcome to Object Oriented Program");
                    Console.WriteLine("Choose the Option : \n 1. JSON \n 2. Inventory Management \n 3. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            InventoryMain inv = new InventoryMain();
                            inv.DisplayData(@"E:\BridgeLAbz\Git\Json-Problem\Json-Problem\ObjecteOrientedProgram\File\Inventory.json");
                            break;
                        case 2:
                            InventoryMain invent = new InventoryMain();
                            invent.ReadData(@"E:\BridgeLAbz\Git\Json-Problem\Json-Problem\ObjecteOrientedProgram\File\InventoryList.json");
                            invent.DisplayData("Rice");
                            invent.DisplayData("Wheat");
                            invent.DisplayData("Pulses");
                            break;
                        case 3:
                            flag = false;
                            break;
                    }
                }
        }
    }
}