using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactiveTarget : MonoBehaviour {

	int randomNumber; 

	private void Start() {
		randomNumber = Random.Range (1, 11);
	}
	
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Bullet")
		{
			Destroy(this.gameObject);
			Debug.Log("Take this many drinks:" + randomNumber);
		}
	}
}
