using UnityEngine;
using System.Collections;

public class RayCast1 : MonoBehaviour {

	// 2 ways of clicking on something 


	void Start () {
	
	}
	
	void Update () {
		//    access main camera        access the postion of the mouse  --> created ray (origin and a direction)
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		// initializes a "RaycastHit" info container
		RaycastHit rayHit = new RaycastHit (); // empty, blank

		//  shoot the raycast     work around, distance && if click with left click
		if (Physics.Raycast ( ray, out rayHit, 1000f) && Input.GetMouseButtonDown (0) ) {
		
			Debug.Log ("Hit");
			Destroy (rayHit.transform.gameObject);

		}

	}
}
