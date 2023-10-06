using System;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Vending vendingMachine = new Vending();
            vendingMachine.FillStock();
            string welcomeResponse;
            string purchaseResponse;
            do
            {
                welcomeResponse = vendingMachine.DisplayWelcomeMenu();
                if (welcomeResponse == "1")
                {
                    vendingMachine.DisplayStock();
                }
                if (welcomeResponse == "2")
                {
                    do
                    {
                        purchaseResponse = vendingMachine.DisplayPurchaseMenu();
                        if (purchaseResponse == "1")
                        {
                            vendingMachine.FeedMoney();
                        }
                        else if (purchaseResponse == "2")
                        {
                            vendingMachine.SelectProduct();
                        }
                        else
                        {
                            vendingMachine.FinishTransaction();
                        }
                    } while (purchaseResponse != "3");
                }
                if (welcomeResponse == "3")
                {
                    break;
                }
                if( welcomeResponse == "4")
                {
                    vendingMachine.CreateSalesReport();
                }
            } while (welcomeResponse != "3");
        }
    }
}
