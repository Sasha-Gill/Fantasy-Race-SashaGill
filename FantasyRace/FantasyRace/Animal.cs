using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyRace
{
    class Animal
    {
        public int speed;
        public int position;
        public int energyCurrent;
        public int enegryMax;
        public static Random generator = new Random();//en statisk slupgenerator som de båda delar på.

        public void Move() 
        {
        if (energyCurrent > 0)//så länge enegin är högre än 0 så rör sig djuret.
            {
                position += Animal.generator.Next(1, speed);//positionen ökas randomly mellan 1 och dess speed.
              
                if (position > 20)//ifall djuret kommer över position 20 så sker detta
                {
                    position = 20;//djurets position blir 20 då det är sista positionen, finns inget efter.
                }
                energyCurrent--;//vid varje runda minskar energi current till -1
            }
        }
        public void Rest()
        {
            energyCurrent = enegryMax;//Energycurrent blir det samma som Max
            //i Move metoden så minskas energyCurrent så därför behöver karaktären vila så att staminan kmr tbx
        }
        public void PrintStats()
        {
            Console.WriteLine("Speed: "+speed);
            Console.WriteLine("Position: "+position);
            Console.WriteLine("Energy: "+energyCurrent+ " of "+enegryMax);
            Console.WriteLine("-----------------");
        }

    }
}
