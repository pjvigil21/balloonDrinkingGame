﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour {
	private Camera _camera;

	void Start () {
		_camera = GetComponent<Camera> ();

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void OnGUI() { 
		int size = 20;
		float posX = _camera.pixelWidth / 2 - size / 4;
		float posY = _camera.pixelHeight / 2 - size / 2;
		GUI.Label (new Rect (posX, posY, size, size), "*");
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 point = new Vector3 (_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
			Ray ray = _camera.ScreenPointToRay (point);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				//StartCoroutine (CylinderIndicator (hit.point));
		}
	}
}
	//private IEnumerator CylinderIndicator (Vector3 pos) {
		//GameObject cylinder = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		//cylinder.transform.position = pos;

		//yield return new WaitForSeconds (10);

		//Destroy (cylinder);
}


