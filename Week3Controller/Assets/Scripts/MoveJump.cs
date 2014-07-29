using UnityEngine;
using System.Collections;

public class MoveJump : MonoBehaviour {

	int MoveSpeed = 2;
	float yRotate = 5f;

	void Update () {

		CharacterController controller = GetComponent<CharacterController>();

		if (Input.GetKey (KeyCode.UpArrow)){
			print ("up key pressed");
			GetComponent<Transform>().position += transform.forward * MoveSpeed;
		}
		else if (Input.GetKey (KeyCode.RightArrow)){
			print ("right pressed");
			GetComponent<Transform>().eulerAngles += new Vector3 (0,yRotate,0);
		}
		else if (Input.GetKey (KeyCode.LeftArrow)){
			print ("left pressed");
			GetComponent<Transform>().eulerAngles += new Vector3 (0,yRotate *(-1),0);
		}
		//else if (Input.GetKeyDown (KeyCode.Space) && (controller.isGrounded)) {

		//}

	}

}
