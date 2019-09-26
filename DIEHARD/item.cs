using System;
using System.Collections.Generic;

namespace rpg.DIEHARD
{
    class Item
    {
        public static string UseItem(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Current Items:");
            foreach (string item in newHero.Items)
            {
            Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("What item do you want to use? Type below:");
            string userItem = Console.ReadLine();
            return userItem;
        }
    }
}