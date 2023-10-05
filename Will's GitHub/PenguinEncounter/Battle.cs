using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinEncounter
{
    internal class Battle
    {
        public Battle (Player protagonist, Enemy antagonist/*, int playerHealth, int enemyHealth*/)
        {
            Protagonist = protagonist;
            Antagonist = antagonist;
            //PlayerHealth = playerHealth;
            //EnemyHealth = enemyHealth;
        }
        public Player Protagonist { get; set; }
        public Enemy Antagonist { get; set; }
        //public int PlayerHealth { get; }
        //public int EnemyHealth { get; }
        public void Fight()
        {
            while (Protagonist.Health > 0 && Antagonist.Health > 0)
            {
                Console.WriteLine($"{Antagonist.Name} is ready to fight! Do you...");
                Console.WriteLine("1) Punch -or- 2) Kick");
                string answer = Console.ReadLine();
                try
                {
                    if (answer == "1")
                    {
                        Console.WriteLine($"You punch {Antagonist.Name} in the snout.");
                        Antagonist.Health -= 15;
                    }
                    else if (answer == "2")
                    {
                        Console.WriteLine($"You kick {Antagonist.Name} in their stupid penguin stomach.");
                        Antagonist.Health -= 30;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format not read. You lose lol.");
                }
                Console.ReadLine();
                if (Antagonist.Health > 0)
                {

                    Console.WriteLine($"{Antagonist.Name} hit you with a penguin attack. It hurts, but you've felt worse.");
                    Console.WriteLine("Stupid penguins...");
                    Console.ReadLine();
                    Protagonist.Health -= 20;
                }
            }
            if (Antagonist.Health <= 0)
            {
                Antagonist.Die();
            }
            else if (Protagonist.Health <= 0)
            {
                Protagonist.Die();
            }
        }

    }
}
