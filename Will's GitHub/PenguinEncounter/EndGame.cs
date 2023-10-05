using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinEncounter
{
    internal class EndGame
    {
        public int Health = 0;
        public void Win()
        {
            Console.WriteLine("EXCELSIOR!!! You've defeated Queen Victoria, queen of the penguins.");
            Console.WriteLine("Now, all penguins are gone from the British Isles, and their queen can no longer spawn more.");
            Console.WriteLine("You return to your village a hero.");
            Console.ReadLine();
        }
        public void Lose()
        {
            Console.WriteLine("Well mate, I reckon you've died");
            Console.WriteLine("I'd say try again but.... you died... so....");
            Console.WriteLine("........");
            Console.ReadLine();
        }
    }
}
