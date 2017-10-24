using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float movementSpeed = 5.0f;
	public GameObject cameraRig;

	void FixedUpdate () {
		float horizontalMovement = Input.GetAxis ("Horizontal");
		float verticalMovement = Input.GetAxis ("Vertical");

		horizontalMovement *= Time.deltaTime * movementSpeed;
		verticalMovement *= Time.deltaTime * movementSpeed;

		cameraRig.transform.Translate (horizontalMovement, 0.0f, verticalMovement);
	}
}
