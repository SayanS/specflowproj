using ea_pages;
using ea_tests.Hooks;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ea_tests
{
    [Binding]
    public class LoginSteps
    {

        private readonly LoginPage _loginPage;
        
        public LoginSteps(LoginPage loginPage)
        {
            _loginPage = loginPage;
            
            //ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }

        [Given(@"I have navigated to my application")]
        public void GivenIHaveNavigatedToMyApplication()
        {
            _loginPage.OpenLoginPage();          
        }
        
        [When(@"I fill login form with '(.*)' and '(.*)'")]
        public void WhenIFillLoginFormWithAdminAndAdmin(string login, string password)
        {
            _loginPage.FillLoginForm(login, password);            
        }
        
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
           _loginPage.ClickOnLoginBtn();
        }
    }
}
