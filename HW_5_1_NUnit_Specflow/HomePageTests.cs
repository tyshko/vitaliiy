using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_1_NUnit
{
    [TestFixture]
    class HomePageTests
    {
        IWebDriver driver = Browser.Driver;

        [Test]
        public void VerifyTitle()
        {

            HomePage homePage = new HomePage(driver);
            driver.Manage().Window.Maximize();
            homePage.NavigateToMainPage();
            Actions actions = new Actions(driver);

            PageFactory.InitElements(driver, homePage);

            homePage.NavigateToMainPage();
            homePage.Wait4Seconds();
            actions.MoveToElement(homePage.DemoSites).Perform();
            homePage.Wait4Seconds();
            actions.MoveToElement(homePage.autPracSwitWind).Perform();
            homePage.autPracSwitWind.Click();
            homePage.Wait4Seconds();
            homePage.buttonNewTab.Click();
            homePage.Wait4Seconds();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            Assert.AreEqual(driver.Title, "QA Automation Tools Tutorial");

            driver.Quit();

        }

    }
}
