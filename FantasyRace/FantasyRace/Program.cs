using System;
using System.Collections.Generic;

namespace FantasyRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FantasyRace.Animal> animals = new List<Animal>();//skapar en list
            Console.WriteLine("How many animals would you like to create?");
            string djur = Console.ReadLine();//det som skrivs in  blir en string
            int amount = 0;

            while (!int.TryParse(djur, out amount))//en loop som körs så länge 
            {
                Console.WriteLine("Try again. Please write a number over 0.");
                djur = Console.ReadLine();
            }
            Random rng = new Random();//skapar en ny generator för de två slumpvalda djuren

            for (int AnimNum = 0; AnimNum < amount; AnimNum++)//en for loop som körs så länge amount är större än animNum
            {
                int x = rng.Next(1, 3);//Den tar ett värde mellan 1 och 2

                if (x == 1)//om nummret blir 1 så sker följande
                {
                    animals.Add(new Teddybear());//En teddybjörn läggs till i listan
                }
                else//om nummret blir annat så sker följande
                {
                    animals.Add(new Unicorn());//En Unicorn läggs till i listan
                }
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            int Round = 0;//rundorna, börjar på 0
            Animal MainAnimal = animals[rng.Next(animals.Count)];//Ett djur slumpas från listan och blir Main animal.
            while (MainAnimal.position < 20)//så länge 20 är större än current pos så körs loopen
            {
                string answer = "";//svaret på kommande fråga sparas i denna string
                Console.WriteLine("Current round: "+Round);
                MainAnimal.PrintStats();//Den visar djurets stats, print metoden
                Console.WriteLine("Press 1 to move || Press 2 to rest");

                while (answer!= "1" && answer!= "2")
                {
                    answer = Console.ReadLine();
                }
                if (answer == "1")
                {
                    MainAnimal.Move();
                }
                else if (answer == "2")
                {
                    MainAnimal.Rest();
                }
                ++Round;
            }

            
        }
    }
}
