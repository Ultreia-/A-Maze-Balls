using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Collision Detected!");
		StartCoroutine (resetLevelAfterDelay());

	}

	IEnumerator resetLevelAfterDelay() {
		yield return new WaitForSeconds(2);
		Application.LoadLevel(Application.loadedLevel);
	}
}
