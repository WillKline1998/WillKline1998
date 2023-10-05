using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinEncounter
{
    internal class Player
    {
        public Player(string name, int health)
        {
            Name = name;
            Health = health;
            IsDead = false;
        }
        public string Name { get; }
        public int Health { get; set; }
        public bool IsDead { get; set; }// = false;

        public void Fight()
        {

        }
        public void Die()
        {
            Console.WriteLine("Blasted! They've done me in!");
            Console.WriteLine("I'm seeing stars. I can see mygrandparents again.");
            Console.WriteLine("Im so sleepy.....");
            Console.WriteLine("You died. ://");
            Console.ReadLine();
            IsDead = true;
        }

    }
}
