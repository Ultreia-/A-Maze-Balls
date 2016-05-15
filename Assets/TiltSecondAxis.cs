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
		float yAngle = plane.transform.eulerAngles.y;
		float xAngle = plane.transform.eulerAngles.x;

		Debug.Log("xPos: " + xPos);
		Debug.Log("Plane angles: " + zAngle);


		float scaledPos = -(xPos/20);

		//Debug.Log (xPos);
		//Debug.Log (scaledPos);

		plane.transform.rotation = Quaternion.Euler (xAngle, yAngle, xPos);

	}
}
