using UnityEngine;
using System.Collections;

public class Movement_Circling : MonoBehaviour
{
	float walkDuration = 1.0f;
	float timeLeft = 1.0f ;
	bool goright=true;
	
	
	// Update is called once per frame
	void Update ()
	{
		Movement();
	}
	
	void Movement() {
		
		if(timeLeft > 0 && goright)
		{
			transform.Translate( Vector2.right * 4f * Time.deltaTime*Mathf.Sin(Time.time));
			transform.Translate( Vector2.up * 4f * Time.deltaTime*Mathf.Cos(Time.time));
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
			transform.Translate(-Vector2.right * 4f * Time.deltaTime*Mathf.Sin(Time.time));
			transform.Translate( -Vector2.up * 4f * Time.deltaTime*Mathf.Cos(Time.time));
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



