using System;
using System.Collections.Generic;

namespace rpg.DIEHARD
{
    class Item
    {
        public string Name { get; set;}
        public int Situation { get; set;}

        public Item(string name, int situation)
        {
            Name = name;
            Situation = situation;
        }

        Item energyBar = new Item ("Energy Bar", 0);
        Item catFood = new Item ("Cat Food", 1);
        Item walkieTalkie= new Item ("Walkie-Talkie", 0);
        Item bearMace = new Item ("Bear-Mace", 3);
        Item rope = new Item ("Energy Bar", 4);
        Item note = new Item ("note", 0);
        Item blowDart = new Item ("Blow-Dart", 5);
        Item orangeChicken = new Item ("Orange Chicken", 2);

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