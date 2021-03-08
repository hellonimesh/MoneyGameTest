using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MoneyGaming.Base
{
    [Binding]
    public static class WebDriver
    {

        public static IWebDriver driver;
        private static string driverOption = "chrome";


        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                SetDriver();
            }
            return driver;
        }

        public static IWebDriver SetDriver()
        {
            driver = null;

            if (driverOption == "chrome")
            {
                driver = new ChromeDriver();
            }

            driver.Manage().Cookies.DeleteAllCookies();

            driver.Manage().Window.Maximize();

            return driver;
        }

        [After]
        public static void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Close();
            }
        }

    }

}
