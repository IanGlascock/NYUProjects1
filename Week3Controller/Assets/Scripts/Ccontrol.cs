using UnityEngine;
using System.Collections;

public class Ccontrol : MonoBehaviour {

	int MoveSpeed = 2;
	float yRotate = 5f;

	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)){
			print ("up key pressed");
			GetComponent<Transform>().position += transform.forward * MoveSpeed;
		}
		if (Input.GetKey (KeyCode.RightArrow)){
			print ("right pressed");
			GetComponent<Transform>().eulerAngles += new Vector3 (0,yRotate,0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)){
			print ("left pressed");
		
			GetComponent<Transform>().eulerAngles += new Vector3 (0,yRotate *(-1),0);

		}

	}
}
