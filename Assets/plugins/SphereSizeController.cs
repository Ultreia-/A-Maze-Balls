using UnityEngine;
using System.Collections;

public class SphereSizeController : MonoBehaviour {

	private GameObject sphere1;
	private GameObject sphere2;
	private float diameterSphere1 = 1.5F;
	private float diameterSphere2 = 1.5F;

	// Use this for initialization
	void Start () {
		sphere1 = GameObject.Find("Sphere1");
		sphere2 = GameObject.Find("Sphere2");
	}
		
	// Update is called once per frame
	void Update () {
		
		bool correctInputSphere1 = (diameterSphere1 >= 1.0F && diameterSphere1 <= 2.0F);
		bool correctInputSphere2 = (diameterSphere2 >= 1.0F && diameterSphere2 <= 2.0F);

		if (correctInputSphere1 && correctInputSphere2) { 	
			//sphere1.transform.localScale = new Vector3(sizeSphere1, sizeSphere1, sizeSphere1);

			Vector3 newSphere1Size = new Vector3 (diameterSphere1, diameterSphere1, diameterSphere1);
			sphere1.transform.localScale = Vector3.Slerp(sphere1.transform.localScale, newSphere1Size, 0.1F);

			Vector3 newSphere2Size = new Vector3 (diameterSphere2, diameterSphere2, diameterSphere2);
			sphere2.transform.localScale = Vector3.Slerp(sphere2.transform.localScale, newSphere2Size, 0.1F);
		}
	}

	public void setSizeSphere1(string stringSizeSphere1) {
		diameterSphere1 = float.Parse (stringSizeSphere1);
		Debug.Log (diameterSphere1);
	}

	public void setSizeSphere2(string stringSizeSphere2) {
		diameterSphere2 = float.Parse (stringSizeSphere2);
		Debug.Log (diameterSphere2);

	}
}
