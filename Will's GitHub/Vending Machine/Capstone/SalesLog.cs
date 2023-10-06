using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Capstone
{
    public class SalesLog
    {
        public DateTime DateAndTime { get; } = DateTime.Now;
        public string Action { get; set; }
        public decimal Transaction { get; set; }
        public decimal Balance { get; }

        public SalesLog(string action, decimal transaction, decimal balance)
        {
            Action = action;
            Transaction = transaction;
            Balance = balance;
        }

        public void WriteLog() // Do we need values for action & transaction as inputs?
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Student\workspace\c-sharp-minicapstonemodule1-team2\log.txt", true))
            {
                writer.WriteLine($"{DateAndTime} {Action} ${Transaction} ${Balance}");
            }
        }
    }
}
