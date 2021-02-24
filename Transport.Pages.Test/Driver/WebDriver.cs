using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Pages.UI.Test.Driver
{
    public class WebDriver
    {
        public static IWebDriver Driver { get; set; }

        public static void ConfigureDriver()
        {
            try
            {
                Driver = new ChromeDriver();
            }
            catch
            {
                cleanup();
            }
        }

        public static void cleanup()
        {
            Console.WriteLine("Clean up process started");
            var driver = Driver;
            Driver = null;
            if(driver != null)
            {
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Quit();
                driver.Dispose();
            }
        }

    }
}
