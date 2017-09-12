using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3DPlus : MonoBehaviour {

	// Use this for initialization
	public GameObject mover; 
	public int MovementAmt = 2;
	public Vector3 startingPosition;
	public GameObject winSpot;

	// Use this for initialization
	void Start () {
		startingPosition = mover.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (mover.transform.position.z < -4 ||
			mover.transform.position.z > 9 ||
			mover.transform.position.x < 0 ||
			mover.transform.position.x > -6) {
			mover.transform.position = startingPosition;
		}
		if (mover.transform.position == 
			new Vector3(winSpot.transform.position.x,
				mover.transform.position.y,
				winSpot.transform.position.z)){
			Debug.Log ("win?");
			//mover.GetComponent<MeshRender> ().color = Color.red;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			Debug.Log ("true");
			mover.transform.position += new Vector3 (MovementAmt,0,0);
		} else {
			Debug.Log ("false");
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Debug.Log ("true");
			mover.transform.position += new Vector3 (-MovementAmt,0,0);
		} else {
			Debug.Log ("false");
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("true");
			mover.transform.position += new Vector3 (0, 0, MovementAmt);
		} else {
			Debug.Log ("false");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("true");
			mover.transform.position += new Vector3 (0, 0, -MovementAmt);
		} else {
			Debug.Log ("false");
		}

	}
}
