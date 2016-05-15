using UnityEngine;
using System.Collections;

public class TiltFirstAxis : MonoBehaviour {

	public GameObject plane;

	// Use this for initialization
	void Start () {
		plane = GameObject.Find ("GameArea");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (plane.transform.position);

		float zPos = this.transform.position.z;
		float xAngle = plane.transform.eulerAngles.x;

		Debug.Log("zPos: " + zPos);
		Debug.Log("Plane angles: " + xAngle);


		float scaledPos = -(zPos/20);

		//Debug.Log (xPos);
		//Debug.Log (scaledPos);

		if(zPos > 1 && (xAngle < 9 || xAngle > 352)){
			plane.transform.Rotate (scaledPos, 0, 0);
		}

		if(zPos < -1 && (xAngle < 8 || xAngle > 351)){
			plane.transform.Rotate (scaledPos, 0, 0);
		}
	}
}
