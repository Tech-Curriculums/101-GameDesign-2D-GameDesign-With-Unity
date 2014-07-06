//This c# script senses when the player collides with the object

using UnityEngine;
using System.Collections;

public class trigger_points : MonoBehaviour {



	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			audio.Play();
		}
	}
}
