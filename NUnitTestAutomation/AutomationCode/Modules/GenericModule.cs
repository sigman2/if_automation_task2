using FluentAssertions;
using OpenQA.Selenium;

namespace NUnitTestAutomation.Modules
{
    public class GenericModule
    {
        private readonly IWebDriver driver;

        public GenericModule(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CheckDomainName(string domainName)
        {
            driver.Url.Should().Contain(domainName);
        }
    }
}