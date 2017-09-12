using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3D : MonoBehaviour {

	public GameObject mover; 
	public Vector3 movementAmount;
	public Vector3 movementSpace;
	public Vector3 movement;
	public Vector3 movement2;

	// Use this for initialization
	void Start () {
		movementAmount = new Vector3 (2, 0, 0);
		movementSpace = new Vector3 (-2, 0, 0);
		movement = new Vector3 (0, 0, 2);
		movement2 = new Vector3 (0, 0, -2);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			Debug.Log ("true");
			mover.transform.position += movementAmount;
		} else {
			Debug.Log ("false");
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Debug.Log ("true");
			mover.transform.position += movementSpace;
		} else {
			Debug.Log ("false");
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("true");
			mover.transform.position += movement;
		} else {
			Debug.Log ("false");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("true");
			mover.transform.position += movement2;
		} else {
			Debug.Log ("false");
		}
	}
}
