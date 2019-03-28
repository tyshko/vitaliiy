using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace HW_5_1_NUnit 
{

    [Binding]
    public class SpecFlowFeature1Steps : StepBase
    {
        private static IWebDriver driver;
        HomePage homePage = new HomePage();
        Actions actions = new Actions(driver);

        [Given(@"I navigate to main page")]
        public void GivenINavigateToMainPage()
        {
            homePage.NavigateToMainPage();
        }
        
        [When(@"I move to '(.*)'")]
        public void WhenIMoveTo(string p0)
        {

            homePage.MoveToDemoSites();
        }
        
        [When(@"click '(.*)'")]
        public void WhenClick(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the title opened page equals '(.*)'")]
        public void ThenTheTitleOpenedPageEquals(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
