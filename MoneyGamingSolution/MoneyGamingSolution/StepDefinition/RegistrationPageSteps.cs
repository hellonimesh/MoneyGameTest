using MoneyGaming.Base;
using MoneyGaming.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MoneyGaming.PageStepDefinitions
{
    [Binding]
    public class RegistrationPageSteps
    {
        IWebDriver _driver;
        RegistrationPage registrationPage;

        public RegistrationPageSteps()
        {
            _driver = WebDriver.GetDriver();
            registrationPage = new RegistrationPage(_driver);
        }

        [Given(@"I enter the (.*) (.*) and (.*)")]
        public void GivenIEnterThe(string title, string name, string surname)
        {
            registrationPage.SelectTitleDropdown(title);
            registrationPage.SubmitFirstName(name);
            registrationPage.SubmitSurname(surname);
        }

        [Given(@"I accept the Terms and Conditions")]
        public void GivenIAcceptTheTermsAndConditions()
        {
            registrationPage.ClickOnTermsAndConditionsCheckbox();
        }

        [When(@"I submit the details")]
        public void WhenISubmitTheDetails()
        {
            registrationPage.ClickOnJoinNowForm();
        }

        [Then(@"I verify the (.*)")]
        public void ThenIVerifyThe(string errorMessage)
        {
            registrationPage.VerifyTheDOBFieldErrorMessage(errorMessage);
        }

    }
}
