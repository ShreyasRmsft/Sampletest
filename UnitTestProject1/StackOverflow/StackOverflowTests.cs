using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackOverflow
{
    [TestClass]
    public class StackOverflowTests
    {
        [TestMethod]
        public void RecusiveTest()
        {
            Recursive(780000000);
        }

        private void Recursive(int v)
        {
            Console.WriteLine(v);
            Recursive(++v);
        }
    }
}
