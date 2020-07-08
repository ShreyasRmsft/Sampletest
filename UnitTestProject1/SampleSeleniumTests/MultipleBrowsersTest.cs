using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace SampleSeleniumTests
{
    [TestClass]
    public class MultipleBrowsersTest : SeleniumTestBase
    {
        [Ignore]
        [TestMethod]
        public void ChromeTest()
        {
            GoogleTest(new ChromeDriver());
        }

        [TestMethod]
        public void FirefoxTest()
        {
            GoogleTest(new FirefoxDriver());
        }

        [Ignore]
        [TestMethod]
        public void IETest()
        {
            GoogleTest(new InternetExplorerDriver());
        }
    }
}
