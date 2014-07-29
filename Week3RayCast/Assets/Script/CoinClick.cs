using UnityEngine;
using System.Collections;

public class CoinClick : MonoBehaviour {

	//this is like a ray cast but Unit does all the work
	void OnMouseUpAsButton () {

		//This is the same as 
		//GetComponent<Transform>().
		transform.localScale *= 2f;


		Debug.Log ("Scale Change");
	}



}
