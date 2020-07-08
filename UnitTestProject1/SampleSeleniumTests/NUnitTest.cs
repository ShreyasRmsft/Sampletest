using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace SampleSeleniumTests
{
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(InternetExplorerDriver))]
    public class NUnitTests<TWebDriver> : SeleniumTestBase where TWebDriver : IWebDriver, new()
    {
        // todo : Bug 240089:vstest is not able to discover nunit tests
        //[Test]
        //public void NUnitMultiBrowserTest()
        //{
        //    GoogleTest(new TWebDriver());
        //}
    }
}