namespace CUE
{
	namespace DataType
	{
		public static class ConversionExtentionMethods 
		{
			public static bool ToBoolean(this string str)
			{
				if(str.Length > 5)
				{
					return false;
				}

				bool boolean = false;
				
				// Force lower case
				str = str.ToLower();
				
				switch(str)
				{
				case "true":
					boolean = true; break;
				case "false":
					boolean = false; break;
				case "yes":
					boolean = true; break;
				case "no":
					boolean = false; break;
				default:
					boolean = false; break;
				}
				
				return boolean;
			}
			
		}
	}
}