using NUnit.Framework;

namespace WCSTest
{
	[TestFixture]
	public class TestEvent
	{
		public void TestEventPostponed()
		{
			Event presentEvent = ApiTest.CreateDelayedEvent();
			DateTime startDateBeforePostpone = presentEvent.StartDate;
			DateTime endDateDateBeforePostpone = presentEvent.EndDate;
			presentEvent.Postpone(TimeSpan.FromDays(1));

			Assert.AreEqual(startDateBeforePostpone, presentEvent.StartDate - TimeSpan.FromDays(1));
			Assert.AreEqual(endDateBeforePostpone, presentEvent.EndDate - TimeSpan.FromDays(1));
		}
	}
}
