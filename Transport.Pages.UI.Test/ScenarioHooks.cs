using TechTalk.SpecFlow;
using Transport.Pages.UI.Test.Driver;
using OpenQA.Selenium;
using Transport.Pages.UI.Framework;
using Transport.Pages.UI.Objects.PageObjects;

namespace Transport_Pages_UI_Test
{
    [Binding]
    public sealed class ScenarioHooks
    {
        static IWebDriver webdriver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriver.ConfigureDriver();
            var webdriver = WebDriver.Driver;
            webdriver.Navigate().GoToUrl("about:blank");
            webdriver.Manage().Window.Maximize();
            var testdriver = new SeleniumDriver(webdriver);
            AllPages.Loadpages(testdriver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.cleanup();
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
