using UnityEngine;
using System.Collections;

public class Triggers_Lives_Countdown : MonoBehaviour {
	//this will be our global scorekeeper, the "ref" so to speak
	public GLOBAL globalRef;

	void Start() {
	  //This is how you access another gameobject's scripties
		globalRef = GameObject.Find("Referee").GetComponent<GLOBAL>();
	}


	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") 
		{
			
			//play FX
			audio.Play();
			
			//collect into inventory and remove from gamescreen
	
		  //you have another set of glasses ->  +1!
			globalRef.PlusOne();
	
	    //remove from gamescreen
			Destroy(this.gameObject);
	  	
		}
	}
	
	
}
