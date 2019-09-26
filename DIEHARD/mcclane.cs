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
            Console.WriteLine("MCCLANE: What do you want to do next, " + newHero.Name + "?");
            Console.WriteLine("1. Explore the Zoo");
            Console.WriteLine("2. Check Backpack");
            Console.WriteLine("3. Check Health");
            Console.WriteLine("4. View Animals Found");
            Console.WriteLine("--------------------------------");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                ExploreZoo(newHero);
            }
            else if (userInput == 2)
            {
                newHero.CheckBackpack(newHero);
            }
            else if (userInput == 3)
            {
                newHero.CheckHealth(newHero);
            }
            else if (userInput == 4)
            {
                newHero.FoundAnimals(newHero);
            }
            else 
            {
                Console.WriteLine("MCCLANE: Quit wasting time " + newHero.Name + "! Enter a valid number!");
                McClane.Navigation(newHero);
            }
        }

        public static void ExploreZoo(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Great idea, " + newHero.Name + "! What part of the zoo do you want to explore?");
            Console.WriteLine("1. Big Cat Exhibit");
            Console.WriteLine("2. Food Court");
            Console.WriteLine("3. Gift Shop");
            Console.WriteLine("4. Aquarium");
            Console.WriteLine("5. Atrium");
            Console.WriteLine("6. Return To Main Menu");
            Console.WriteLine("--------------------------------");
            string zooExplore = Console.ReadLine();

            if (zooExplore == "1")
            {
                newHero.ExploreBigCat(newHero);
            }
            else if (zooExplore =="2")
            {
                ExploreFoodCourt(newHero);
            }
            else if (zooExplore =="3")
            {
                ExploreGiftShop(newHero);
            }
            else if (zooExplore =="4")
            {
                ExploreAquarium(newHero);
            }
            else if (zooExplore =="5")
            {
                ExploreAtrium(newHero);
            }
            else if (zooExplore =="6")
            {
                McClane.Navigation(newHero);
            }
            else
            {
                Console.WriteLine("MCCLANE: Quit wasting time " + newHero.Name + "! Enter a valid number!");
                McClane.ExploreZoo(newHero);
            }
        }

        public void CheckBackpack(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            foreach (string item in newHero.Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------");
            Navigation(newHero);
        }

        public void CheckHealth(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Health: " + newHero.Health);
            Console.WriteLine("--------------------------------");
            Navigation(newHero);
        }

        public void FoundAnimals(McClane newHero)
        {
            foreach (string animals in newHero.AnimalsFound)
            {
                Console.WriteLine(animals);
            }
            Console.WriteLine("--------------------------------");
            Navigation(newHero);
        }

        public void HealthDown(McClane newHero)
        {
            newHero.Health -= 10;
        }

        public void HealthUp(McClane newHero)
        {
            newHero.Health += 10;
        }

        public void ExploreBigCat(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("**You and John make your way towards the Big Cat Exhibit. The main entrance glass is shattered and covers the floor.**");
            Console.WriteLine("MCCLANE: Glad I wore my shoes today.");
            Console.ReadKey(true);
            Console.WriteLine("**You and John navigate through the glass. You notice the interior walls of the exhibit are covered in claw marks.**");
            Console.WriteLine("MCCLANE: SHIT THOSE ARE SOME BIG KITTENS! I'D BE LION IF I SAID I WASN'T A LITTLE NERVOUS " + newHero.Name + "!");
            Console.WriteLine("MCCLANE: What should we do?");
            Console.WriteLine("--------------------------------");
            string bigCatInput = Console.ReadLine();
            Console.WriteLine("1. Use an Item");
            Console.WriteLine("2. Fight the Lion");
            Console.WriteLine("3. Sneak up on the Tiger");
            Console.WriteLine("4. Leave Big Cat Exhibit");
            Console.WriteLine("--------------------------------");

            if (bigCatInput == "1")
            {
                Item.UseItem(newHero);
                string item = Item.UseItem(newHero);
                
                if (item == )


            }
            else if (bigCatInput == "2")
            {

            }
            else if (bigCatInput == "2")
            {

            }
            else if (bigCatInput == "2")
            {

            }
            else{
                Console.WriteLine("MCCLANE: Quit wasting time " + newHero.Name + "! Enter a valid number!");
                McClane.ExploreZoo(newHero);
            }
        }
        public void ExploreFoodCourt(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
        }
        public void ExploreGiftShop(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
        }
        public void ExploreAquarium(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
        }
        public void ExploreAtrium(McClane newHero)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
        }
    }
}

