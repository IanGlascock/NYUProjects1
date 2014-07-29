using UnityEngine;
using System.Collections;

public class introtext : MonoBehaviour {


	// Update is called once per frame
	void Update () {
	
		GetComponent<TextMesh>().text = "Explore this perfect\nroom by pressing W\n and your mouse";
	}
}
