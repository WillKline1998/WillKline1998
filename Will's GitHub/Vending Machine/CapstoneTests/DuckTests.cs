using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone;

namespace CapstoneTests
{
    [TestClass()]
    public  class DuckTests
    { 
        [TestMethod()]
        public void DuckConstruct()
        {
            Duck testDuck = new Duck("Cube Duck");
            string expectedSlot = "A2";
            string actualSlot = testDuck.Slot;
            Assert.AreEqual(expectedSlot, actualSlot);
        }


    
    }
}
