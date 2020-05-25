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

            for (int AnimNum = 0; amount > AnimNum; AnimNum++)//en for loop som körs så länge amount är större än animNum
            {
                int x = rng.Next(1, 3);//1 och 3 då den tar värdet under

                if (x == 1)//om nummret blir 1 så sker följande
                {
                    animals.Add(new Teddybear());//En teddybjörn läggs till i listan
                }
                else//om nummret blir annat så sker följande
                {
                    animals.Add(new Unicorn());//En Unicorn läggs till i listan
                }

            

            
        }
    }
}
