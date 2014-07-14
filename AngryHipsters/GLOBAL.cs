using UnityEngine;
using System.Collections;

public class GLOBAL : MonoBehaviour {

	private  int glasses = 0;
	public  int getNumberOfGlasses() {
		return glasses;
	}

	public int Hipped(int hits) {
		if (glasses >= 1) {
			glasses--;
		}
		return glasses;
	}
	public  void PlusOne() {
		glasses++;
	}
}

