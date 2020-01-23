using ea_pages.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;

namespace ea_pages
{
    [Binding]
    public class UserFormPage:BasePage
    {
        // private readonly IWebDriver _webDriver;

        [FindsBy(How = How.XPath, Using = "//h1")]
        protected IWebElement Title { get; set; }

        public UserFormPage(IWebDriver webDriver):base(webDriver)
        {
           // _webDriver = webDriver;
        }

        public string GetPageTitle()
        {
            return Title.Text;
        }
    }
}
