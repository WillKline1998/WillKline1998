using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.IO;
using System.Linq;
using System;

namespace CapstoneTests
{
    [TestClass()]
    public class SalesLogTests
    {
        [TestMethod()]
        public void HappyPathTest()
        {
            SalesLog salesLogTest = new SalesLog("testLog", 2.0M, 2.0M);
            string lastLine = null ;
            salesLogTest.WriteLog();
            using (StreamReader sr = new StreamReader(@"C:\Users\Student\workspace\c-sharp-minicapstonemodule1-team2\log.txt"))
            {
                lastLine = File.ReadLines(@"C:\Users\Student\workspace\c-sharp-minicapstonemodule1-team2\log.txt").Last();
            }

            var stringExpected = $"{DateTime.Now} testLog $2.0 $2.0";
            Assert.AreEqual(stringExpected, lastLine);

        }
    }
}
