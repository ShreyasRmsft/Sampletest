using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlakyTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private static int _value = 0;

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_value %2 == 0);
            _value++;
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(_value %2 == 0);
            _value++;
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(_value %2 == 0);
            _value++;
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(_value %2 == 0);
            _value++;
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Always pass
        }

        [TestMethod]
        public void TestMethod6()
        {
            //Always pass
        }
    }
}
