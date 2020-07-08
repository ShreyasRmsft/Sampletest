using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace SampleSeleniumTests
{
    [TestClass]
    public class DataDrivenTest : SeleniumTestBase
    {
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "browsers.csv", "browsers#csv", DataAccessMethod.Sequential)]
        public void DDMultiBrowserTest()
        {
            var browser = (string)TestContext.DataRow[0];

            switch (browser)
            {
                case "Chrome":
                    GoogleTest(new ChromeDriver());
                    break;
                case "Firefox":
                    GoogleTest(new FirefoxDriver());
                    break;
                case "IE":
                    GoogleTest(new InternetExplorerDriver());
                    break;
                default:
                    break;
            }
        }

        public TestContext TestContext { get; set; }
    }
}
