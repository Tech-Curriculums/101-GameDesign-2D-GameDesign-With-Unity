using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {
	//this will be our global scorekeeper, the "ref" so to speak
	public GLOBAL globalRef;
	public Sounds soundFX;
	public int moveOut = 0;


	//movement scripts copypasta
	public float speed = 1F;
	Vector2 differenceVector, touchPositionTarget;
	

	void Start() {
		//This is how you access another gameobject's scripties
		globalRef = GameObject.Find("Referee").GetComponent<GLOBAL>();
		soundFX = GameObject.Find("SoundFX").GetComponent<Sounds>();

		touchPositionTarget.x = transform.position.x;
		touchPositionTarget.y = transform.position.y;


	}
	
	
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") 
		{
			if ( globalRef.getNumberOfGlasses() > 0) 
			{
			//play FX
			soundFX.screech();
			//collect into inventory and remove from gamescreen
			
			//you have another set of glasses ->  +1!

			//remove from gamescreen
			//	Destroy(GameObject.Find("player"));
				GameObject.Find("player").renderer.enabled = false;
				Camera.main.transform.parent = transform;
				moveOut=1;	


				//DriveOut();
				StartCoRoutine( go2NextLevel();

			} 
		}
	}


	public IEnumerator go2NextLevel()
	{
		yield return new WaitForSeconds (3);
		Application.LoadLevel ("Stationary");
	}




	void Update() {
		if (moveOut == 1) {			
				touchPositionTarget.x = transform.position.x + 1000;
				transform.position = Vector2.MoveTowards( transform.position, touchPositionTarget, speed * Time.deltaTime);
			}
	}

	
}
