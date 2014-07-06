//This is used for player control
//this script is yet to implement boundaries


using UnityEngine;
using System.Collections;

public class Controls_Player_2D : MonoBehaviour
{

		
		// Update is called once per frame
		void Update ()
		{
				Movement ();
		}

		void Movement ()
		{
				if (Input.GetKey (KeyCode.D)) {
						transform.Translate (Vector2.right * 4f * Time.deltaTime);
						transform.eulerAngles = new Vector2 (0, 0);

				}
				if (Input.GetKey (KeyCode.A)) {
						transform.Translate (-Vector2.right * 4f * Time.deltaTime);
						transform.eulerAngles = new Vector2 (0, 0);
				}
				if (Input.GetKey (KeyCode.W)) {
						transform.Translate (Vector2.up * 4f * Time.deltaTime);
						transform.eulerAngles = new Vector2 (0, 0);
				
				}
				if (Input.GetKey (KeyCode.S)) {
						transform.Translate (-Vector2.up * 4f * Time.deltaTime);
						transform.eulerAngles = new Vector2 (0, 0);
				}
		}
}

