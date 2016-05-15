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
		float yAngle = plane.transform.eulerAngles.y;
		float zAngle = plane.transform.eulerAngles.z;

		Debug.Log("zPos: " + zPos);
		Debug.Log("Plane angles: " + xAngle);


		float scaledPos = -(zPos/20);

		//Debug.Log (xPos);
		//Debug.Log (scaledPos);

		plane.transform.rotation = Quaternion.Euler (zPos, yAngle, zAngle);
	}
}
