using UnityEngine;
using System.Collections;

public class TiltSecondAxis : MonoBehaviour {
	
	private GameObject plane;
	public float scale = 1;


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

		//Debug.Log("xPos: " + xPos);
		//Debug.Log("Plane angles: " + zAngle);


		float mappedPos = ExtensionMethods.Remap(xPos, -10, 10, -10, 10);

		//Debug.Log (xPos);
		//Debug.Log (scaledPos);

		plane.transform.rotation = Quaternion.Euler (mappedPos*scale, yAngle, zAngle);

	}
}
