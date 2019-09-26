using System;
using System.Collections.Generic;

namespace rpg.DIEHARD
{
    class McClane
    {
        public string Name { get; set;}
        public List<string> AnimalsFound { get; set;}
        public List<string> Items { get; set;}
        public int Health { get; set;}

        public McClane(string name)
        {
            Name = name;
            AnimalsFound = new List<string> {};
            Items = new List<string> {"Can of Cat Food", "Bear Mace", "Walkie-Talkie", "Energy Bar"};
            Health = 100;
        }

        public static void BeginRPG()
        {
            Console.WriteLine("**Well that was stupid. Now there are dangerous animals loose in the zoo! Only one man can fix this mess you've created: JOHN MCCLANE**");
            Console.WriteLine("It's up to you and John to explore the zoo and return all the escaped animals back to their respective enclosures. You've been given a small bag of items to help you along your adventure. Be sure to look for other items to add along the way, they will come in handy further down the road. Be careful though, loose animals are dangerous and the amount of damage you can take will be limited.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("MCCLANE: These god damn animals aren't going to catch themselves. I havn't seen a situation like this since Nakatomi Plaza. What's your first name soldier?");
            string userName = Console.ReadLine();
            McClane newHero = new McClane(userName);
            Console.WriteLine("MCCLANE: Good to have you aboard " + userName + ". Gotta find these animals and get to the bottom of who did this.");
            Navigation(newHero);
            
        }


        public static void Navigation(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("MCCLANE: What do you want to do next, " + newHero.Name + "?");
            Console.WriteLine("1. Explore the Zoo");
            Console.WriteLine("2. Check Backpack");
            Console.WriteLine("3. Check Health");
            Console.WriteLine("4. View Animals Found"); 

        }
    }
}

