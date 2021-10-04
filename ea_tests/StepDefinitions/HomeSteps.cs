using ea_pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ea_tests.StepDefinitions
{
    [Binding]
    public class HomeSteps
    {
        private readonly UserFormPage _userFormPage;
        
        public HomeSteps(UserFormPage userFormPage)
        {
            _userFormPage = userFormPage;
        }

        [Then(@"EA page should be opened with URL'(.*)'")]
        public void ThenEAPageShouldBeOpenedWithURL(string expectedUrl)
        {
            Assert.That(_userFormPage.GetUrl(), Does.StartWith(expectedUrl));
        }
        
        [Then(@"EA page should has title '(.*)'")]
        public void ThenEAPageShouldHasTitle(string expectedTitle)
        {
            Assert.That(_userFormPage.GetPageTitle(), Is.EqualTo(expectedTitle));
        }
    }
}
