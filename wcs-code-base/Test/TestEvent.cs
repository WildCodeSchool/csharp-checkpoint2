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

		[Test]
		public void TestPresentEvent()
		{
			Event presentEvent = ApiTest.CreateDelayedEvent();

			Assert.IsTrue(presentEvent.IsPresent);
		}

		[Test]
		public void TestPresentEventIsNotPassed()
		{
			Event presentEvent = CreateDelayedEvent();

			Assert.IsFalse(happeningEvent.IsPassed);
		}

		[Test]
		public void TestEventIsPassed()
		{
			Event pastEvent = ApiTest.CreateDelayedEvent(TimeSpan.FromHours(-1));

			Assert.IsTrue(pastEvent.IsPassed);
		}

		[Test]
		public void TestEventIsFuture()
		{
			Event futureEvent = ApiTest.CreateDelayedEvent(TimeSpan.FromHours(1));

			Assert.IsTrue(futureEvent.IsFuture);
		}

		[Test]
		public void TestFutureIsNotPresent()
		{
			Event futureEvent = CreateFutureEvent(TimeSpan.FromHours(1));

			Assert.IsFalse(futureEvent.IsPresent);
		}
	}
}
