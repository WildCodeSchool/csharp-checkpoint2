using NUnit.Framework;

namespace WCSTest
{
	[TestFixture]
	public class TestPlanning
	{
		private Planning _planning;

		[SetUp]
		public void SetUp()
		{
			_planning = new Planning();
		}

		public void TestGetPostponed()
		{
			Event event = CreateDelayedEvent();
			event.Postpone(TimeSpan.FromHours(1));

			Assert.AreEqual(1, _planning.PostponedEvents.Count);
		}
	}
}

