using Transport.Pages.UI.Framework;

namespace Transport.Pages.UI.Objects.PageObjects
{
   public interface ITransportTripPage
    {
        bool IsTripPlannertabVisible();
        void LoadTransportTripPage();
        void EnterFromLocation(string fromLocation);
        void EnterToLocation(string toLocation);
        void SelectToLocationList(string toLocation);
        void SelectFromLocationList(string fromLocation);
        bool IsTripResultVisible();
        void ClickOnFirstTrip();
        string GetResultFirstFromLocation { get;}
        string GetResultFirstToLocation { get; }
    }

    
    public class TransportTripPage: PageObjectBase, ITransportTripPage
    {
        public TransportTripPage(ITestDriver driver)
            : base(driver)        {      }

        private static readonly string TripsPlannerRootCss = "tni-trip-planner ";
        private static readonly string TripsplannerToTabcss = TripsPlannerRootCss + "#tab-pane-tp";
        private static readonly string TripsFromLocationcss = TripsPlannerRootCss + ".location-search-container #tniFromTripLocation";
        private static readonly string TripsToLocationcss = TripsPlannerRootCss + "#tniToTripLocation";
        private static readonly string TripsToListCss = TripsPlannerRootCss + "div.autosuggest-dropdown-containerdiv listbox.autosuggest-buttons";
        private static readonly string TripsFromListCss = TripsPlannerRootCss + ".autosuggest-buttons";
        private static readonly string TripResultTabCss = TripsPlannerRootCss + "div.results .ng-star-inserted";
        private static readonly string TripResultFirstHeaderCss = TripsPlannerRootCss + "div.results .ng-star-inserted tni-trip-result .summary-header";
        private static readonly string TripResultFirstFromLocationCss = TripsPlannerRootCss + "div.results .ng-star-inserted tni-trip-result li.trip-step span.pt-leg-from__label div";
        private static readonly string TripResultFirstToLocationCss = TripsPlannerRootCss + "div.results .ng-star-inserted tni-trip-result li.trip-step span.pt-leg-to__label";

        public bool IsTripPlannertabVisible()
        {
           return Driver.IsVisibleByCss(TripsplannerToTabcss);
        }
        
        public void LoadTransportTripPage()
        {
            Driver.NavigateTo("https://transportnsw.info/trip#/trip");
        }

        public void EnterFromLocation(string fromLocation)
        {
            Driver.EnterTextByCss(TripsFromLocationcss, fromLocation);
        }

        public void EnterToLocation(string toLocation)
        {
            Driver.EnterTextByCss(TripsToLocationcss, toLocation);
        }

        public void SelectToLocationList(string toLocation)
        {
            Driver.SelectValueFromDropdownbyIndex(TripsToListCss, toLocation);
        }
        public void SelectFromLocationList(string fromLocation)
        {
            Driver.SelectValueFromDropdownbyIndex(TripsFromListCss, fromLocation);
        }

        public bool IsTripResultVisible()
        {
            return Driver.IsVisibleByCss(TripResultTabCss);
        }

        public void ClickOnFirstTrip()
        {
            Driver.ClickByCss(TripResultFirstHeaderCss);
        }
        public string GetResultFirstFromLocation
        {
            get { return Driver.GetTextByCss(TripResultFirstFromLocationCss); }
        }
        public string GetResultFirstToLocation
        {
            get { return Driver.GetTextByCss(TripResultFirstToLocationCss); }
        }
    }

    public abstract class PageObjectBase
    {
        protected ITestDriver Driver { get; set; }

        protected PageObjectBase(ITestDriver driver)
        {
            Driver = driver;
        }
    }

}
