using Shouldly;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Transport.Pages.UI.Objects.PageObjects;
using Transport.Pages.UI.Test.Driver;

namespace Transport_Pages_UI_Test.Transport_Steps
{
    [Binding]
    public class TripRequestSteps
    {
        [Given(@"I launch Transport NSW Trip page")]
        public void GivenILaunchTransportNSWTripPage()
        {
            AllPages.TransportTripPage.LoadTransportTripPage();
        }

        [Given(@"I enter ""(.*)"" (.*) in the trip planner module")]
        public void GivenIEnterParramattaLocationInTheTripPlannerModule(string flag, string location)
        {
            AllPages.TransportTripPage.IsTripPlannertabVisible().ShouldBe(true, "Trip planner tab not displayed correctly");
            if(flag.ToLower() == "from")
            {
                AllPages.TransportTripPage.EnterFromLocation(location);
            }
            else if (flag.ToLower() == "to")
            {
                AllPages.TransportTripPage.EnterToLocation(location);
                         
                // System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
            }
        }
        
        
        [Then(@"I should see the valid trip details displayed in the table")]
        public void ThenIShouldSeeTheValidTripDetailsDisplayedInTheBelowList()
        {
            AllPages.TransportTripPage.IsTripResultVisible().ShouldBe(true, "Trip result not visible");
            WebDriver.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            AllPages.TransportTripPage.ClickOnFirstTrip();
            WebDriver.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var FirstLocation = AllPages.TransportTripPage.GetResultFirstFromLocation;
            FirstLocation.ShouldBe("North Sydney Station, Platform 1, North Sydney");
            WebDriver.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var DestinationLocation = AllPages.TransportTripPage.GetResultFirstToLocation;
            DestinationLocation.ShouldContain("Town Hall Station, Platform 2, Sydney");         
        }
    }
}
