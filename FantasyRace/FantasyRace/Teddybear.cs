using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyRace
{
    class Teddybear: Animal
    {
        public Teddybear()//Skapade en konstruktor
        {
            speed = Animal.generator.Next(4, 5);//i konstruktorn skapade använde jag mig utav animal-klassens generator.
            position = 0;//Positionen startar som 0
            enegryMax = Animal.generator.Next(7, 10);//Teddyns max enegry är mellan 7 och 10.
            energyCurrent = enegryMax;//energyCurrent är samma som Max då det i början är samma
            Console.WriteLine("You created a Teddybear !");
            PrintStats();//efter att djuret skapats så visas dess stats 
        }
    }
}
