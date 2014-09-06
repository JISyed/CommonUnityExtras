using TimeSpan = System.TimeSpan;

namespace CUE
{
	namespace DataType
	{
		public static class FormattingExtentionMethods 
		{
			public static string FormattedClockString(this TimeSpan time)
			{
				string formatedTime = "";
				
				if((int) time.TotalHours >= 1)
				{
					formatedTime = string.Format ("{0:0}:{1:00}:{2:00}", 
					                              (int)time.TotalHours, 
					                              time.Minutes, 
					                              time.Seconds);
				}
				else
				{
					formatedTime = string.Format ("{0:0}:{1:00}", 
					                              time.Minutes, 
					                              time.Seconds);
				}
				
				return formatedTime;
			}

		}
	}
}