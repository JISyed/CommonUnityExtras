using UnityEngine;

namespace CUE
{
	namespace Objects
	{
		public class DestroyAfterTime : MonoBehaviour 
		{
			public float timeInSeconds = 10.0f;

			// Use this for initialization
			void Start () 
			{
				if(timeInSeconds < 0.0f)
				{
					timeInSeconds = 0.0f;
				}

				Destroy(gameObject, timeInSeconds);
			}

		}
	}
}