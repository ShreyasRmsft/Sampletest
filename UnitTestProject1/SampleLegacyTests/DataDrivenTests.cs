using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SampleLegacyTests
{
    /// <summary>
    /// Canned test class to validate Data Driven test scenarios
    /// </summary>
    [TestClass]
    public   class DataDrivenTests
    {
        [DeploymentItem("TestData.xml"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData.xml", "Item", DataAccessMethod.Sequential), TestMethod]
        public void DataDrivenTest()
        {
            TestContext.WriteLine("{0} {1}", TestContext.DataRow["Name"], TestContext.DataRow["Number"]);
            Assert.IsTrue(System.Diagnostics.Process.GetCurrentProcess().ProcessName.IndexOf("QTagent", StringComparison.OrdinalIgnoreCase) >= 0, "this test will pass only when it runs in legacy mode");          
        }

        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }
        private TestContext _testContextInstance;
    }
}
