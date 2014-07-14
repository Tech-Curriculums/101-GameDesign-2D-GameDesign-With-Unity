using UnityEngine;
using System.Collections;

public class Triggers_Collision_2_Destroy : MonoBehaviour {


		void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
				Destroy(this.gameObject);
			audio.Play();
		}
	}
}
