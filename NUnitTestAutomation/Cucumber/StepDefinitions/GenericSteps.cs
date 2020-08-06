using TechTalk.SpecFlow;
using NUnitTestAutomation.Modules;
using OpenQA.Selenium;

namespace NUnitTestAutomation.StepDefinitions
{
    [Binding]
    public class GenericSteps
    {
        private readonly IWebDriver driver;
        private readonly GenericModule genericModule;

        public GenericSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.genericModule = new GenericModule(driver);
        }

        [Given(@"User opens ""(.*)"" page")]
        public void OpenGoogleSearchPage(string url)
        {
            genericModule.OpenPage(url);
        }

        [Then(@"page with ""(.*)"" domain name is opened")]
        public void CheckDomainName(string domainName)
        {
            genericModule.CheckDomainName(domainName);
        }
    }
}