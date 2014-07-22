using UnityEngine;
using System.Collections;

public class TenPrint : MonoBehaviour {
	int characterCounter = 0; 


	// Update is called once per frame
	void Update () {
		int coin = Random.Range (0,2); //gives 0 or 1, second values is exclusive 
		if (coin == 1) {
			GetComponent<TextMesh>().text = GetComponent<TextMesh>().text + "/"; 
		} else {
			GetComponent<TextMesh>().text += "\\"; //short cut for Line 12
		}
		//characterCounter = characterCounter + 1;
		characterCounter ++; //same code as 16 which adds one to variable similar to --;
		if ( characterCounter > 20) {
			GetComponent<TextMesh>().text += "\n";
			characterCounter = 0;
		}
	}
}