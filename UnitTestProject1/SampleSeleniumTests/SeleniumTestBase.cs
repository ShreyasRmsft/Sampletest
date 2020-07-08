using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SampleSeleniumTests
{
    public class SeleniumTestBase
    {
        internal void GoogleTest(IWebDriver driver)
        {
            try
            {
                driver.Navigate().GoToUrl("http://www.google.com/");
            }
            finally
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
