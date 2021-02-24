using Transport.Pages.UI.Framework;

namespace Transport.Pages.UI.Objects.PageObjects
{
    public static class AllPages
    {
        private static ITestDriver _driver;
        public static ITransportTripPage TransportTripPage { get; private set; }
        
        public static void Loadpages(ITestDriver driver)
        {
            TransportTripPage = new TransportTripPage(driver);
            _driver = driver;
        }
    }
}
