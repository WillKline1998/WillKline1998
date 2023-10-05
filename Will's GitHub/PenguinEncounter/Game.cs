using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinEncounter
{
    public class Game
    {
        public void Play()
        {
            EndGame ending = new EndGame();
            Console.WriteLine("Oy scrub, what's yer name?");
            string name = Console.ReadLine();
            Player you = new Player(name, 100);

            Console.WriteLine("Blimey! Yer body's hurtin' and bloodied... you look up and there she stands...");
            Console.WriteLine("Buckin'ham Palace. You reckon there's work to do inside.");
            Console.WriteLine("Standing outside, theres blasted rotten penguins everywhere, dead, all killed by you.");
            Console.WriteLine("Things ain't been right since the damn penguins got here, but yer work's almost done.");
            Console.WriteLine("Do you:");
            Console.WriteLine("1) Enter the palace -or - 2) Go home and pray");
            string answer1 = Console.ReadLine();
            try
            {
                if (answer1 == "1")
                {
                    Console.WriteLine("Excellent. This battle is yers.");
                    Console.ReadLine();
                }
                else if (answer1 == "2")
                {
                    Console.WriteLine("You head home... coward. Count yer days. If you don't eliminate the source of the penguins, the danger won't end.");
                    Console.ReadLine();
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Answer format not understood. Restart Game.");
                Console.ReadLine();
            }
            Room foyer = new Room("Royal Foyer", "Lawn", "Queen's Chamber");
            foyer.Enter();
            Enemy gruntPenguin = new Enemy("Penguin Grunt", 50);
            gruntPenguin.Intro();
            Battle gruntBattle = new Battle(you, gruntPenguin);
            gruntBattle.Fight();
            if (you.IsDead)
            {
                ending.Lose();
                return;
            }
            Console.WriteLine("Right, now that that's over... do you.....");
            Console.WriteLine("1) Enter Queen's Chamber -or- 2) Go Home");
            string answer2 = Console.ReadLine();
            try
            {
                if (answer2 == "1")
                {
                    Console.WriteLine("Excellent. This battle is yers.");
                    Console.ReadLine();
                }
                else if (answer2 == "2")
                {
                    Console.WriteLine("You head home... coward. Count yer days. If you don't eliminate the source of the penguins, the danger won't end.");
                    Console.ReadLine();
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Answer format not understood. Restart Game.");
                Console.ReadLine();
            }
            Room queenChamber = new Room("Queen's Chamber", "Royal Foyer");
            queenChamber.Enter();
            Console.WriteLine("You stand before Queen Victoria, the Queen of Penguins, she looks angry.");
            Console.WriteLine("You feel a lump in your pocket. It's a potion! Do you...");
            Console.WriteLine("1) Take the potion -or- 2) Don't take the potion. I'm gluten-free");
            string answer3 = Console.ReadLine();
            try
            {
                if (answer3 == "1")
                {
                    Console.WriteLine("Tastes disgusting! But you feel your health surge! Let's do this!");
                    Console.ReadLine();
                    you.Health = 200;
                }
                else if (answer3 == "2")
                {
                    Console.WriteLine("You stomach remains unbloated, but you're overcome with a feeling of regret. Let's begin the battle...");
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Answer format not understood. Restart Game.");
                Console.ReadLine();
            }
            Enemy queenVictoria = new Enemy("Queen Victoria", 120);
            queenVictoria.Intro();
            Battle bossBattle = new Battle(you, queenVictoria);
            bossBattle.Fight();
            if (you.IsDead)
            {
                ending.Lose();
                return;
            }
            else if (!you.IsDead)
            {
                ending.Win();
                return;
            }
        }
    }
}
