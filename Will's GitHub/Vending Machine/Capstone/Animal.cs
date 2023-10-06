using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public abstract class Animal
    {
           
        public virtual string Yell { get; }
        public string Name { get; private set; }
        public string Type { get; }
        public decimal Price { get; }
        public string Slot { get; }
        //public int Quantity { get; set; } = 5;
        public Animal()
        {

        }
        
        public Animal(string name)
        {
            string lineOfText = "";
            string[] properties;
            try
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\Student\\workspace\\c-sharp-minicapstonemodule1-team2\\vendingmachine.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        lineOfText = reader.ReadLine();
                        if (lineOfText.Contains(name))
                        {
                            properties = lineOfText.Split("|");
                            Name = name;
                            Type = properties[3];
                            Price = decimal.Parse(properties[2]);
                            Slot = properties[0];
                            break;
                        }
                        //else
                        //{
                        //    throw new Exception();
                        //}
                    }             
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("That animal name does not exist.");
            }
        }
    }
}
