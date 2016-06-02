using UnityEngine;
using System.Collections;

public class SphereSizeController : MonoBehaviour {

	public GameObject sphere1;
	public GameObject sphere2;
	private float sizeSphere1 = 1.5F;
	private float sizeSphere2 = 1.5F;

	// Use this for initialization
	void Start () {
		sphere1 = GameObject.Find("Sphere1");
		sphere2 = GameObject.Find("Sphere2");
	}
		
	// Update is called once per frame
	void Update () {
		sphere1.transform.localScale = new Vector3 (sizeSphere1, sizeSphere1, sizeSphere1);
		sphere2.transform.localScale = new Vector3 (sizeSphere2, sizeSphere2, sizeSphere2);
	}

	public void setSizeSphere1(string stringSizeSphere1) {
		sizeSphere1 = float.Parse (stringSizeSphere1);
		Debug.Log (sizeSphere1);
	}

	public void setSizeSphere2(string stringSizeSphere2) {
		sizeSphere2 = float.Parse (stringSizeSphere2);
	}
}
