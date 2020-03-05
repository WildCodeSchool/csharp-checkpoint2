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

		[Test]
		public void TestPresentEvent()
		{
			Event presentEvent = CreatePresentEvent();

			Assert.IsTrue(presentEvent.IsPresent);
		}

		[Test]
		public void TestPresentEventIsNotPassed()
		{
			Event presentEvent = CreatePresentEvent();

			Assert.IsFalse(happeningEvent.IsPassed);
		}

		[Test]
		public void TestEventIsPassed()
		{
			Event pastEvent = CreatePastEvent();

			Assert.IsTrue(pastEvent.IsPassed);
		}

		[Test]
		public void TestEventIsFuture()
		{
			Event futureEvent = CreateFutureEvent();

			Assert.IsTrue(futureEvent.IsFuture);
		}
	}
}
