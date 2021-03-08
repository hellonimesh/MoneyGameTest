using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace MoneyGaming.Base
{
    public class CommonActionHelper
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        public CommonActionHelper(IWebDriver Driver)
        {
            driver = Driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public bool ClickOnElement(IWebElement element)
        {

            try
            {
                VerifyThePresenceOfAnElement(element);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                element.Click();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("not able to clik on element " + e.Message);
                return false;
            }
        }

        public bool VerifyThePresenceOfAnElement(IWebElement element)
        {
            try
            {
                return wait.Until(driver => element.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("element is not displyed " + e.Message);
                return false;
            }
        }

        public bool SubmitText(IWebElement element , string text)
        {
            try
            {
                VerifyThePresenceOfAnElement(element);
                element.SendKeys(text);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("element is not displyed " + e.Message);
                return false;
            }
        }

        public bool SelectElementFromDropdownByText(IWebElement element, string text)
        {
            try
            {
                VerifyThePresenceOfAnElement(element);
                SelectElement selectElement = new SelectElement(element);
                selectElement.SelectByText(text);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while selecting an element :" + e.Message);
                return false;
            }
        }
    }
}
