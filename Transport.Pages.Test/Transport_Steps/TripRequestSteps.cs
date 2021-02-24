using TechTalk.SpecFlow;
using Transport.Pages.UI.Objects.PageObjects;

namespace Transport_Pages_UI_Test.Transport_Steps
{
    [Binding]
    public class TripRequestSteps
    {
        //string transporturl = "https://transportnsw.info/trip#/trip";
        //IWebDriver driver = new ChromeDriver();
        [Given(@"I launch Transport NSW Trip page")]
        public void GivenILaunchTransportNSWTripPage()
        {
            AllPages.TransportTripPage.LoadTransportTripPage();
            //driver.Url = transporturl;
            //driver.Manage().Window.Maximize();
        }
        
        [Given(@"I enter Parramatta location in the trip planner module")]
        public void GivenIEnterParramattaLocationInTheTripPlannerModule()
        {
            //IWebElement fromtrip = driver.FindElement(By.Id(""));
            //fromtrip.SendKeys("from");
            //fromtrip.Click();
        }
        
        [Given(@"I enter Sydney location in the trip planner module")]
        public void GivenIEnterSydneyLocationInTheTripPlannerModule()
        {
            //IWebElement totrip = driver.FindElement(By.Id(""));
            //totrip.SendKeys("");
            //totrip.Click();
        }
        
        [Then(@"I should see the valid trip details displayed in the table")]
        public void ThenIShouldSeeTheValidTripDetailsDisplayedInTheBelowList()
        {
            
        }
    }
}
