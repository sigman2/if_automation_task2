using OpenQA.Selenium;
using NUnitTestAutomation.PageObjects;

namespace NUnitTestAutomation.Modules
{
    public class GoogleModule
    {
        private readonly IWebDriver driver;
        private readonly GooglePage googlePage;

        public GoogleModule(IWebDriver driver)
        {
            this.driver = driver;
            this.googlePage = new GooglePage(driver);
        }

        public void Search(string inputText)
        {
            googlePage.GetInputField().SendKeys(inputText);
            googlePage.GetSearchButton().Click();
        }

        public void filterLastWeekResults()
        {
            // Workaround to click time filter option - while showing options other elements might receive click.
            // Could also implement while loop with try - catch block to try multiple times for certain amount of time.
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click()", googlePage.GetFilterOptions()[1]);
            // googlePage.getFilterOptions()[1].Click();

            googlePage.GetLastWeekOption().Click();
        }

        public void ApplyLastWeekTimeFilter()
        {
            googlePage.GetToolsButton().Click();
            filterLastWeekResults();
        }

        public void ClickTopResult()
        {
            googlePage.GetFirstResultTitle().Click();
        }
    }
}