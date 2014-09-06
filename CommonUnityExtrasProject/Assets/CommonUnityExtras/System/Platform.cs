using UnityEngine;

namespace CUE
{
	namespace System
	{
		public static class Platform
		{
			public static bool IsWindows()
			{
				return Application.platform == RuntimePlatform.WindowsPlayer
					|| Application.platform == RuntimePlatform.WindowsEditor
					|| Application.platform == RuntimePlatform.WindowsWebPlayer;
			}

			public static bool IsOSX()
			{
				return Application.platform == RuntimePlatform.OSXPlayer
					|| Application.platform == RuntimePlatform.OSXEditor
					|| Application.platform == RuntimePlatform.OSXWebPlayer;
			}

			public static bool IsLinux()
			{
				return Application.platform == RuntimePlatform.LinuxPlayer;
			}

			public static bool IsWebPlayer()
			{
				return Application.isWebPlayer;
			}

			public static bool IsNativePlayer()
			{
				return Application.platform == RuntimePlatform.WindowsPlayer
					|| Application.platform == RuntimePlatform.OSXPlayer
					|| Application.platform == RuntimePlatform.LinuxPlayer;
			}

			public static bool IsEditor()
			{
				return Application.isEditor;
			}
		}
	}
}
