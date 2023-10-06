using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Cat : Animal
    {
        public override string Yell { get; } = "Meow, Meow, Meow!";
        public Cat(string name) : base(name)
        {

        }
    }
}
