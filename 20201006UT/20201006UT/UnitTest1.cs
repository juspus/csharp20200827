using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace _20201006UT
{
    [TestClass]
    public class UnitTest1
    {
        int ExpectedValue = 5;
        int TestMethod1ExpectedValue = 10;
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(TestMethod1ExpectedValue, Program.Sudetis(2,8));
        }
        [TestMethod]
        public void TestMethod()
        {            
            Assert.AreEqual(ExpectedValue, Program.Sudetis(2, 3));
        }
    }
}
