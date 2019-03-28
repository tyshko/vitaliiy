using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace HW_1_Optional_UnitTestOpenAnyWebSite
{
    public class UnitTest1
    {
        ChromeDriver chromeDriver;

        [SetUp]
        public void Init()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void TestMethod()
        {
            chromeDriver.Navigate().GoToUrl("http://facebook.com");
            var a = GetFirstLink(chromeDriver);
            if (a.Displayed && a.Enabled)
            {
                a.Click();
            }
        }

        private IWebElement GetFirstLink(ChromeDriver driver)
        {
            return driver.FindElementByXPath(".//a[1]");
        }

        [TearDown]
        public void CleanUp()
        {
            chromeDriver.Close();
        }
    }
}


