using UnityEngine;
using System.Collections;

public class TriggerParent : MonoBehaviour {


	public Transform key; //assign in unity inspector
	public Transform Door; //assign in unity inspector

	// you will need a trigger-collider on this object
	void OnTriggerEnter (Collider player) {
		key.parent = player.transform;
	}

	
}
