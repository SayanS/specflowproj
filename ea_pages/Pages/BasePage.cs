using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace ea_pages.Pages
{
    public abstract class BasePage
    {
        private protected readonly IWebDriver _webDriver;
        public const string BASE_URL = "http://www.executeautomation.com/demosite/";
        public BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            PageFactory.InitElements(_webDriver, this);
        }

        public string GetUrl()
        {
            return  _webDriver.Url;
        }
    }
}
