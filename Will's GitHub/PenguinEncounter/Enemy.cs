using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinEncounter
{
    internal class Enemy
    {
        public Enemy(string name, int health)
        {
            Name = name;
            Health = health;
            IsHit = false;
        }
        public string Name { get; }
        public int Health { get; set; }
        public bool IsHit { get; }
        public void Fight()
        {

        }
        public void Die()
        {
            Console.WriteLine($"You hit {Name} one last time and they fall.");
            Console.WriteLine($"They make some strange sputtering noises and grow motionless.");
            Console.WriteLine($"Congratulations! You've won the battle!");
        }
        public void Intro()
        {
            Console.WriteLine($"{Name} is standing before you, they look mad!");
            Console.WriteLine("Hey! You're not supposed to be here! Turn around or face my wrath!");
            Console.WriteLine($"{Name} jumps toward you, ready to fight.");
            Console.ReadLine();
        }
    }
}
