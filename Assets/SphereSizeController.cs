using UnityEngine;
using System.Collections;

public class SphereSizeController : MonoBehaviour {

	public GameObject sphere1;
	public GameObject sphere2;
	public float scale = 0.0F;

	// Use this for initialization
	void Start () {
		sphere1 = GameObject.Find("Sphere1");
		sphere2 = GameObject.Find("Sphere2");
	}
		
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow) && scale < 0.5F) {
				scale = scale + 0.01F;
		}

		if (Input.GetKey (KeyCode.LeftArrow) && scale > -0.5F) {
				scale = scale - 0.01F;
		}

		sphere1.transform.localScale = new Vector3 (1.5F - scale, 1.5F - scale, 1.5F - scale);
		sphere2.transform.localScale = new Vector3 (1.5F + scale, 1.5F + scale, 1.5F + scale);
			
	}
}
