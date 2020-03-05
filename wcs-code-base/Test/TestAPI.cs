namespace WCSTest
{
	public class ApiTest
	{
		public static AbstractEvent CreatePresentEvent()
		{
			AbstractEvent newEvent = new Event("TestPresent");
			newEvent.StartTime = DateTime.Now - TimeSpan.Hours(1);
			newEvent.EndTime = DateTime.Now + TimeSpan.Hours(1); 
			return newEvent;
		}

		public static AbstractEvent CreateFutureEvent()
		{
			AbstractEvent newEvent = new Event("TestFuture");
			newEvent.StartTime = DateTime.Now + TimeSpan.Hours(1);
			newEvent.EndTime = DateTime.Now + TimeSpan.Hours(2); 
			return newEvent;
		}
		public static AbstractEvent CreatePastEvent()
		{
			AbstractEvent newEvent = new Event("TestPast");
			newEvent.StartTime = DateTime.Now - TimeSpan.Hours(2);
			newEvent.EndTime = DateTime.Now - TimeSpan.Hours(1); 
			return newEvent;
		}
	}
}
