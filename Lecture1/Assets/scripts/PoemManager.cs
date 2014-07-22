using UnityEngine;
using System.Collections;

public class PoemManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World");

		GetComponent<TextMesh>().text = "scarred trees Waver not\nthe Ax stroke is remembered\n Rotting spreads from the \ncore";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
