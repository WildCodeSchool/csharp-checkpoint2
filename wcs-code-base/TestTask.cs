using NUnit.Framework;

namespace WCSTest
{
	[TestFixture]
	public class TestEvent
	{
		public void TestEventPostponed()
		{
			Event presentEvent = CreatePresentEvent();
			DateTime dateBeforePostpone = DateTime.Now + presentEvent.Delay;
			presentEvent.Postpone(TimeSpan.FromDays(1));
			DateTime dateAfterPostpone = dateBeforePostpone + presentEvent.Delay;

			Assert.AreEqual(dateBeforePostpone, dateAfterPostpone - TimeSpan.FromDays(1));
		}
}
