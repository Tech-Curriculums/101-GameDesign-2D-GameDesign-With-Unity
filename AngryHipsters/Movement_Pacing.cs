//This script causes a character to pace back and forth
//each left and right walk's duration is controlled by `walkDuration` variable

using UnityEngine;
using System.Collections;

public class Movement_Pacing : MonoBehaviour
{
	float walkDuration = 3.0f;
	float timeLeft = 3.0f ;
	bool goright=true;

	
	// Update is called once per frame
	void Update ()
	{
		Movement();
	}
	
	void Movement() {

		if(timeLeft > 0 && goright)
		{
			transform.Translate(Vector2.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0,0);
			timeLeft -= Time.deltaTime;
		}
		else if(timeLeft <= 0 && goright)
		 {
				timeLeft = -walkDuration;
				goright=false;
		}
		else if( timeLeft <=0 && !goright)
			{
			transform.Translate(-Vector2.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0,0);
			timeLeft += Time.deltaTime;
		}
		else if(timeLeft > 0 && !goright)
		{
			timeLeft = walkDuration;
			goright=true;
		}

	}


}

