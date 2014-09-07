using UnityEngine;

namespace CUE
{
	namespace Objects
	{
		public class DestroyOnInvisible : MonoBehaviour 
		{
			// Use this for initialization
			void Start () 
			{
				
			}

			void OnBecameInvisible()
			{
				Destroy(gameObject);
			}
		}
	}
}
