using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeBasedSlicingProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Threading.Thread.Sleep(21 * 1000);
        }

        [TestMethod]
        public void TestMethod2()
        {
            System.Threading.Thread.Sleep(21 * 1000);
        }

        [TestMethod]
        public void TestMethod3()
        {
            System.Threading.Thread.Sleep(21 * 1000);
        }
    }
}
