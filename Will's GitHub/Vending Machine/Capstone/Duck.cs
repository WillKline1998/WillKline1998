using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Duck : Animal
    {
        public override string Yell { get; } = "Quack, Quack, Splash!";
        public Duck(string name) : base(name)
        {

        }
    }
}
