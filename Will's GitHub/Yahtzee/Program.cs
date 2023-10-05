using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

namespace Yahtzee
{
    internal class Program
    {
        static List<int> Roll(int needed)
        {
            List<int> currentRoll = new List<int>();
            
            for (int i = 0; i < needed; i++)
            {
                Random rnd = new Random();
                int die = rnd.Next(1, 7);
                currentRoll.Add(die);
            }
            Console.WriteLine("Current roll:");
            for (int j = 0; j < currentRoll.Count; j++)
            {
                Console.Write(currentRoll[j]);
            }
            //Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue.");
            //Console.ReadLine();
            return currentRoll;
        }
        static int Ones1(List<int> rollRN)
        {
            int counter = 0;
            const int value = 1;
            int score = 0;
            foreach (int num in rollRN)
            {
                if (num == 1)
                {
                    counter++;
                }
            }
            if (rollRN.Contains(1))
            {
                score = counter * value;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
            
        }
        static int Twos2(List<int> rollRN)
        {
            int counter = 0;
            const int value = 2;
            int score = 0;
            foreach (int num in rollRN)
            {
                if (num == 2)
                {
                    counter++;
                }
            }
            if (rollRN.Contains(2))
            {
                score = counter * value;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
        static int Threes3(List<int> rollRN)
        {
            int counter = 0;
            const int value = 3;
            int score = 0;
            foreach (int num in rollRN)
            {
                if (num == 3)
                {
                    counter++;
                }
            }
            if (rollRN.Contains(3))
            {
                score = counter * value;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
        static int Fours4(List<int> rollRN)
        {
            int counter = 0;
            const int value = 4;
            int score = 0;
            foreach (int num in rollRN)
            {
                if (num == 4)
                {
                    counter++;
                }
            }
            if (rollRN.Contains(4))
            {
                score = counter * value;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
        static int Fives5(List<int> rollRN)
        {
            int counter = 0;
            const int value = 5;
            int score = 0;
            foreach (int num in rollRN)
            {
                if (num == 5)
                {
                    counter++;
                }
            }
            if (rollRN.Contains(5))
            {
                score = counter * value;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
           
        }
        static int Sixes6(List<int> rollRN)
        {
            int counter = 0;
            const int value = 6;
            int score = 0;
            foreach (int num in rollRN)
            {
                if (num == 6)
                {
                    counter++;
                }
            }
            if (rollRN.Contains(6))
            {
                score = counter * value;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
            
        }
        static int ThreeOfAKind7(List<int> rollRN)
        {
            int score = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            foreach (int num in rollRN)
            {
                if (num == 1)
                {
                    counter1++;
                }
                else if (num == 2)
                {
                    counter2++;
                }
                else if (num == 3)
                {
                    counter3++;
                }
                else if (num == 4)
                {
                    counter4++;
                }
                else if (num == 5)
                {
                    counter5++;
                }
                else if (num == 6)
                {
                    counter6++;
                }
            }
            if (counter1 >= 3 || counter2 >= 3 || counter3 >= 3 || counter4 >= 3 || counter5 >= 3 || counter6 >= 3)
            {
                foreach (int num in rollRN)
                {
                    score += num;
                }
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
        static int FourOfAKind8(List<int> rollRN)
        {
            int score = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            foreach (int num in rollRN)
            {
                if (num == 1)
                {
                    counter1++;
                }
                else if (num == 2)
                {
                    counter2++;
                }
                else if (num == 3)
                {
                    counter3++;
                }
                else if (num == 4)
                {
                    counter4++;
                }
                else if (num == 5)
                {
                    counter5++;
                }
                else if (num == 6)
                {
                    counter6++;
                }
            }
            if (counter1 >= 4 || counter2 >= 4 || counter3 >= 4 || counter4 >= 4 || counter5 >= 4 || counter6 >= 4)
            {
                foreach (int num in rollRN)
                {
                    score += num;
                }
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
        static int FullHouse9(List<int> rollRN)
        {
            int score = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            foreach (int num in rollRN)
            {
                if (num == 1)
                {
                    counter1++;
                }
                else if (num == 2)
                {
                    counter2++;
                }
                else if (num == 3)
                {
                    counter3++;
                }
                else if (num == 4)
                {
                    counter4++;
                }
                else if(num == 5)
                {
                    counter5++;
                }
                else if (num == 6)
                {
                    counter6++;
                }
            }
            List<int> counters = new List<int>() { counter1, counter2, counter3, counter4, counter5, counter6 };
            if (counters.Contains(3) && counters.Contains(2))
            {
                score = 25;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
        static int SmallStraight10(List<int> rollRN)
        {
            int score = 0;
            bool isCase1 = (rollRN.Contains(1) && rollRN.Contains(2) && rollRN.Contains(3) && rollRN.Contains(4));
            bool isCase2 = (rollRN.Contains(2) && rollRN.Contains(3) && rollRN.Contains(4) && rollRN.Contains(5));
            bool isCase3 = (rollRN.Contains(3) && rollRN.Contains(4) && rollRN.Contains(5) && rollRN.Contains(6));
            if (isCase1 || isCase2 || isCase3)
            {
                score = 30;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
        static int LargeStraight11(List<int> rollRN)
        {
            int score = 0;
            bool isCase1 = (rollRN.Contains(1) && rollRN.Contains(2) && rollRN.Contains(3) && rollRN.Contains(4) && rollRN.Contains(5));
            bool isCase2 = (rollRN.Contains(2) && rollRN.Contains(3) && rollRN.Contains(4) && rollRN.Contains(5) && rollRN.Contains(6));
            if (isCase1 || isCase2)
            {
                score = 40;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
        static int YAHTZEE12(List<int> rollRN)
        {
            int score = 0;
            if (rollRN[0] == rollRN[1] && rollRN[0] == rollRN[2] && rollRN[0] == rollRN[3] && rollRN[0] == rollRN[4])
            {
                score = 50;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
        static int Chance13(List<int> rollRN)
        {
            int score = 0;
            foreach (int num in rollRN)
            {
                score += num;
            }
            return score;
        }
        static List<int> Turn(int turn)
        {
            if (turn < 2)
            {
                Console.WriteLine("Hi, thank you for playing Yahtzee! Press ENTER to roll your first roll!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("NEW TURN: Press ENTER to roll!");
                Console.ReadLine();
            }

            List<int> rollRN = new List<int>();
            int rollCounter = 0;
            while (rollCounter < 2)
            {
                Roll(5 - rollRN.Count);
                rollCounter++;
                Console.WriteLine("Keep which dice? (separate with space)");
                string response = Console.ReadLine();
                if (response == "")
                {
                    continue;
                }
                else
                {
                    List<string> indResp = response.Split(" ").ToList();
                    List<int> numResp = indResp.ConvertAll(int.Parse);
                    rollRN.AddRange(numResp);
                    if (rollRN.Count == 5)
                    {
                        break;
                    }
                    else if (rollCounter < 2)
                    {
                        Console.WriteLine("Press ENTER to reroll.");
                        Console.ReadLine();
                    }
                }
            }
            if (rollRN.Count < 5)
            {
                Console.WriteLine("Press ENTER to roll one last time.");
                Console.ReadLine();
                //rollRN.AddRange(Roll(5 - rollRN.Count));
                while (rollRN.Count < 5)
                {
                    Random rand = new Random();
                    int die = rand.Next(1, 7);
                    rollRN.Add(die);
                }
            }
            else if (rollRN.Count > 5)
            {
                Console.WriteLine("Greedy greedy! You can only select five numbers.");
                rollRN.RemoveRange(5, rollRN.Count - 5);
            }
            Console.WriteLine($"FINAL ROLL:");
            foreach (int num in rollRN)
            {
                Console.Write(num);
            }
            Console.ReadLine();
            return rollRN;
        }
        static List<int> Scorer(List<int> rollRN, List<int> choices)
        {
            List<int> scoreThenChoice = new List<int>() { 0, 0 };
            Console.WriteLine("Scoring Choices:");
            if (choices.Contains(1))
            {
                Console.WriteLine($"(1) Ones: {Ones1(rollRN)}");
            }
            if (choices.Contains(2))
            {
                Console.WriteLine($"(2) Twos: {Twos2(rollRN)}");
            }
            if (choices.Contains(3))
            {
                Console.WriteLine($"(3) Threes: {Threes3(rollRN)}");
            }
            if (choices.Contains(4))
            {
                Console.WriteLine($"(4) Fours: {Fours4(rollRN)}");
            }
            if (choices.Contains(5))
            {
                Console.WriteLine($"(5) Fives: {Fives5(rollRN)}");
            }
            if (choices.Contains(6))
            {
                Console.WriteLine($"(6) Sixes: {Sixes6(rollRN)}");
            }
            if (choices.Contains(7))
            {
                Console.WriteLine($"(7) Three of a Kind: {ThreeOfAKind7(rollRN)}");
            }
            if (choices.Contains(8))
            {
                Console.WriteLine($"(8) Four of a Kind: {FourOfAKind8(rollRN)}");
            }
            if (choices.Contains(9))
            {
                Console.WriteLine($"(9) Full House: {FullHouse9(rollRN)}");
            }
            if (choices.Contains(10))
            {
                Console.WriteLine($"(10) Small Straight: {SmallStraight10(rollRN)}");
            }
            if (choices.Contains(11))
            {
                Console.WriteLine($"(11) Large Straight: {LargeStraight11(rollRN)}");
            }
            if (choices.Contains(12))
            {
                Console.WriteLine($"(12) YAHTZEE: {YAHTZEE12(rollRN)}");
            }
            if (choices.Contains(13))
            {
                Console.WriteLine($"(13) Chance: {Chance13(rollRN)}");
            }
            Console.WriteLine("Type the number of the play you want scored: ");
            string responseRaw = Console.ReadLine();
            int choice = Int32.Parse(responseRaw);
            if (choice == 1)
            {
                scoreThenChoice[0] = Ones1(rollRN);
                scoreThenChoice[1] = 1;
                Console.WriteLine($"Ones selected! {Ones1(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 2)
            {
                scoreThenChoice[0] = Twos2(rollRN);
                scoreThenChoice[1] = 2;
                Console.WriteLine($"Twos selected! {Twos2(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                scoreThenChoice[0] = Threes3(rollRN);
                scoreThenChoice[1] = 3;
                Console.WriteLine($"Threes selected! {Threes3(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 4)
            {
                scoreThenChoice[0] = Fours4(rollRN);
                scoreThenChoice[1] = 4;
                Console.WriteLine($"Fours selected! {Fours4(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 5)
            {
                scoreThenChoice[0] = Fives5(rollRN);
                scoreThenChoice[1] = 5;
                Console.WriteLine($"Fives selected! {Fives5(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 6)
            {
                scoreThenChoice[0] = Sixes6(rollRN);
                scoreThenChoice[1] = 6;
                Console.WriteLine($"Sixes selected! {Sixes6(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 7)
            {
                scoreThenChoice[0] = ThreeOfAKind7(rollRN);
                scoreThenChoice[1] = 7;
                Console.WriteLine($"Three of a Kind selected! {ThreeOfAKind7(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 8)
            {
                scoreThenChoice[0] = FourOfAKind8(rollRN);
                scoreThenChoice[1] = 8;
                Console.WriteLine($"Four of a Kind selected! {FourOfAKind8(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 9)
            {
                scoreThenChoice[0] = FullHouse9(rollRN);
                scoreThenChoice[1] = 9;
                Console.WriteLine($"Full House selected! {FullHouse9(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 10)
            {
                scoreThenChoice[0] = SmallStraight10(rollRN);
                scoreThenChoice[1] = 10;
                Console.WriteLine($"Small Straight selected! {SmallStraight10(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 11)
            {
                scoreThenChoice[0] = LargeStraight11(rollRN);
                scoreThenChoice[1] = 11;
                Console.WriteLine($"Large Straight selected! {LargeStraight11(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 12)
            {
                scoreThenChoice[0] = YAHTZEE12(rollRN);
                scoreThenChoice[1] = 12;
                Console.WriteLine($"YAHTZEE!!! {YAHTZEE12(rollRN)} points earned.");
                Console.ReadLine();
            }
            else if (choice == 13)
            {
                scoreThenChoice[0] = Chance13(rollRN);
                scoreThenChoice[1] = 13;
                Console.WriteLine($"Chance selected! {Chance13(rollRN)} points earned.");
                Console.ReadLine();
            }
            else
            {
                scoreThenChoice[0] = 0;
                scoreThenChoice[1] = 0;
                Console.WriteLine("You fool! Follow directions better!");
                Console.ReadLine();
            }
            return scoreThenChoice;
        }
        static void Main(string[] args)
        {
            int score = 0;
            int turnCounter = 1;
            List<int> scoringChoices = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            while (scoringChoices.Count > 0)
            {
                if (turnCounter > 1)
                {
                    Console.WriteLine($"CURRENT SCORE: {score}");
                }
                List<int> intRoll = Turn(turnCounter);
                turnCounter++;

                List<int> scoreThenChoice = Scorer(intRoll, scoringChoices);
                int scoreToAdd = scoreThenChoice[0];
                int toRemove = scoreThenChoice[1];

                score += scoreToAdd;
                if (toRemove == 0)
                {
                    scoringChoices.RemoveAt(0);
                }
                else
                {
                    scoringChoices.Remove(toRemove);
                }
            }
            Console.WriteLine("GAME OVER!");
            Console.WriteLine($"Final Score {score}");
            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
            
        }
    }
}