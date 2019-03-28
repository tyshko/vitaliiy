using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_5_1_NUnit
{
    public class HomePage : Browser
    {
        Actions actions = new Actions(Driver);

        [FindsBy(How = How.XPath, Using = "//span[@class='menu-text' and contains(text(),'DEMO SITES')]")]
        public IWebElement DemoSites { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='menu-text' and contains(text(),'Automation Practice Switch Windows')]")]
        public IWebElement autPracSwitWind { get; set; }


        [FindsBy(How = How.XPath, Using = ".//button[contains(text(),'New Browser Tab')]")]
        public IWebElement buttonNewTab { get; set; }

        public HomePage(IWebDriver driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public HomePage()
        {
        }

        public void NavigateToMainPage()
        {
            Driver.Navigate().GoToUrl("http://toolsqa.com");
        }

        public void MoveToDemoSites()
        {
            actions.MoveToElement(DemoSites).Perform();

        }
        public void Wait4Seconds()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        }

    }
}
