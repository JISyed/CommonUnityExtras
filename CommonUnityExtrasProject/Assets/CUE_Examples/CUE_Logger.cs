using UnityEngine;
using TimeSpan = System.TimeSpan;
using DateTime = System.DateTime;

using CUE.DataType;

namespace CUE
{
	namespace TestingCode
	{
		public class CUE_Logger : MonoBehaviour 
		{
			void Start () 
			{
				TimeSpan time = DateTime.Now - DateTime.Today;
				Debug.Log(time.FormattedClockString());

				bool bTrue = "TRUE".ToBoolean();
				bool bFalse = "false".ToBoolean();
				bool yYes = "Yes".ToBoolean();
				bool yNo = "nO".ToBoolean();

				Debug.Log(bTrue.ToString());
				Debug.Log(bFalse.ToString());
				Debug.Log(yYes.ToString());
				Debug.Log(yNo.ToString());
			}

			/*
			void Update ()
			{
				
			}
			//*/
		}
	}
}