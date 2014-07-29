using UnityEngine;
using System.Collections;

public class Removal : MonoBehaviour {

	public Transform key; //assign in unity inspector
	public Transform Door; //assign in unity inspector

	void OnTriggerEnter (Collider Door) {
		Destroy ( key.gameObject );
		Destroy ( Door.gameObject );

	}
}
