using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyRace
{
    class Unicorn: Animal
    {
        public Unicorn()//Skapade en konstruktor
        {
            speed = Animal.generator.Next(6,8);//i konstruktorn skapade använde jag mig utav animal-klassens generator.
            position = 0;//Positionen startar som 0
            enegryMax = Animal.generator.Next(5, 7);//Unicorns max enegry är mellan 5 och 7.
            energyCurrent = enegryMax;//energyCurrent är samma som Max då det ändras
            Console.WriteLine("You created a Unicorn !");
            PrintStats();//efter att djuret skapats så visas dess stats 
        }
    }
}
