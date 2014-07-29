using UnityEngine;
using System.Collections;

public class RigidbodyContorllerA : MonoBehaviour {

	float turnSpeed = 80f; 
	float moveSpeed = 200f;
	float jumpForce = 100f;
	Vector3 moveVector; 

	void Update () {
		// turn using horizontal Mouse movment ... does NOt use physics system (torque)
		transform.Rotate (0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f);

		//moveVector = transform.forward * Input.GetAxis ("Vertical") + 
	}

	//all Physics rididbody call should be made in FixedUpdate 
	void FixedUpdate () {

			//physics force, movement forward and backward, using keybaord "Vertical" axis
			GetComponent<Rigidbody>().AddForce (transform.forward * Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime);
			//physics force, movement sideways, using keyboard Horizontal axis
			GetComponent<Rigidbody>().AddForce (transform.right * Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime);

		//jump up, if spaceis pressed
		if (Input.GetKeyUp (KeyCode.Space)) {
			GetComponent<Rigidbody>().AddForce (Vector3.up * jumpForce);
		}
	}

}
