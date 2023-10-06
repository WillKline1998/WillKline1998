using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Schema;

namespace Capstone
{
    public class SalesReport
    {
        public DateTime DateAndTime { get; } = DateTime.Now;

        public Dictionary<Animal, int> Inventory { get; }





        public SalesReport(Dictionary<Animal, int> inventory)
        {
            Inventory = inventory;
        }


        public void WriteReport() // Do we need values for action & transaction as inputs?
        {
            decimal sum = 0;
            string dateAndTime = DateTime.Now.ToString("s");
            string realDateAndTime = dateAndTime.Replace(":", "-");
            using (StreamWriter writer = new StreamWriter($"C:\\Users\\Student\\workspace\\c-sharp-minicapstonemodule1-team2\\{realDateAndTime} Report.txt"))
            {
                foreach (var kvp in Inventory)
                {
                    if (kvp.Value < 5)
                    {
                        writer.WriteLine($"{kvp.Key.Name}|{5 - kvp.Value}");
                        sum += kvp.Key.Price * (5 - kvp.Value);

                    }
                }
                writer.WriteLine();
                writer.WriteLine("TOTAL SALES $" + sum);
            }
        }
    }
}
