using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, Priority(0), Owner("test")]
        public void PassingTest()
        {
            Assert.IsTrue(true, "It shouldn't fail");
        }

        [TestMethod, Priority(2), Owner("test")]
        public void TestRunParameterTest()
        {
            Assert.AreEqual("DataSource=tcp:ServerName.database.windows.net,1433;InitialCatalog=DatabaseName", this.TestContext.Properties["connectionString"], "Test run parameter not overridden. Should fail unless overridden");
        }

        [TestMethod]
        public void TestRunParameterOverrideParam1Value()
        {
            Assert.AreEqual("OverrideParam1Value", this.TestContext.Properties["param1"], "Value for param1 doesnt match the expected overriden value : OverrideParam1Value");
        }

        [TestMethod]
        public void TestRunParameterNoOverrideParam2Value()
        {
            Assert.AreEqual("Param2Value", this.TestContext.Properties["param2"], "Value for param2 doesnt match the expected original value : Param2Value");
        }

        [TestMethod, Priority(0), Owner("test")]
        [Ignore]
        public void IgnoredTest()
        {
            Assert.IsTrue(false, "This shouldn't be executed");
        }

        [TestMethod, Priority(3), Owner("test")]
        public void P3Test()
        {
            Assert.IsTrue(true, "Testing with Priority");
        }

        [TestMethod, Priority(2), Owner("test"), TestCategory("TestCat")]
        public void TestCategoryTest()
        {
            Assert.IsTrue(true, "Testing with some category");
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.IsTrue(true, "Another simple test which throws exception");
            throw new Exception("Some random exception");
        }

        public TestContext TestContext { get; set; }
    }
}
