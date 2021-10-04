using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
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
        public void InitializeWebDriver(TestContext testContext)
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            _webDriver.Manage().Window.Maximize();
            objectContainer.RegisterInstanceAs<IWebDriver>(_webDriver);
            int i = 0;
        }      

        [AfterScenario]
        public void RunAfterScenario(TestContext testContext, ScenarioContext scenarioContext,
            FeatureContext featureContext)
        {
            _webDriver?.Quit();
            Console.WriteLine(testContext.Result.StackTrace);
        }
    }
}
