using UnityEngine;
using System.Collections;	// Needed for IEnumerator

namespace CUE
{
	namespace Objects
	{
		public class SpawnOnceDelayed : MonoBehaviour 
		{
			public float timeInSeconds;
			public GameObject prefabToSpawn;
			
			// Use this for initialization
			IEnumerator Start () 
			{
				// Wait for the assigned time
				yield return new WaitForSeconds(timeInSeconds);
				
				// Spawn object
				Instantiate(prefabToSpawn);
				
				// Self-destruct
				Destroy(gameObject);
			}
		}
	}
}
