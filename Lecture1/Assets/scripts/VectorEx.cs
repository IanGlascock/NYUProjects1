using UnityEngine;
using System.Collections;

public class VectorEx : MonoBehaviour {
	// allows for access public to var. which has context
	public float speed = 5f;
	// acces too variriable direction 
	public Vector3 direction;

	// Use this for initialization
	void Start () {
		//checks position of object 
		Debug.Log (GetComponent<Transform>().position);	
	}
	
	// Update is called once per frame
	void Update () {
		//                             add to sellf ammount         * change in time to adjust for dif. in FPS
		//GetComponent<Transform>().position += new Vector3(1f,1f,0f) * Time.deltaTime * speed;
		// makes the direction a variable that is editable in Unity
		GetComponent<Transform>().position += direction * Time.deltaTime * speed;
	}
}
