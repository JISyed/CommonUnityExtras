
namespace CUE
{
	namespace System
	{
		public static class Random 
		{
			public static bool PercentChance(int percentage)
			{
				if(percentage < 0)
					return false;
				
				if(percentage > 100)
					return true;
				
				int outcome = UnityEngine.Random.Range(1, 100);
				
				if(outcome <= percentage)
					return true;
				
				return false;
			}
			
			public static bool PercentChance(float percentage)
			{
				if(percentage <= 0.0f)
					return false;
				
				if(percentage > 100.0f)
					return true;
				
				float outcome = UnityEngine.Random.Range(0.0f, 100.0f);
				
				if(outcome <= percentage)
					return true;
				
				return false;
			}
		}
	}
}