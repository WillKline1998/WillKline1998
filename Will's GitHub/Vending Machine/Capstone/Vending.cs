using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Vending
    {
        public decimal Balance { get; set; } = 0;
        public Dictionary<Animal, int> stockOfAnimals = new Dictionary<Animal, int>();
        public bool isDone = false;
        public int OverallStock
        {
            get
            {
                int sum = 0;
                foreach(var kvp in stockOfAnimals)
                {
                    sum += kvp.Value;
                }
                return sum;
            }
        }
       
        public Vending()
        {

        }

        public string DisplayWelcomeMenu()
        {
            Console.WriteLine("(1) Display Vending Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Enter choice: ");
                
                string userInput = Console.ReadLine();
                Console.WriteLine();
                if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
                {
                    Console.WriteLine("Invalid entry. Please select from the number options.");
                }
                else
                {
                    return userInput;
                }
            }
        }
        public void CreateSalesReport()
        {
            SalesReport newReport = new SalesReport(stockOfAnimals);
            newReport.WriteReport();

        }

        public string DisplayPurchaseMenu()
        {
            Console.WriteLine("Current Money Provided: $" + Balance);
            Console.WriteLine();
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Enter choice: ");
                
                    
                string userInput = Console.ReadLine();
                Console.WriteLine();
                if (userInput != "1" && userInput != "2" && userInput != "3")
                {
                    Console.WriteLine("Invalid entry. Please select from the number options.");
                }
                else
                {
                    return userInput;
                }
            }
        }
        
        public void FillStock()
        {
            Animal yellowDuck = new Duck("Yellow Duck");
            Animal cubeDuck = new Duck("Cube Duck");
            Animal beachDuck = new Duck("Beach Duck");
            Animal batDuck = new Duck("Bat Duck");
            Animal emperorPenguin = new Penguin("Emperor Penguin");
            Animal macaroniPenguin = new Penguin("Macaroni Penguin");
            Animal rockhopperPenguin = new Penguin("Rockhopper Penguin");
            Animal galapagosPenguin = new Penguin("Galapagos Penguin");
            Animal blackCat = new Cat("Black Cat");
            Animal whiteCat = new Cat("White Cat");
            Animal tabbyCat = new Cat("Tabby Cat");
            Animal calicoCat = new Cat("Calico Cat");
            Animal unicornPony = new Pony("Unicorn Pony");
            Animal pegasusPony = new Pony("Pegasus Pony");
            Animal horse = new Pony("Horse");
            Animal rainbowHorse = new Pony("Rainbow Horse");

            stockOfAnimals.Add(yellowDuck, 5);
            stockOfAnimals.Add(cubeDuck, 5);
            stockOfAnimals.Add(beachDuck, 5);
            stockOfAnimals.Add(batDuck, 5);
            stockOfAnimals.Add(emperorPenguin, 5);
            stockOfAnimals.Add(macaroniPenguin, 5);
            stockOfAnimals.Add(rockhopperPenguin, 5);
            stockOfAnimals.Add(galapagosPenguin, 5);
            stockOfAnimals.Add(blackCat, 5);
            stockOfAnimals.Add(whiteCat, 5);
            stockOfAnimals.Add(tabbyCat, 5);
            stockOfAnimals.Add(calicoCat, 5);
            stockOfAnimals.Add(unicornPony, 5);
            stockOfAnimals.Add(pegasusPony, 5);
            stockOfAnimals.Add(horse, 5);
            stockOfAnimals.Add(rainbowHorse, 5);
        }

        public void DisplayStock()
        {
            foreach (var kvp in stockOfAnimals)
            {
                Console.WriteLine($"{kvp.Key.Slot} {kvp.Key.Name} | Price: ${kvp.Key.Price} | {kvp.Value} remaining");
            }
            Console.WriteLine();
        }

        public void FeedMoney()
        {
            int moneyFed = 0;
            Console.WriteLine("Please insert money in whole dollar amounts.");
            while (true)
            {
                string userResponse = Console.ReadLine();
                if (!int.TryParse(userResponse, out moneyFed) || moneyFed < 0)
                {
                    Console.WriteLine("Please insert whole dollar amounts");
                }
                else
                {
                    break;
                }
            }
            Balance += moneyFed;
            SalesLog logItem = new SalesLog("FEED MONEY:", moneyFed, Balance);
            logItem.WriteLog();
        }

        public void SelectProduct()
        {
           
            DisplayStock();
            Console.WriteLine("Select a product by typing the slot location.");
            string userSelection = Console.ReadLine().ToUpper();
            bool isGoodToGo = false;
            Animal selection = null;
            foreach (var kvp in stockOfAnimals)
            {
                if (userSelection == kvp.Key.Slot)
                {
                    if(kvp.Value > 0)
                    {
                        isGoodToGo = true;
                        selection = kvp.Key;
                    }
                    else
                    {
                        Console.WriteLine("Item is out of stock.");
                        return;
                    }
                }
            }
            if (isGoodToGo == false)
            {
                Console.WriteLine("That slot location does not exist. Please enter a valid slot.");
                return;
            }
            if (Balance < selection.Price)
            {
                Console.WriteLine("Please feed more money into the machine.");
                return;
            }
            else
            {
                Balance -= selection.Price;
                string action = selection.Name + " " + selection.Slot;
                SalesLog logItem = new SalesLog(action, selection.Price, Balance);
                logItem.WriteLog();
                Console.WriteLine($"{selection.Name} purchased for ${selection.Price}. Balance remaining: ${Balance}");
                Console.WriteLine(selection.Yell);
                stockOfAnimals[selection]--; // Not sure if this works to decrement stock of item.
            }
        }

        public void FinishTransaction()
        {
            decimal changeDue = Balance;
            int balanceInCents = (int)(Balance * 100);
            int numQuarters = balanceInCents / 25;
            balanceInCents -= numQuarters * 25;
            int numDimes = balanceInCents / 10;
            balanceInCents -= numDimes * 10;
            int numNickels = balanceInCents / 5;
            balanceInCents -= numNickels * 5;
            Balance = balanceInCents;

            SalesLog logItem = new SalesLog("GIVE CHANGE:", changeDue, balanceInCents);
            logItem.WriteLog();
            Console.WriteLine("Your change is $" + changeDue);
            Console.WriteLine($"Number of quarters: {numQuarters}");
            Console.WriteLine($"Number of dimes: {numDimes}");
            Console.WriteLine($"Number of nickels: {numNickels}");
        }
    }
}
