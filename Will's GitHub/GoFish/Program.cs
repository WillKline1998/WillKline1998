using System.Linq;

namespace GoFish
{
    public class Program
    {
        public static Tuple<List<string[]>, List<string[]>> DealHand(List<string[]> deck)
        {
            //creates empty hand
            List<string[]> hand = new List<string[]>();

            //creates list of indexes to add to deck
            HashSet<int> numbers = new HashSet<int>();
            Random rnd = new Random();
            while (numbers.Count < 5)
            {
                numbers.Add(rnd.Next(0, deck.Count-1));
            }

            //deals chosen indexes into hand, deletes them from deck
            List<string[]> intHand = new List<string[]>();
            foreach (int num in numbers)
            {
                hand.Add(deck[num]);
                intHand.Add(deck[num]);
            }
            foreach (string[] card in intHand)
            {
                deck.Remove(card);
            }
            //foreach (int num in numbers)
            //{
            //    deck.Remove(deck[num]);
            //}
            return new Tuple<List<string[]>, List<string[]>>(hand, deck);
        }

        public static void PrintHand(List<string[]> hand)
        {
            //displays cards in your hand
            Console.WriteLine("Your hand:");
            foreach (string[] card in hand)
            {
                Console.WriteLine($"{card[0]} of {card[1]}");
            }
            //Console.WriteLine();
            Console.ReadLine();
        }

        public static List<string[]> PairCheck(List<string[]> hand, bool isUser, int turnCounter)
        {
            //creates list to hold values in hand
            List<string> values = new List<string>();
            foreach (string[] card in hand)
            {
                values.Add(card[0]);
            }

            //checks for duplicate values and adds them to a list of duplicates
            IEnumerable<string> duplicates = values.GroupBy(x => x)
                .SelectMany(g => g.Skip(1));
            if (duplicates.Count() == 0 && isUser)
            {
                Console.WriteLine("No pairs.");
            }
            else
            {
                if (isUser && turnCounter ==1)
                {
                    Console.WriteLine("Your pairs are: " + String.Join(",", duplicates));
                }
                //else
                //{
                //    Console.WriteLine("Computer's pairs are: " + String.Join(",", duplicates));
                //}

                //removes pairs from hand
                List<string[]> intHand = new List<string[]>();
                foreach (string[] card in hand)
                {
                    if (duplicates.Contains(card[0]))
                    {
                        intHand.Add(card);
                        //hand.Remove(card);
                    }
                }
                foreach (string[] card in intHand)
                {
                    hand.Remove(card);
                }
                if (isUser && duplicates.Count() > 0 && turnCounter > 1)
                {
                    Console.WriteLine("Congrats! Pairs detected.");
                    PrintHand(hand);
                }
                else if (isUser && duplicates.Count() > 0)
                {
                    PrintHand(hand);
                }
            }
            //Console.ReadLine();
            return hand;
        }

        public static Tuple<List<string[]>, List<string[]>, List<string[]>> Turn(List<string[]> myHand, List<string[]> oppHand, List<string[]> deck, int turnCounter)
        {
            bool isUser = true;
            int myStreak = 1;
            int oppStreak = 1;
            int matchCounter = 0;
            List<string[]> myIntHand = new List<string[]>();
            List<string[]> oppIntHand = new List<string[]>();

            //starts user's turn, checks for pairs and deletes them
            Console.WriteLine("Your turn!");
            Console.WriteLine();
            PrintHand(myHand);
            myHand = PairCheck(myHand, isUser, turnCounter);
            //repeats your turn until you're told to go fish
            do
            {
                if (myHand.Count < 1 || oppHand.Count < 1)
                {
                    return new Tuple<List<string[]>, List<string[]>, List<string[]>>(myHand, oppHand, deck);
                }
                //PrintHand(myHand);
                Console.WriteLine("Got any (type 2-10, Ace, King, Queen, or Jack)?");
                string myResp = Console.ReadLine();

                foreach (string[] card in oppHand)
                {
                    if (myResp == card[0])
                    {
                        myHand.Add(card);
                        oppIntHand.Add(card);
                        //oppHand.Remove(card);
                        matchCounter++;
                    }
                }
                if(oppIntHand.Count == 0)
                {
                    myStreak = 1;
                    Console.WriteLine("Computer: Nope! Go fish!");
                    //Console.ReadLine();
                    Random rand = new Random();
                    int draw = rand.Next(0, deck.Count);
                    myHand.Add(deck[draw]);
                    List<string> newDraw = deck[draw].ToList();
                    Console.WriteLine($"You drew the {newDraw[0]} of {newDraw[1]}s.");
                    newDraw.Clear();
                    deck.Remove(deck[draw]);
                    //continue;
                    break;
                }
                if (oppIntHand.Count > 0)
                {
                    foreach (string[] card in oppIntHand)
                    {
                        oppHand.Remove(card);
                        myStreak++;
                    }
                }
                //if (matchCounter > 0)
                //{
                //    myStreak++;
                //}

                //else
                //{
                //    myStreak = 1;
                //    Console.WriteLine("Nope! Go fish!");
                //    //Console.ReadLine();
                //    Random rand = new Random();
                //    int draw = rand.Next(0, deck.Count);
                //    myHand.Add(deck[draw]);
                //    deck.Remove(deck[draw]);
                //    //continue;
                //    break;
                //}
                oppIntHand.Clear();
                myHand = PairCheck(myHand, isUser, turnCounter);
            } while (myStreak > 1);
            Console.ReadLine();

            //starts computer's turn
            isUser = false;
            matchCounter = 0;
            Console.WriteLine("Computer's turn!");
            oppHand = PairCheck(oppHand, isUser, turnCounter);
            //repeats computer's turn until you tell it to go fish
            do
            {
                if (oppHand.Count < 1 || myHand.Count < 1)
                {
                    return new Tuple<List<string[]>, List<string[]>, List<string[]>>(myHand, oppHand, deck);
                }
                Random rnd = new Random();
                int pick = rnd.Next(0, oppHand.Count - 1);
                string[] checker = oppHand[pick];
                Console.WriteLine($"Computer: Got any {checker[0]}s?");
                Console.ReadLine();
                string oppResp = checker[0];
                foreach (string[] card in myHand)
                {
                    if (oppResp == card[0])
                    {
                        oppHand.Add(card);
                        //myHand.Remove(card);
                        myIntHand.Add(card);
                        matchCounter++;
                    }
                }
                if (myIntHand.Count == 0)
                {
                    oppStreak = 1;
                    Console.WriteLine("You say: Nope! Go fish!");
                    Console.ReadLine();
                    Random rand = new Random();
                    int draw = rand.Next(0, deck.Count - 1);
                    oppHand.Add(deck[draw]);
                    deck.Remove(deck[draw]);
                    //continue;
                    break;
                }
                if (myIntHand.Count > 0)
                {
                    foreach (string[] card in myIntHand)
                    {
                        myHand.Remove(card);
                    }
                }
                if (matchCounter > 0)
                {
                    oppStreak++;
                }
                //else
                //{
                //    oppStreak = 1;
                //    Console.WriteLine("You say: Nope! Go fish!");
                //    Console.ReadLine();
                //    Random rand = new Random();
                //    int draw = rand.Next(0, deck.Count - 1);
                //    oppHand.Add(deck[draw]);
                //    deck.Remove(deck[draw]);
                //    //continue;
                //    break;
                //}
                myIntHand.Clear();
                oppHand = PairCheck(oppHand, isUser, turnCounter);
            } while (oppStreak > 1);

            return new Tuple<List<string[]>, List<string[]>, List<string[]>>(myHand, oppHand, deck);

        }
        static void Main(string[] args)
        {
            int turnCounter = 1;
            //creates deck
            List<string[]> deck = new List<string[]>(52);
            string[] suites = new string[] { "Hearts", "Spades", "Clubs", "Diamonds" };
            string[] values = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            foreach (string suite in suites)
            {
                foreach (string value in values)
                {
                    deck.Add([value, suite]);
                }
            }
            
            //deals to opponent
            var oppDeal = DealHand(deck);
            List<string[]> oppHand = oppDeal.Item1;
            deck = oppDeal.Item2;

            //deals to you
            var myDeal = DealHand(deck);
            List<string[]> myHand = myDeal.Item1;
            deck = myDeal.Item2;

            //runs game
            Console.WriteLine("Welcome to Go Fish! Press ENTER to begin the game!");
            Console.ReadLine();
            while (myHand.Count > 0 && oppHand.Count > 0)
            {
                var stats = Turn(myHand, oppHand, deck, turnCounter);
                turnCounter++;
            }
            
            if(myHand.Count < 1)
            {
                Console.WriteLine("You win!! Thanks for playing :)");
            }
            else if(oppHand.Count < 1)
            {
                Console.WriteLine("You lose! Better luck next time...");
            }
            Console.ReadLine();


        }
    }
}