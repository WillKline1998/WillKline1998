using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Penguin : Animal
    {
        public override string Yell { get; } = "Squawk, Squawk, Whee!";
        public Penguin(string name) : base(name)
        {

        }
    }
}
