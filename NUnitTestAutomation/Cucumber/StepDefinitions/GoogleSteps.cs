using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnitTestAutomation.Modules;

namespace NUnitTestAutomation.StepDefinitions
{
    [Binding]
    public class GoogleSteps
    {
        private readonly IWebDriver driver;
        private readonly GoogleModule googleModule;


        public GoogleSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.googleModule = new GoogleModule(driver);
        }

        [When(@"User searches for ""(.*)""")]
        public void Search(string inputText)
        {
            googleModule.Search(inputText);
        }

        [When(@"User applies last week time filter")]
        public void ApplyLastWeekTimeFilter()
        {
            googleModule.ApplyLastWeekTimeFilter();
        }

        [When(@"User clicks on top result")]
        public void ClickTopResult()
        {
            googleModule.ClickTopResult();
        }
    }
}