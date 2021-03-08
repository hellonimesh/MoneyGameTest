using MoneyGaming.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace MoneyGaming.Pages
{
    public class RegistrationPage : CommonActionHelper
    {
        private IWebDriver _driver;

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void SelectTitleDropdown(string title)
        {
            SelectElementFromDropdownByText(TitleDropdown, title);
        }

        public void SubmitFirstName(string name)
        {
            SubmitText(FirstName, name);
        }

        public void SubmitSurname( string surname)
        {
            SubmitText(Surname, surname);
        }

        public void ClickOnTermsAndConditionsCheckbox()
        {
            ClickOnElement(TermsAndConditionsCheckBox);
        }

        public void VerifyTheDOBFieldErrorMessage(string errorMessage)
        {
            var dobFieldErrorMessage = DOBFieldErrorMessage.Text;
            Assert.IsTrue(dobFieldErrorMessage.Equals(errorMessage));
        }

        public void ClickOnJoinNowForm()
        {
            ClickOnElement(JoinNowBtnOnRegistrationPage);
        }

        //find element by Findsby

        [FindsBy(How = How.Id, Using = "forename")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "map(lastName)")]
        private IWebElement Surname { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        private IWebElement JoinNowBtnOnRegistrationPage { get; set; }

        [FindsBy(How = How.Id, Using = "checkbox")]
        private IWebElement TermsAndConditionsCheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "form[id='signupForm'] label[for='dob']")]
        private IWebElement DOBFieldErrorMessage { get; set; }

        [FindsBy(How = How.Id, Using = "title")]
        private IWebElement TitleDropdown { get; set; }

    }
}
