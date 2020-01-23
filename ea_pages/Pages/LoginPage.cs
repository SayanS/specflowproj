using ea_pages.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ea_pages
{
    [Binding]
    public class LoginPage : BasePage
    {
        // private readonly IWebDriver _webDriver;        

        [FindsBy(How = How.Name, Using = "UserName")]
        protected IWebElement UsernameTxtBox { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        protected IWebElement PasswordTxtBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='Login']")]
        protected IWebElement LoginBtn { get; set; }

        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public LoginPage OpenLoginPage()
        {
            _webDriver.Navigate().GoToUrl($"{BASE_URL}Login.html");
            PageFactory.InitElements(_webDriver, this);
            return this;
        }

        public LoginPage FillLoginForm(string username, string password)
        {
            UsernameTxtBox.SendKeys(username);
            PasswordTxtBox.SendKeys(password);
            return this;
        }

        public UserFormPage ClickOnLoginBtn()
        {
            LoginBtn.Click();
            return new UserFormPage(_webDriver);
        }

        //private T GetPage<T>() where T : new()
        //{
        //    var page = new T();
        //    PageFactory.InitElements(_webDriver, page);
        //    return page;
        //}
    }
}
