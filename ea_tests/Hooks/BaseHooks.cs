using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ea_tests.Hooks
{
    [Binding]
        class BaseHooks
    {

        private readonly IObjectContainer objectContainer;
        
        private IWebDriver _webDriver;
        public BaseHooks(IObjectContainer objectContainer)
        {
        this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            _webDriver.Manage().Window.Maximize();
            objectContainer.RegisterInstanceAs<IWebDriver>(_webDriver);
        }      

        [AfterScenario]
        public void RunAfterScenario()
        {
            _webDriver?.Quit();
        }
    }
}
