using MoneyGaming.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace MoneyGaming.Pages
{
    public class HomePage : CommonActionHelper
    {

        private IWebDriver _driver;

        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void ClickOnJoinNow()
        {
            ClickOnElement(JoinNowBtn);
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='login_links'] a[class*='newUser']")]
        private IWebElement JoinNowBtn { get; set; }
    }
}
