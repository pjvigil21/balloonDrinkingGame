using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dart : MonoBehaviour {

	public Rigidbody projectile;

	public float speed = 20;

	void Start () {
		transform.Rotate (90, 0, 0);
	}
		

	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;

			instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, speed, 0));
		}
	}
}
