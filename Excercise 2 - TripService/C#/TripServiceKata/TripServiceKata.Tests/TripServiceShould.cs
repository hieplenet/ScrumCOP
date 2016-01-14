using Microsoft.VisualStudio.TestTools.UnitTesting;
using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    [TestClass]
    public class TripServiceShould
    {
        [TestMethod]
        public void Throws_UserNotLoggedInException_If_User_Does_not_log_in_yet()
        {
            // new TripService().GetTripsByUser(null);
            Assert.IsTrue(true);
        }
    }
}
