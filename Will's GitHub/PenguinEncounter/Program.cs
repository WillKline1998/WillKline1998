namespace PenguinEncounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, dear Player!");
            Console.WriteLine("Welcome to my game, Penguin Encounter.");
            Console.WriteLine("Press ENTER to begin:");
            Console.ReadLine();
            Game newGame = new Game();
            newGame.Play();
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Created by Will Kline, 10-4-2023");
            Console.ReadLine();
        }
    }
}