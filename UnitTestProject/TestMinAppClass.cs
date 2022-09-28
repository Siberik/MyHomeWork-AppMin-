using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinApp;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestMinAppClass
    {
        [TestMethod]
        public void TestMin()
        {
            int min;
            min = Program.Min(3,4,5);
            Assert.AreEqual(3, min);
        }
    }
}
