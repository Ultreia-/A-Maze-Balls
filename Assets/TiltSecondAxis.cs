using UnityEngine;
using System.Collections;

public class TiltSecondAxis : MonoBehaviour {
	
	public GameObject plane;

	// Use this for initialization
	void Start () {
		plane = GameObject.Find ("GameArea");
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (plane.transform.position);

		float xPos = this.transform.position.x;
		float zAngle = plane.transform.eulerAngles.z;

		Debug.Log("xPos: " + xPos);
		Debug.Log("Plane angles: " + zAngle);


		float scaledPos = -(xPos/20);

		//Debug.Log (xPos);
		//Debug.Log (scaledPos);

		if(xPos > 1 && (zAngle < 9 || zAngle > 352)){
			plane.transform.Rotate (0, 0, scaledPos);
		}

		if(xPos < -1 && (zAngle < 8 || zAngle > 351)){
			plane.transform.Rotate (0, 0, scaledPos);
		}
	}
}
