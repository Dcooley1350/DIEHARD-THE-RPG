using System;
using System.Collections.Generic;
using rpg.DIEHARD;

namespace rpg.DIEHARD
{
    public class Program
    {
        public static void Main()
        {
            Animal tiger = new Animal ("Tonya", "Tiger", "Asia", "Mammal");
            Animal hippo = new Animal ("Henry", "Hippo", "Africa", "Mammal");
            Animal elephant = new Animal ("Elizabeth", "Elephant", "Africa", "Mammal");
            Animal komodoDragon = new Animal ("Karl", "Komodo Dragon", "Asia", "Reptile");
            Animal lion = new Animal ("Leroy", "Lion", "Africa", "Mammal");
            Animal koala = new Animal ("Katherine", "Koala", "Australia", "Marsupial");
            Animal frog = new Animal ("Todd", "Giant Toad", "North America", "Amphibian");
            Animal osprey = new Animal ("Otis", "Osprey", "North America", "Bird");

            List<Animal> animals = new List<Animal> () {tiger, hippo, elephant, komodoDragon, lion, koala,frog, osprey};

            Animal.MainSearch(animals);













        }
    }
}