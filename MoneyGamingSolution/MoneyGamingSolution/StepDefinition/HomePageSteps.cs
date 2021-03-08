using MoneyGaming.Base;
using MoneyGaming.Pages;
using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow;

namespace MoneyGaming.PageStepDefinitions
{
    [Binding]
    [Scope(Tag = "registration")]

    public class HomePageSteps
    {
        public IWebDriver _driver;
        HomePage homePage;

        public HomePageSteps()
        {
            _driver = WebDriver.GetDriver();
            homePage = new HomePage(_driver);
        }

        [Given(@"I navigate to MoneyGaming site")]
        public void GivenINevigateToMoneyGamingSite()
        {
            var moneyGamingUrl = ConfigurationManager.AppSettings["MoneyGamingURL"];
            _driver.Navigate().GoToUrl(moneyGamingUrl);
        }

        [Given(@"I click on JoinNow")]
        public void GivenIClickOnJoinNow()
        {
            homePage.ClickOnJoinNow();
        }


    }
}
