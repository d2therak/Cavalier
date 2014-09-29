using UnityEngine;
using System.Collections;

public class zombie_Class : MonoBehaviour {

	public static int hp = 5;
	// Update is called once per frame
	void Update () {

		if(hp >= 0)
		{
			Destroy(gameObject);
		}
	
	}
}
