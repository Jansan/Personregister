using System;
using System.Collections.Generic;

namespace Arv
{
     class Program
    {
        static void Main(string[] args)
        {
            //List<Animal> animals = new List<Animal>();
            //animals.Add(new Dog("Brony", 5, 6, 2));

            List<Animal> animals = new List<Animal>
            {
                new Horse("Mia", 400, 18, 200),
                new Dog("Kalle", 2, 6, 2),
                new Hedgehog("pippa", 20, 30, "white"),
                new Worm("Dila",0.5,1, true),
                new Bird("Petti", 0.5, 5, 2),
                new Wolf("Blacky", 15, 8, 0.7),
                new Pelican("Killi", 14, 6, 2, 2),
                new Flamingo("Filla", 7, 10, 2, "White"),
                new Swan("Sugu", 10, 3, 2, true),
                new Wolfman("Kalle", 3, 1, 9)


            };

            foreach (var animal in animals)
            {
                animal.DoSound();
                if(animal is IPerson person)
                {
                    person.Talk();
                    
                    //((IPerson)animal).Talk();
                }
            }

            // 13. F: class Bird 
            // 14. F: class Animal



        }
    }
}
