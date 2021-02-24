using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Transport.Pages.UI.Framework
{
    public class SeleniumDriver : SeleniumDriverBase, ITestDriver
    {
        public SeleniumDriver(IWebDriver webdriver)
            : base(webdriver) { }
        public bool IsVisibleByCss(string cssSelector)
        {
            Driver.FindElement(By.CssSelector(cssSelector));
            return true;
                       
        }
        public void ClickByCss(string cssSelector)
        {
            Driver.FindElement(By.CssSelector(cssSelector)).Click();
        }
        public void EnterTextByCss(string cssSelector, string text)
        {
            Driver.FindElement(By.CssSelector(cssSelector)).SendKeys(text);
            Driver.FindElement(By.CssSelector(cssSelector)).SendKeys(Keys.Tab);
        }
        public string GetTextByCss(string cssSelector)
        {
            return Driver.FindElement(By.CssSelector(cssSelector)).Text;
        }

        public void SelectValueFromDropdownbyIndex(string cssSelector, string value)
        {
            var css = Driver.FindElement(By.CssSelector(cssSelector));
            new SelectElement(css).SelectByText(value); 
        }

        public void Tab()
        {
            //TODO
        }

    }

    public abstract class SeleniumDriverBase
    {
        private readonly IWebDriver _driver;
        protected SeleniumDriverBase(IWebDriver webdriver)
        { _driver = webdriver; }

        protected IWebDriver Driver
        { get { return _driver; } }
        public void NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}
