using UnityEngine;
using System.Collections;

public class KeyText : MonoBehaviour {


	void Update () {
		GetComponent<TextMesh>().text = "You can use the key \n to leave but why would\nyou?";

	}
}
