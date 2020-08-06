using OpenQA.Selenium;
using System.Collections.Generic;

namespace NUnitTestAutomation.PageObjects
{
    public class GooglePage
    {
        private readonly IWebDriver driver;

        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By inputFieldKey = By.Name("q");
        private By searchButtonKey = By.Name("btnK");
        private By toolsButtonKey = By.CssSelector(".hdtb-tl");
        private By filterOptionKey = By.CssSelector("div.hdtb-td-o div.hdtb-mn-hd");
        private By lastWeekOptionKey = By.Id("qdr_w");
        private By searchResultTitleKey = By.CssSelector("div.g h3");

        public IWebElement GetInputField()
        {
            return driver.FindElement(inputFieldKey);
        }

        public IWebElement GetSearchButton()
        {
            return driver.FindElement(searchButtonKey);
        }

        public IWebElement GetToolsButton()
        {
            return driver.FindElement(toolsButtonKey);
        }

        public IList<IWebElement> GetFilterOptions()
        {
            return driver.FindElements(filterOptionKey);
        }

        public IWebElement GetLastWeekOption()
        {
            return driver.FindElement(lastWeekOptionKey);
        }

        public IWebElement GetFirstResultTitle()
        {
            return driver.FindElements(searchResultTitleKey)[0];
        }
    }
}