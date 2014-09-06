using UnityEngine;

namespace CUE
{
	namespace TestingCode
	{
		public class CUE_Logger : MonoBehaviour 
		{
			void Start () 
			{
				Debug.Log("Is Windows: " 	+ CUE.System.Platform.IsWindows().ToString());
				Debug.Log("Is Mac: " 		+ CUE.System.Platform.IsOSX().ToString());
				Debug.Log("Is Linux: " 		+ CUE.System.Platform.IsLinux().ToString());
				Debug.Log("Is Web Player: " + CUE.System.Platform.IsWebPlayer().ToString());
				Debug.Log("Is Editor: " 	+ CUE.System.Platform.IsEditor().ToString());
			}

			/*
			void Update ()
			{
				
			}
			//*/
		}
	}
}